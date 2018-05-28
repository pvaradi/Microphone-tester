using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Proba
{
    class ChartBuilder
    {
        public Chart[] MeasurementDisplay = new Chart[20];
        private Form1 form1;

        public ChartBuilder(Form1 form1)
        {
            this.form1 = form1;

            for (int i = 0; i <= 19; i++)
            {
                ChartArea chartArea1 = new ChartArea();
                Legend legend1 = new Legend();
                Series series1 = new Series();
                Series series2 = new Series();
                Series series3 = new Series();
                Series series4 = new Series();

                MeasurementDisplay[i] = new Chart();
                var _TabID = "tabPage" + (i + 1);
                var _splitContainerID = "splitContainer" + (i + 1);


                ((System.ComponentModel.ISupportInitialize)(MeasurementDisplay[i])).BeginInit();
                form1.SuspendLayout();

                chartArea1.Name = "ChartArea1";

                MeasurementDisplay[i].ChartAreas.Add(chartArea1);
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisX.Minimum = 1;
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisY.Minimum = 0;
                
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.True;
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisY2.MajorGrid.Enabled = false;
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisY2.MinorGrid.Enabled = false;
                MeasurementDisplay[i].ChartAreas["ChartArea1"].AxisY2.LineWidth = 0;

                legend1.Name = "Legend1";
                MeasurementDisplay[i].Legends.Add(legend1);
                MeasurementDisplay[i].Location = new System.Drawing.Point(0, 0);
                MeasurementDisplay[i].Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
                MeasurementDisplay[i].Name = "Chart_Measurement";
                series1.ChartArea = "ChartArea1";
                series1.ChartType = SeriesChartType.FastLine;
                series1.Legend = "Legend1";
                series1.Name = "Current mA";
                series2.ChartArea = "ChartArea1";
                series2.ChartType = SeriesChartType.FastLine;
                series2.Legend = "Legend1";
                series2.Name = "Temperature";
                series3.ChartArea = "ChartArea1";
                series3.ChartType = SeriesChartType.FastLine;
                series3.Legend = "Legend1";
                series3.Name = "Humidity";
                MeasurementDisplay[i].Series.Add(series1);
                MeasurementDisplay[i].Series.Add(series2);
                MeasurementDisplay[i].Series.Add(series3);
                //MeasurementDisplay[i].Size = new System.Drawing.Size(700, 410);
                MeasurementDisplay[i].Dock = DockStyle.Fill;
                MeasurementDisplay[i].TabIndex = 1;
                MeasurementDisplay[i].Text = "chart1";
                MeasurementDisplay[i].Series["Current mA"].BorderWidth = 3;
                MeasurementDisplay[i].Series["Temperature"].BorderWidth = 3;
                MeasurementDisplay[i].Series["Humidity"].BorderWidth = 3;

                MeasurementDisplay[i].Series["Current mA"].SetCustomProperty("LineTension", "0.15");
                MeasurementDisplay[i].Series["Temperature"].SetCustomProperty("LineTension", "0.15");
                MeasurementDisplay[i].Series["Humidity"].SetCustomProperty("LineTension", "0.15");

                MeasurementDisplay[i].Series["Current mA"].Color = Color.LightGreen;
                MeasurementDisplay[i].Series["Temperature"].Color = Color.Red;
                MeasurementDisplay[i].Series["Humidity"].Color = Color.Blue;
                MeasurementDisplay[i].Series["Temperature"].YAxisType = AxisType.Secondary;
                MeasurementDisplay[i].Series["Humidity"].YAxisType = AxisType.Secondary;

                ((System.ComponentModel.ISupportInitialize)(MeasurementDisplay[i])).EndInit();

                ((SplitContainer)form1.tabControl1.TabPages[_TabID].Controls[_splitContainerID]).Panel1.Controls.Add(MeasurementDisplay[i]);

            }
        }
    }
}
