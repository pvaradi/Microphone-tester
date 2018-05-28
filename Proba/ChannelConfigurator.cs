using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class ChannelConfigurator
    {
        public DUTAdapter dutAdapter;
        DUTSample[] dutSample = new DUTSample[21];

        public delegate void ChannelUpdateHandler(object sender, ChannelUpdateEventArgs e);
        public event ChannelUpdateHandler ChannelUpdated;

        public ChannelConfigurator()
        {
            dutAdapter = new DUTAdapter();
        }

        public void ConfigureChannel(int i)
        {
            string channel = i.ToString();
            Form2 chConfigurationForm = new Form2(channel);
            chConfigurationForm.ConfigUpdated += new Form2.ConfigUpdateHandler(Config1Save_ButtonClicked);
            chConfigurationForm.Show();
        }

        private void Config1Save_ButtonClicked(object sender, Form2.ConfigUpdateEventArgs e)
        {
            ChannelUpdateEventArgs args = new ChannelUpdateEventArgs(e.chNumber, e.partNumber, e.testType, e.testID, e.lowerTestLimit, e.upperTestLimit, e.limitexceeded, e.testResult);
            ChannelUpdated(this, args);

            int chNumber = Int32.Parse(e.chNumber);

            dutSample[chNumber] = new DUTSample(e.chNumber, e.partNumber, e.customer, e.testType, e.testID, e.lowerTestLimit, e.upperTestLimit, e.limitexceeded, e.testResult);
            dutAdapter.addItem(dutSample[chNumber]); // add to index 0..1..2
            
        }

        public DUTSample getItem(int index)
        {
            return dutAdapter.getItem(index);
        }

        public void RemoveItems()
        {
            dutAdapter.deleteItem();
        }

        public class ChannelUpdateEventArgs : System.EventArgs
        {
            private string mchNumber;
            private string mpartNumber;
            private string mtestType;
            private string mtestID;
            private int mlowerTestLimit;
            private int mupperTestLimit;
            private bool mlimitexceeded;
            private string mtestResult;


            public ChannelUpdateEventArgs(string schNumber, string spartNumber, string stestType, string stestID, int slowerTestLimit, int supperTestLimit, bool slimitexceeded, string stestResult)
            {
                this.mchNumber = schNumber;
                this.mpartNumber = spartNumber;
                this.mtestType = stestType;
                this.mtestID = stestID;
                this.mlowerTestLimit = slowerTestLimit;
                this.mupperTestLimit = supperTestLimit;
                this.mlimitexceeded = slimitexceeded;
                this.mtestResult = stestResult;

            }

            public string chNumber
            {
                get
                {
                    return mchNumber;
                }
            }

            public string partNumber
            {
                get
                {
                    return mpartNumber;
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
