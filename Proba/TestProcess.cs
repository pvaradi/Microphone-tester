using NAudio.Wave;
using Proba.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proba
{
    class TestProcess
    {
        ChannelConfigurator channelConfigurator;
        K2700 k2700;
        TCPClient tcpClient;
        bool testwasstopped = false;
        bool TCPconnected = true;
        bool K2700frontSwitchOn = true;
        Thread testProcessStart;
        DUTSample[] testSample;

        string measuredTemp = "0";
        string measuredHum = "0";
        string measuredCurrent = "0";
        string digitalChannelState = "0";
        string digitalChannelStart = "0";
        bool chamberProgramStarted = false;
        int measuredChannel;
        int scanRate;


        public delegate void DataUpdateHandler(object sender, DataUpdateEventArgs e);
        public event DataUpdateHandler DataUpdated;

        public delegate void TestAbortedHandler(object sender, TestAbortedEventArgs e);
        public event TestAbortedHandler TestAborted;

        public void Start()
        {
            Properties.Settings.Default.savedTestStartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            Properties.Settings.Default.Save();

            scanRate = Properties.Settings.Default.savedScanRate * 1000;

            k2700 = new K2700();
            tcpClient = new TCPClient();

            testwasstopped = false;

            tcpClient.TCPConnectionFailure += new TCPClient.TCPConnectFailureHandler(tcpClientDisconnected);
            k2700.InstrumentSwitchedOff += new K2700.InstrumentSwitchedOffHandler(k2700FrontswitchOff);

            testSample = new DUTSample[20];

            // A teszt indításához mindenképpen szükséges 1db csatorna konfigurációja
            // Az 1db konfigurált csatorna beállításait az alábbi rész felhasználja
            // az üres csatornák emptystreammel való konfigurálásához

            for (int i = 0; i < 20; i++)
            {
                testSample[0] = this.channelConfigurator.getItem(0);
            }

            // A konfigurált DUT adatok lekérése a Loudspeaker adapterből a ChannelConfiguratoron keresztül

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    testSample[i] = this.channelConfigurator.getItem(i);
                }
                catch
                {
                    testSample[i] = null;
                }
            }

            k2700.OpenComPort();
            k2700.ConfigTest();
            K2700frontSwitchOn = true;

            tcpClient.setMeasuredValue("ProgramName");
            tcpClient.TCPClientRun();
            if (TCPconnected == true)
            {
                string[] chamberInfo = tcpClient.measuredData.Split('?', '\r');
                Settings.Default.savedChamberProgramFileName = chamberInfo[1];

                tcpClient.setMeasuredValue("ProgramPath");
                tcpClient.TCPClientRun();
                chamberInfo = tcpClient.measuredData.Split('?', '\r');
                Settings.Default.savedChamberProgramFilePath = chamberInfo[1];

                tcpClient.setMeasuredValue("ArchiveName");
                tcpClient.TCPClientRun();
                chamberInfo = tcpClient.measuredData.Split('?', '\r');
                Settings.Default.savedChamberArchiveFileName = chamberInfo[1];

                tcpClient.setMeasuredValue("ArchivePath");
                tcpClient.TCPClientRun();
                chamberInfo = tcpClient.measuredData.Split('?', '\r');
                Settings.Default.savedChamberArchiveFilePath = chamberInfo[1];

                Settings.Default.Save();

                TestProcessStart();            
            }
        }

        public void Stop()
        {
                Properties.Settings.Default.savedTestFinishedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                Properties.Settings.Default.Save();
                testwasstopped = true;
                channelConfigurator.RemoveItems();
                k2700.Reset();
                k2700.CloseComPort();

                
                for (int i = 0; i < 20; i++)
                {
                    if (testSample[i] != null)
                    {
                        new SaveLog(testSample[i], testSample[i].TestID + ".pdf");
                    }
                }
                
        }

        public TestProcess(ChannelConfigurator channelConfigurator)
        {
            this.channelConfigurator = channelConfigurator;
        }

        public void TestProcessStart()
        {
            testProcessStart = new Thread(new ThreadStart(testLoop));
            testProcessStart.Start();
        }

        public void testLoop()
        {
            while (testwasstopped == false && K2700frontSwitchOn == true && TCPconnected == true)
            {
                if (Properties.Settings.Default.savedTestSignalMode == "Chamber controlled" && chamberProgramStarted == false)
                {
                    performChamberStartStatus();
                    if (digitalChannelStart == "1\r\n")
                    {
                        chamberProgramStarted = true;
                    }
                    Thread.Sleep(5000);
                }
                else if (Properties.Settings.Default.savedTestSignalMode == "Chamber controlled" && chamberProgramStarted == true)
                {
                    performChamberStartStatus();
                    if (digitalChannelStart == "0\r\n")
                    {
                        chamberProgramStarted = false;
                        TestAbortedEventArgs testFinished = new TestAbortedEventArgs(true);
                        TestAborted(this, testFinished);
                    }
                }

                if (Properties.Settings.Default.savedTestSignalMode == "Chamber controlled" && chamberProgramStarted == true || Properties.Settings.Default.savedTestSignalMode == "Timer")
                {
                    for (int i = 0; i < 20 && testwasstopped == false; i++)
                    {
                        if (testSample[i] != null)
                        {
                            performVoltageMeasurementOnChannel(Int32.Parse(testSample[i].ChNumber));
                            if (TCPconnected == true)
                            {
                                performTemperatureMeasurement();
                                performHumidityMeasurement();
                                performDigitalChannelMeasurement();
                            }

                            Thread.Sleep(scanRate);

                            processMeasurementData();

                            if ((testSample[i].LowerTestLimit > (int)Convert.ToDouble(measuredCurrent)) || (testSample[i].UpperTestLimit < (int)Convert.ToDouble(measuredCurrent)))
                            {
                                testSample[i].Limitexceeded = true;
                                testSample[i].TestResult = "Failed";
                            }

                            DataUpdateEventArgs args = new DataUpdateEventArgs(measuredTemp, measuredHum, measuredCurrent, measuredChannel, testSample[i].Limitexceeded);
                            DataUpdated(this, args);
                        }
                    }
                }
            }
        }

        private void tcpClientDisconnected(object sender, TCPConnectFailureEventArgs e) 
        {
            TCPconnected = e.TCPconnected;
            TestAbortedEventArgs args = new TestAbortedEventArgs(true);
            TestAborted(this, args);
        }

        private void k2700FrontswitchOff(object sender, InstrumentSwitchedOffEventArgs e) 
        {
            K2700frontSwitchOn = e.FrontSwitchOn;
            TestAbortedEventArgs args = new TestAbortedEventArgs(true);
            TestAborted(this, args);
        }

        private void processMeasurementData()
        {
            string linesCurrent = k2700.measuredCurrent;

            int readFrom = linesCurrent.IndexOf(',');
            measuredChannel = Int32.Parse(linesCurrent.Substring(readFrom + 2, 2));
            linesCurrent = linesCurrent.Remove(readFrom);
            linesCurrent = linesCurrent.Replace("+", "");
            linesCurrent = linesCurrent.Replace('.', ',');
            measuredCurrent = (Double.Parse(linesCurrent, System.Globalization.NumberStyles.Float)*1000).ToString();   // V -> mV konverzió
        }

        private void performHumidityMeasurement()
        {
            tcpClient.setMeasuredValue("Humidity");
            tcpClient.TCPClientRun();
                string[] linesHum = tcpClient.measuredData.Split('?', '.');
                measuredHum = linesHum[1];
        }

        private void performTemperatureMeasurement()
        {
            tcpClient.setMeasuredValue("Temperature");
            tcpClient.TCPClientRun();
                string[] linesTemp = tcpClient.measuredData.Split('?', '.');
                measuredTemp = linesTemp[1];
        }

        private void performDigitalChannelMeasurement()
        {
            tcpClient.setMeasuredValue("DigitalOut");
            tcpClient.TCPClientRun();
            string[] linesDCH = tcpClient.measuredData.Split('?', '.');
            digitalChannelState = linesDCH[1];
        }

        private void performChamberStartStatus()
        {
            tcpClient.setMeasuredValue("StartStatus");
            tcpClient.TCPClientRun();
            string[] linesDCH = tcpClient.measuredData.Split('?', '.');
            digitalChannelStart = linesDCH[1];
        }

        private void performVoltageMeasurementOnChannel(int chNumber)
        {
            if (chNumber < 10)
                k2700.MeasureCurrent("@10" + chNumber.ToString());
            else
                k2700.MeasureCurrent("@1" + chNumber.ToString());
        }
    }

    public class TestAbortedEventArgs : System.EventArgs
    {
        private bool mTestAborted;

        public TestAbortedEventArgs(bool sTestAborted)
        {
            this.mTestAborted = sTestAborted;
        }

        public bool TestAborted
        {
            get
            {
                return mTestAborted;
            }
        }

    }

    public class DataUpdateEventArgs : System.EventArgs
    {
        private string mmeasuredTemp;
        private string mmeasuredHum;
        private string mmeasuredCurrent;
        private int mmeasuredChannel;
        private bool mlimitexceeded;


        public DataUpdateEventArgs(string smeasuredTemp, string smeasuredHum, string smeasuredCurrent, int smeasuredChannel, bool slimitexceeded)
        {
            this.mmeasuredTemp = smeasuredTemp;
            this.mmeasuredHum = smeasuredHum;
            this.mmeasuredCurrent = smeasuredCurrent;
            this.mmeasuredChannel = smeasuredChannel;
            this.mlimitexceeded = slimitexceeded;
        }

        public string measuredTemp
        {
            get
            {
                return mmeasuredTemp;
            }
        }

        public string measuredHum
        {
            get
            {
                return mmeasuredHum;
            }
        }

        public string measuredCurrent
        {
            get
            {
                return mmeasuredCurrent;
            }
        }

        public int measuredChannel
        {
            get
            {
                return mmeasuredChannel;
            }
        }

        public bool limitexceeded
        {
            get
            {
                return mlimitexceeded;
            }
        }
    }
}