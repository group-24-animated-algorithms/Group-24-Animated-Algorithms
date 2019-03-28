using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Linear : Algorithm
    {
        public Linear(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(n)", space = "O(1)" };
            Output.UpdateInfo(@"");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return LSearch(input,  target, ref count);
        }
        private string LSearch(decimal[] input, decimal target, ref int count)
        {
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                Output.UpdateOperations(count);
                Highlight(i);
                if (input[i] == target)
                {
                    return $"Location: {i + 1}";
                }
            }
            return "Not Found";
        }
    }
}
