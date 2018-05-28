using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class DUTAdapter
    {

        List<DUTSample> samplesOnTest;

        public DUTAdapter()
        {
            samplesOnTest = new List<DUTSample>();
        }

        public void addItem(DUTSample testSample)
        {
            samplesOnTest.Add(testSample);
        }

        public void deleteItem()
        {
            samplesOnTest.Clear();
        }

        public DUTSample getItem(int index)
        {
            return samplesOnTest.ElementAt(index);
        }

    }
}
