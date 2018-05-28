using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeUIelements();
            LoadSavedSettings();
        }

        private void LoadSavedSettings()
        {
            labelLogFileLocation.Text = Properties.Settings.Default.savedLogFileLocation;
            comboBoxComPort.Text = Properties.Settings.Default.savedComPort;
            comboBoxBaudRate.Text = Properties.Settings.Default.savedBaudRate.ToString();
            comboBoxDataBits.Text = Properties.Settings.Default.savedDataBits.ToString();
            comboBoxStopBits.Text = Properties.Settings.Default.savedStopBits.ToString();
            comboBoxParity.Text = Properties.Settings.Default.savedParity;
            comboBoxHandshaking.Text = Properties.Settings.Default.savedHandshake;
            comboBoxSignalMode.Text = Properties.Settings.Default.savedTestSignalMode;
            maskedTextBoxTCPAddress.Text = Properties.Settings.Default.savedIPAddress;
            maskedTextBoxTCPPort.Text = Properties.Settings.Default.savedPort;
            textBoxInstrumentName.Text = Properties.Settings.Default.savedInstrumentName;
            textBoxInstrumentSerial.Text = Properties.Settings.Default.savedInstrumentSerial;
            textBoxChamberName.Text = Properties.Settings.Default.savedChamberName;
            textBoxChamberSerial.Text = Properties.Settings.Default.savedChamberSerial;
            numericUpDownScanRate.Value = Properties.Settings.Default.savedScanRate;
        }

        private void InitializeUIelements()
        {
            //Com Ports
            SearchForCOMPorts();
            //Baud Rate
            comboBoxBaudRate.Items.Add(9600);
            comboBoxBaudRate.Items.Add(4800);
            comboBoxBaudRate.Items.Add(2400);
            comboBoxBaudRate.Items.Add(1200);
            //Data Bits
            comboBoxDataBits.Items.Add(8);
            comboBoxDataBits.Items.Add(7);
            //Stop Bits
            comboBoxStopBits.Items.Add("One");
            //Parity 
            comboBoxParity.Items.Add("None");
            //Handshake
            comboBoxHandshaking.Items.Add("XOnXOff");
            comboBoxHandshaking.Items.Add("None");
            //Instrument name and serial
            textBoxInstrumentName.Text = "K2700";
            textBoxInstrumentSerial.Text = "4093987";
            //Chamber name and serial
            textBoxChamberName.Text = "WLK100";
            textBoxChamberSerial.Text = "4093987";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.savedComPort = comboBoxComPort.Text;
            Properties.Settings.Default.savedBaudRate = Int32.Parse(comboBoxBaudRate.Text);
            Properties.Settings.Default.savedDataBits = Int32.Parse(comboBoxDataBits.Text);
            Properties.Settings.Default.savedStopBits = comboBoxStopBits.Text;
            Properties.Settings.Default.savedParity = comboBoxParity.Text;
            Properties.Settings.Default.savedHandshake = comboBoxHandshaking.Text;
            Properties.Settings.Default.savedIPAddress = maskedTextBoxTCPAddress.Text;
            Properties.Settings.Default.savedPort = maskedTextBoxTCPPort.Text;
            Properties.Settings.Default.savedInstrumentName = textBoxInstrumentName.Text;
            Properties.Settings.Default.savedInstrumentSerial = textBoxInstrumentSerial.Text;
            Properties.Settings.Default.savedChamberName = textBoxChamberName.Text;
            Properties.Settings.Default.savedChamberSerial = textBoxChamberSerial.Text;
            Properties.Settings.Default.savedTestSignalMode = comboBoxSignalMode.Text;
            Properties.Settings.Default.savedScanRate = Convert.ToInt32(numericUpDownScanRate.Value);

            Properties.Settings.Default.Save();
        }

        private void btnLogFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog logFileLocation = new FolderBrowserDialog();
            logFileLocation.Description = "Please select a log file path";
            if (logFileLocation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Log file location changed to:" + logFileLocation.SelectedPath);
            }
            Properties.Settings.Default.savedLogFileLocation = logFileLocation.SelectedPath;
            Properties.Settings.Default.Save();
            labelLogFileLocation.Text = logFileLocation.SelectedPath;
        }

        private void SearchForCOMPorts()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                comboBoxComPort.Items.Add(ArrayComPortsNames[index]);

            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
        }

        private void btnChamberCommands_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
