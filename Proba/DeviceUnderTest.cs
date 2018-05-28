using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class DUTSample
    {
        private string partNumber;
        private string chNumber;
        private string customer;
        private string testType;
        private string testID;
        private int lowerTestLimit;
        private int upperTestLimit;
        private bool limitexceeded;
        private string testResult;

        public DUTSample(string chNumber, string partNumber, string customer, string testType, string testID, int lowerTestLimit, int upperTestLimit, bool limitexceeded, string testResult)
        {
            this.partNumber = partNumber;
            this.chNumber = chNumber;
            this.customer = customer;
            this.testType = testType;
            this.testID = testID;
            this.lowerTestLimit = lowerTestLimit;
            this.upperTestLimit = upperTestLimit;
            this.limitexceeded = limitexceeded;
            this.testResult = testResult;
        }

        public string PartNumber   
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
            }
        }

        public string ChNumber  
        {
            get
            {
                return chNumber;
            }
            set
            {
                chNumber = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }

        public string TestType
        {
            get
            {
                return testType;
            }
            set
            {
                testType = value;
            }
        }

        public string TestID
        {
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        public int LowerTestLimit
        {
            get
            {
                return lowerTestLimit;
            }
            set
            {
                lowerTestLimit = value;
            }
        }

        public int UpperTestLimit
        {
            get
            {
                return upperTestLimit;
            }
            set
            {
                upperTestLimit = value;
            }
        }

        public bool Limitexceeded
        {
            get
            {
                return limitexceeded;
            }
            set
            {
                limitexceeded = value;
            }
        }

        public string TestResult
        {
            get
            {
                return testResult;
            }
            set
            {
                testResult = value;
            }
        }

    }
}
