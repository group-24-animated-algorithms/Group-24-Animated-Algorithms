using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Binary : Algorithm
    {
        public Binary(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return BSearch(input, 0, input.Length-1, target, input.Length, ref count);
        }

        private string BSearch(decimal[] input, int start, int stop, decimal key, int length, ref int count)
        {
            var me = this as Algorithm;

            //add counter
            count++;
            Output.UpdateOperations(count);

            //ran out of array
            if (start > stop)
            {
                return null;
            }

            //get midpoint
            int mid = (start + stop) / 2;

            //highlight
            Highlight(mid);

            //if found
            if (key == input[mid])
            {
                //add location to string
                string tmp = $"Location: {mid +1}";
                
                //return string
                return tmp;
            }
            
            //where to look next
            else if (key < input[mid])
            {
                return BSearch(input, start, mid - 1, key, length, ref count);
            }

            else
            {
                return BSearch(input, mid + 1, stop, key, length, ref count);
            }
        }
    }
}
