using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Quick
    {
        private OutputScreen Output;

        public Quick(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
        }

        private void Update(string info, string code)
        {
            Output.UpdateInfo(info, code);
        }

        public void Ascending(Decimal[] input)
        {

        }

        public void Descending(Decimal[] input)
        {

        }
    }
}
