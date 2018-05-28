using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proba
{
    public partial class Form1 : Form
    {
        ChannelConfigurator channelConfigurator;
        TestProcess testProcess;
        ChartBuilder chartBuilder;
        bool[] channelConfigured = new bool[20];
        bool testRunning = false;
        Random random = new Random();
        Stopwatch stopWatch = new Stopwatch();
        DataGridView[] dataGridViewContainer;
        Label[] labels;


        public Form1()
        {
            InitializeComponent();
            channelConfigurator = new ChannelConfigurator();
            testProcess = new TestProcess(channelConfigurator);
            chartBuilder = new ChartBuilder(this);
            testProcess.DataUpdated += new TestProcess.DataUpdateHandler(UpdateGraph);
            testProcess.TestAborted += new TestProcess.TestAbortedHandler(TestAborted);

            dataGridViewContainer = new DataGridView[20] { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10, dataGridView11, dataGridView12, dataGridView13, dataGridView14, dataGridView15, dataGridView16, dataGridView17, dataGridView18, dataGridView19, dataGridView20 };
            labels = new Label[] { labelCH1, labelCH2, labelCH3, labelCH4, labelCH5, labelCH6, labelCH7, labelCH8, labelCH9, labelCH10, labelCH11, labelCH12, labelCH13, labelCH14, labelCH15, labelCH16, labelCH17, labelCH18, labelCH19, labelCH20};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Process[] pname = Process.GetProcessesByName("SIMSERV");
            if (pname.Length == 0)
            {
                MessageBox.Show("Simpati or Simserv.exe is not running!");
                Application.Exit();
            }
            */
            /*
            for (int i = 0; i < 20; i++)
            {
                for (int s = 0; s < 20; s++)
                {
                    dataGridViewContainer[i].Rows.Add(20, 20, 20, 20);
                }
            }
            */
        }

        private void btnConfig1_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(1);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig2_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(2);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig3_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(3);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig4_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(4);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig5_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(5);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig6_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(6);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig7_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(7);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig8_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(8);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig9_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(9);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig10_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(10);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig11_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(11);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig12_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(12);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig13_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(13);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig14_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(14);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig15_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(15);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig16_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(16);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig17_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(17);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig18_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(18);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig19_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(19);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void btnConfig20_Click(object sender, EventArgs e)
        {
            channelConfigurator.ConfigureChannel(20);
            channelConfigurator.ChannelUpdated += new ChannelConfigurator.ChannelUpdateHandler(UpdateLabel);
        }

        private void UpdateLabel(object sender, ChannelConfigurator.ChannelUpdateEventArgs e)
        {
            switch (e.chNumber)
            {
                case "1":
                    labelSampleData1.Text = updateLabelWithData(e);
                    channelConfigured[0] = true;
                    btnStart.Enabled = true;
                    break;
                case "2":
                    labelSampleData2.Text = updateLabelWithData(e);
                    channelConfigured[1] = true;
                    btnStart.Enabled = true;
                    break;
                case "3":
                    labelSampleData3.Text = updateLabelWithData(e);
                    channelConfigured[2] = true;
                    btnStart.Enabled = true;
                    break;
                case "4":
                    labelSampleData4.Text = updateLabelWithData(e);
                    channelConfigured[3] = true;
                    btnStart.Enabled = true;
                    break;
                case "5":
                    labelSampleData5.Text = updateLabelWithData(e);
                    channelConfigured[4] = true;
                    btnStart.Enabled = true;
                    break;
                case "6":
                    labelSampleData6.Text = updateLabelWithData(e);
                    channelConfigured[5] = true;
                    btnStart.Enabled = true;
                    break;
                case "7":
                    labelSampleData7.Text = updateLabelWithData(e);
                    channelConfigured[6] = true;
                    btnStart.Enabled = true;
                    break;
                case "8":
                    labelSampleData8.Text = updateLabelWithData(e);
                    channelConfigured[7] = true;
                    btnStart.Enabled = true;
                    break;
                case "9":
                    labelSampleData9.Text = updateLabelWithData(e);
                    channelConfigured[8] = true;
                    btnStart.Enabled = true;
                    break;
                case "10":
                    labelSampleData10.Text = updateLabelWithData(e);
                    channelConfigured[9] = true;
                    btnStart.Enabled = true;
                    break;
                case "11":
                    labelSampleData11.Text = updateLabelWithData(e);
                    channelConfigured[10] = true;
                    btnStart.Enabled = true;
                    break;
                case "12":
                    labelSampleData12.Text = updateLabelWithData(e);
                    channelConfigured[11] = true;
                    btnStart.Enabled = true;
                    break;
                case "13":
                    labelSampleData13.Text = updateLabelWithData(e);
                    channelConfigured[12] = true;
                    btnStart.Enabled = true;
                    break;
                case "14":
                    labelSampleData14.Text = updateLabelWithData(e);
                    channelConfigured[13] = true;
                    btnStart.Enabled = true;
                    break;
                case "15":
                    labelSampleData15.Text = updateLabelWithData(e);
                    channelConfigured[14] = true;
                    btnStart.Enabled = true;
                    break;
                case "16":
                    labelSampleData16.Text = updateLabelWithData(e);
                    channelConfigured[15] = true;
                    btnStart.Enabled = true;
                    break;
                case "17":
                    labelSampleData17.Text = updateLabelWithData(e);
                    channelConfigured[16] = true;
                    btnStart.Enabled = true;
                    break;
                case "18":
                    labelSampleData18.Text = updateLabelWithData(e);
                    channelConfigured[17] = true;
                    btnStart.Enabled = true;
                    break;
                case "19":
                    labelSampleData19.Text = updateLabelWithData(e);
                    channelConfigured[18] = true;
                    btnStart.Enabled = true;
                    break;
                case "20":
                    labelSampleData20.Text = updateLabelWithData(e);
                    channelConfigured[19] = true;
                    btnStart.Enabled = true;
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (channelConfigured[0] == true)
                labelCH1.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[1] == true)
                labelCH2.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[2] == true)
                labelCH3.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[3] == true)
                labelCH4.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[4] == true)
                labelCH5.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[5] == true)
                labelCH6.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[6] == true)
                labelCH7.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[7] == true)
                labelCH8.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[8] == true)
                labelCH9.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[9] == true)
                labelCH10.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[10] == true)
                labelCH11.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[11] == true)
                labelCH12.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[12] == true)
                labelCH13.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[13] == true)
                labelCH14.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[14] == true)
                labelCH15.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[15] == true)
                labelCH16.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[16] == true)
                labelCH17.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[17] == true)
                labelCH18.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[18] == true)
                labelCH19.BackColor = System.Drawing.Color.Lime;
            if (channelConfigured[19] == true)
                labelCH20.BackColor = System.Drawing.Color.Lime;

            labelTestStatus.Text = "Status: Test Running";

            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnAppConfig.Enabled = false;
            btnConfig1.Enabled = false;
            btnConfig2.Enabled = false;
            btnConfig3.Enabled = false;
            btnConfig4.Enabled = false;
            btnConfig5.Enabled = false;
            btnConfig6.Enabled = false;
            btnConfig7.Enabled = false;
            btnConfig8.Enabled = false;
            btnConfig9.Enabled = false;
            btnConfig10.Enabled = false;
            btnConfig11.Enabled = false;
            btnConfig12.Enabled = false;
            btnConfig13.Enabled = false;
            btnConfig14.Enabled = false;
            btnConfig15.Enabled = false;
            btnConfig16.Enabled = false;
            btnConfig17.Enabled = false;
            btnConfig18.Enabled = false;
            btnConfig19.Enabled = false;
            btnConfig20.Enabled = false;

            numericUpDown1.Enabled = false;
            //timer1.Enabled = true;
            //timer2.Enabled = true;
            testRunning = true;

            if (Properties.Settings.Default.savedTestSignalMode == "Timer")
            {
                timer1.Interval = (1000 * 60 * 60 * Convert.ToInt32(numericUpDown1.Value));
                progressBarTest.Maximum = timer1.Interval / 1000;
                timer2.Interval = 1000;
                timer1.Start();
                timer2.Start();
                stopWatch.Start();
                timer1.Enabled = true;
                timer2.Enabled = true;
            }

            testProcess.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            resetGUI();

            btnStop.Enabled = false;
            btnStart.Enabled = false;
            btnAppConfig.Enabled = true;
            btnConfig1.Enabled = true;
            btnConfig2.Enabled = true;
            btnConfig3.Enabled = true;
            btnConfig4.Enabled = true;
            btnConfig5.Enabled = true;
            btnConfig6.Enabled = true;
            btnConfig7.Enabled = true;
            btnConfig8.Enabled = true;
            btnConfig9.Enabled = true;
            btnConfig10.Enabled = true;
            btnConfig11.Enabled = true;
            btnConfig12.Enabled = true;
            btnConfig13.Enabled = true;
            btnConfig14.Enabled = true;
            btnConfig15.Enabled = true;
            btnConfig16.Enabled = true;
            btnConfig17.Enabled = true;
            btnConfig18.Enabled = true;
            btnConfig19.Enabled = true;
            btnConfig20.Enabled = true;

            labelSampleData1.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData2.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData3.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData4.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData5.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData6.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData7.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData8.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData9.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData10.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData11.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData12.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData13.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData14.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData15.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData16.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData17.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData18.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData19.Text = "ID:" + System.Environment.NewLine + "PN:";
            labelSampleData20.Text = "ID:" + System.Environment.NewLine + "PN:";

            labelCH1.BackColor = System.Drawing.Color.LightGray;
            labelCH2.BackColor = System.Drawing.Color.LightGray;
            labelCH3.BackColor = System.Drawing.Color.LightGray;
            labelCH4.BackColor = System.Drawing.Color.LightGray;
            labelCH5.BackColor = System.Drawing.Color.LightGray;
            labelCH6.BackColor = System.Drawing.Color.LightGray;
            labelCH7.BackColor = System.Drawing.Color.LightGray;
            labelCH8.BackColor = System.Drawing.Color.LightGray;
            labelCH9.BackColor = System.Drawing.Color.LightGray;
            labelCH10.BackColor = System.Drawing.Color.LightGray;
            labelCH11.BackColor = System.Drawing.Color.LightGray;
            labelCH12.BackColor = System.Drawing.Color.LightGray;
            labelCH13.BackColor = System.Drawing.Color.LightGray;
            labelCH14.BackColor = System.Drawing.Color.LightGray;
            labelCH15.BackColor = System.Drawing.Color.LightGray;
            labelCH16.BackColor = System.Drawing.Color.LightGray;
            labelCH17.BackColor = System.Drawing.Color.LightGray;
            labelCH18.BackColor = System.Drawing.Color.LightGray;
            labelCH19.BackColor = System.Drawing.Color.LightGray;
            labelCH20.BackColor = System.Drawing.Color.LightGray;

            channelConfigured[0] = false;
            channelConfigured[1] = false;
            channelConfigured[2] = false;
            channelConfigured[3] = false;
            channelConfigured[4] = false;
            channelConfigured[5] = false;
            channelConfigured[6] = false;
            channelConfigured[7] = false;
            channelConfigured[8] = false;
            channelConfigured[9] = false;
            channelConfigured[10] = false;
            channelConfigured[11] = false;
            channelConfigured[12] = false;
            channelConfigured[13] = false;
            channelConfigured[14] = false;
            channelConfigured[15] = false;
            channelConfigured[16] = false;
            channelConfigured[17] = false;
            channelConfigured[18] = false;
            channelConfigured[19] = false;

        }

        private string updateLabelWithData(ChannelConfigurator.ChannelUpdateEventArgs e)
        {
            return "ID: " + e.testID + System.Environment.NewLine + "PN: " + e.partNumber;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAppConfig_Click(object sender, EventArgs e)
        {
            Form3 appConfigurationForm = new Form3();
            appConfigurationForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnStop.PerformClick();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBarTest.Value = progressBarTest.Value + 1;
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            labelTestStatus.Text = "Status: Test Running - " + numericUpDown1.Value.ToString() + ":00:00 / " + elapsedTime;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (1000 * 60 * 60 * Convert.ToInt32(numericUpDown1.Value)); 
        }

        private void UpdateGraph(object sender, DataUpdateEventArgs e) 
        {
            if (testRunning == true)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    chartBuilder.MeasurementDisplay[e.measuredChannel - 1].Series["Current mA"].Points.AddY(float.Parse(e.measuredCurrent));
                    chartBuilder.MeasurementDisplay[e.measuredChannel - 1].Series["Temperature"].Points.AddY(Int32.Parse(e.measuredTemp));
                    chartBuilder.MeasurementDisplay[e.measuredChannel - 1].Series["Humidity"].Points.AddY(Int32.Parse(e.measuredHum));

                    dataGridViewContainer[e.measuredChannel - 1].Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), e.measuredCurrent, e.measuredTemp, e.measuredHum);

                    if (e.limitexceeded == true)
                    {
                        labels[e.measuredChannel - 1].BackColor = Color.Red;
                    }
                });
            }
        }

        private void TestAborted(object sender, TestAbortedEventArgs e)
        {
			this.Invoke((MethodInvoker)delegate
            {									   
				btnStop.PerformClick();
            });
        }

        private void resetGUI()
        {
            //MeasurementDisplay[0].SaveImage(appRootDir + "/TestLog/" + "chart1.png", ChartImageFormat.Png);
            testRunning = false;

            for (int i = 1; i < 21; i++)
            {
                foreach (Chart pb in ((SplitContainer)tabControl1.TabPages["tabPage" + i.ToString()].Controls["splitContainer" + i.ToString()]).Panel1.Controls.Find("Chart_Measurement", true))
                {
                    pb.SaveImage(Properties.Settings.Default.savedLogFileLocation + "\\" + "chart" + i.ToString() + ".png", ChartImageFormat.Png);
                    dataGridViewContainer[i - 1].Rows.Clear();
                    dataGridViewContainer[i - 1].Refresh();

                    foreach (var series in chartBuilder.MeasurementDisplay[i - 1].Series)
                    {
                        series.Points.Clear();
                    }
                }
            }

            if (Properties.Settings.Default.savedTestSignalMode == "Timer")
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer2.Stop();
                timer2.Enabled = false;
                stopWatch.Stop();
                stopWatch.Reset();
                progressBarTest.Value = 0;
                labelTestStatus.Text = "Status: Idle";
                numericUpDown1.Enabled = true;
            }

            testProcess.Stop();
        }

    }
}
