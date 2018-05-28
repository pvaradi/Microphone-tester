using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    class K2700
    {
        SerialPort ComPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        string InputData = String.Empty;
        public string measuredCurrent = "0";

        public bool frontSwitchOn = false;
        public bool instrumentStateOn = false;
        public delegate void InstrumentSwitchedOffHandler(object sender, InstrumentSwitchedOffEventArgs e);
        public event InstrumentSwitchedOffHandler InstrumentSwitchedOff;

        public void OpenComPort()
        {
            ComPort.PortName = Convert.ToString(Properties.Settings.Default.savedComPort);
            ComPort.BaudRate = Convert.ToInt32(Properties.Settings.Default.savedBaudRate.ToString());
            ComPort.DataBits = Convert.ToInt16(Properties.Settings.Default.savedDataBits.ToString());
            ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.savedStopBits);
            ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), Properties.Settings.Default.savedHandshake);
            ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.savedParity);

            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

            try
            {
                ComPort.Open();
                instrumentStateOn = true;
            }
            catch 
            {
                frontSwitchOn = false;
                instrumentStateOn = false;
                MessageBox.Show("K2700 instumend is not on connected to " + ComPort.PortName);
                InstrumentSwitchedOffEventArgs args = new InstrumentSwitchedOffEventArgs(frontSwitchOn);
                InstrumentSwitchedOff(this, args);
            }
            if (instrumentStateOn == true)
            {
                Reset();
                ComPort.Write("DISP:ENAB OFF\r\n");
            }
        }

        public void CloseComPort()
        {
            if (instrumentStateOn == true)
            {
                ComPort.Write("DISP:ENAB ON\r\n");

                try
                {
                    ComPort.Close();
                }
                catch
                {
                    ;
                }
            }
        }

        public void Reset()
        {
            if (instrumentStateOn == true)
            {
                ComPort.Write("*RST\r\n");
            }
        }

        public void ConfigTest()
        {
            if (instrumentStateOn == true)
            {
                ComPort.Write("*RST\r\n");
                ComPort.Write("TRIG:DEL 0\r\n");
                ComPort.Write("SENS:FUNC 'VOLT:DC'\r\n");
                ComPort.Write("VOLT:DC:RANG 0.1\r\n");
                ComPort.Write("VOLT:DC:NPLC 1\r\n");
                ComPort.Write("VOLT:DC:DIG 6\r\n");
                ComPort.Write("FORM:ELEM READ, CHAN\r\n");
                ComPort.Write("DISP:ENAB ON\r\n");

                CheckFrontSwitch();
            }
        }

        public void CheckFrontSwitch()
        {
            ComPort.Write("SYST:FRSW?\r\n");
        }

        public void CheckRelayCondition()
        {
            if (instrumentStateOn == true)
            {
                ComPort.Write("ROUT:CLOS:COUN? (@101:120)\r\n");
            }
        }

        public void MeasureCurrent(string channel)
        {
            ComPort.Write("ROUT:CLOS (" + channel + ")\r\n");
            ComPort.Write("READ?\r\n");
        }


        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            while (!InputData.Contains("\r"))
            {
                InputData = InputData + ComPort.ReadExisting();
            }
            if (InputData.Equals("1\r"))
            {
                frontSwitchOn = false;
                MessageBox.Show("K2700 Instrument Front switch is in OFF state!");
                InstrumentSwitchedOffEventArgs args = new InstrumentSwitchedOffEventArgs(frontSwitchOn);
                InstrumentSwitchedOff(this, args);
            }
            else if (InputData.Equals("0\r"))
            {
                frontSwitchOn = true;
            }
            else if (InputData != String.Empty)
            {
                measuredCurrent = InputData;
            }
            InputData = String.Empty;
        }
    }

    public class InstrumentSwitchedOffEventArgs : System.EventArgs
    {
        private bool mfrontSwitchOn;

        public InstrumentSwitchedOffEventArgs(bool sfrontSwitchOn)
        {
            this.mfrontSwitchOn = sfrontSwitchOn;
        }

        public bool FrontSwitchOn
        {
            get
            {
                return mfrontSwitchOn;
            }
        }

    }
}
