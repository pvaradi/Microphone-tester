using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    class TCPClient
    {
        TcpClient client;               
        NetworkStream stream;           
        byte[] indata = new byte[1024]; 
        byte[] outdata = new byte[1024];
        private int recievedDataLength;
        public string measuredData;
        private string measuredValue;

        bool TCPconnected = false;

        public delegate void TCPConnectFailureHandler(object sender, TCPConnectFailureEventArgs e);
        public event TCPConnectFailureHandler TCPConnectionFailure;

        public void Connect()
        {
            try
            {
                client = new TcpClient(Properties.Settings.Default.savedIPAddress, Int32.Parse(Properties.Settings.Default.savedPort));
                TCPconnected = true;
            }
            catch (Exception ex)
            {
                TCPconnected = false;
                MessageBox.Show("TCP Connection failed - Run SIMPATI and Simserv.exe!");
                TCPConnectFailureEventArgs args = new TCPConnectFailureEventArgs(TCPconnected);
                TCPConnectionFailure(this, args);
            }
        }

        public void ClientReceive()
        {
            Array.Clear(indata, 0, indata.Length);
            stream = client.GetStream();
            recievedDataLength = stream.Read(indata, 0, indata.Length);
            measuredData = Encoding.ASCII.GetString(indata, 0, recievedDataLength);
        }

        public void ClientSend(string measuredValue)
        {
            Array.Clear(outdata, 0, outdata.Length);
            stream = client.GetStream();                        
            outdata = Encoding.Default.GetBytes(measuredValue + "\r");    
            stream.Write(outdata, 0, outdata.Length);           
        }

        public void TCPClientRun()
        {
            Connect();
            if (TCPconnected == true)
            {
                ClientSend(measuredValue);
                ClientReceive();
                client.GetStream().Close();
                stream.Flush();
                stream.Close();
                client.Close();
            }
        }

        public void TCPClientStart()
        {
            Thread tcpserverrunthread = new Thread(new ThreadStart(TCPClientRun));
            tcpserverrunthread.Start();
        }

        public void setMeasuredValue(string measuredValue)
        {
            switch (measuredValue)
            {
                case "Temperature":
                    this.measuredValue = Properties.Settings.Default.chamberTemperature;
                    break;
                case "Humidity":
                    this.measuredValue = Properties.Settings.Default.chamberHumidity;
                    break;
                case "DigitalOut":
                    this.measuredValue = Properties.Settings.Default.chamberDigitalOut;
                    break;
                case "StartStatus":
                    this.measuredValue = Properties.Settings.Default.chamberStartStatus;
                    break;
                case "ArchivePath":
                    this.measuredValue = Properties.Settings.Default.chamberArchivePath;
                    break;
                case "ProgramPath":
                    this.measuredValue = Properties.Settings.Default.chamberProgramPath;
                    break;
                case "ArchiveName":
                    this.measuredValue = Properties.Settings.Default.chamberArchiveName; ;
                    break;
                case "ProgramName":
                    this.measuredValue = Properties.Settings.Default.chamberProgramName;
                    break;
                case "ChamberName":
                    this.measuredValue = Properties.Settings.Default.chamberName;
                    break;
            }
        }
    }

    public class TCPConnectFailureEventArgs : System.EventArgs
    {
        private bool mTCPconnected;

        public TCPConnectFailureEventArgs(bool sTCPconnected)
        {
            this.mTCPconnected = sTCPconnected;
        }

        public bool TCPconnected
        {
            get
            {
                return mTCPconnected;
            }
        }

    }
}
