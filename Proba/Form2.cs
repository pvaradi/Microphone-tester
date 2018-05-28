using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form2 : Form
    {

        public delegate void ConfigUpdateHandler(object sender, ConfigUpdateEventArgs e);
        public event ConfigUpdateHandler ConfigUpdated;

        private string chNumber;

        public Form2(string chNumber)
        {
            InitializeComponent();
            label1.Text = "Channel" + chNumber + " - Configuration";
            textBoxTestID.Text = generateTestID() + "-CH" + chNumber;
            this.chNumber = chNumber;

        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string schNumber = chNumber;
            string spartNumber = textBoxPartNumber.Text;
            string stestID = textBoxTestID.Text;
            string scustomer = comboBoxCustomer.Text;
            string stestType = comboBoxTestType.Text;
            int slowerTestLimit = Convert.ToInt32(numericLowerTestLimit.Value);
            int supperTestLimit = Convert.ToInt32(numericUpperTestLimit.Value);
            bool slimitexceeded = false;
            string stestResult = "Passed";

            ConfigUpdateEventArgs args = new ConfigUpdateEventArgs(schNumber, spartNumber, scustomer, stestType, stestID, slowerTestLimit, supperTestLimit, slimitexceeded, stestResult);
            ConfigUpdated(this, args);

            this.Close();
        }

        private string generateTestID() {
            DateTime now = DateTime.Now;
            return now.ToString("yyyyMMdd-HHmm");
        }


        public class ConfigUpdateEventArgs : System.EventArgs
        {
            private string mpartNumber;
            private string mchNumber;
            private string mtestID;
            private string mcustomer;
            private string mtestType;
            private int mupperTestLimit;
            private int mlowerTestLimit;
            private bool mlimitexceeded;
            private string mtestResult;

            public ConfigUpdateEventArgs(string schNumber, string spartNumber, string scustomer, string stestType, string stestID, int slowerTestLimit, int supperTestLimit, bool slimitexceeded, string stestResult)
            {
                this.mpartNumber = spartNumber;
                this.mchNumber = schNumber;
                this.mcustomer = scustomer;
                this.mtestType = stestType;
                this.mtestID = stestID;
                this.mlowerTestLimit = slowerTestLimit;
                this.mupperTestLimit = supperTestLimit;
                this.mlimitexceeded = slimitexceeded;
                this.mtestResult = stestResult;
            }

            public string partNumber
            {
                get
                {
                    return mpartNumber;
                }
            }

            public string chNumber
            {
                get
                {
                    return mchNumber;
                }
            }

            public string customer
            {
                get
                {
                    return mcustomer;
                }
            }

            public string testType
            {
                get
                {
                    return mtestType;
                }
            }

            public string testID
            {
                get
                {
                    return mtestID;
                }
            }

            public int lowerTestLimit
            {
                get
                {
                    return mlowerTestLimit;
                }
            }

            public int upperTestLimit
            {
                get
                {
                    return mupperTestLimit;
                }
            }

            public bool limitexceeded
            {
                get
                {
                    return mlimitexceeded;
                }
            }

            public string testResult
            {
                get
                {
                    return mtestResult;
                }
            }

        }
    }
}
