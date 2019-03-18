using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Merge
    {
        private OutputScreen Output;

        public Merge(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
        }

        private void Update(int lineNo, int lineLength)
        {
            Output.UpdateBox(lineNo, lineLength);
            System.Threading.Thread.Sleep(1000);
        }

        public void Ascending(Decimal[] input)
        {

        }
        public void Descending(Decimal[] input)
        {

        }
    }
}
