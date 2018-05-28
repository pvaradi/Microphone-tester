using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadSavedSettings();
        }

        private void LoadSavedSettings()
        {
            textBoxTemperature.Text = Properties.Settings.Default.chamberTemperature;
            textBoxHumidity.Text = Properties.Settings.Default.chamberHumidity;
            textBoxDigitalOut.Text = Properties.Settings.Default.chamberDigitalOut;
            textBoxStartStatus.Text = Properties.Settings.Default.chamberStartStatus;
            textBoxArchivePath.Text = Properties.Settings.Default.chamberArchivePath;
            textBoxProgramPath.Text = Properties.Settings.Default.chamberProgramPath;
            textBoxChamberName.Text = Properties.Settings.Default.chamberName;
            textBoxArchiveName.Text = Properties.Settings.Default.chamberArchiveName;
            textBoxProgramName.Text = Properties.Settings.Default.chamberProgramName;
        }

        private void btnSaveChamberConfig_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.chamberTemperature = textBoxTemperature.Text;
            Properties.Settings.Default.chamberHumidity = textBoxHumidity.Text;
            Properties.Settings.Default.chamberDigitalOut = textBoxDigitalOut.Text;
            Properties.Settings.Default.chamberStartStatus = textBoxStartStatus.Text;
            Properties.Settings.Default.chamberArchivePath = textBoxArchivePath.Text;
            Properties.Settings.Default.chamberProgramPath = textBoxProgramPath.Text;
            Properties.Settings.Default.chamberName = textBoxChamberName.Text;
            Properties.Settings.Default.chamberArchiveName = textBoxArchiveName.Text;
            Properties.Settings.Default.chamberProgramName = textBoxProgramName.Text;

            Properties.Settings.Default.Save();
        }
    }
}
