using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Exponential : Algorithm
    {
        public Exponential(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return ExSearch(ref input, input.Length, target, ref count);
        }

        private string ExSearch(ref decimal[] input, int length, decimal target, ref int count)
        {
            //add counter
            count++;
            Output.UpdateOperations(count);

            //highlight
            Highlight(0);

            // If x is present at  
            // first location itself 
            if (input[0] == target)
            {
                return 0.ToString();
            }

            // Find range for binary search  
            // by repeated doubling 
            int i = 1;

            while (i < length && input[i] <= target)
            {
                i = i * 2;
            }

            // Call binary search for 
            // the found range. 
            return BSearch(ref input, i / 2, Math.Min(i, length), target, ref count);
        }

        private string BSearch(ref decimal[] input, int start, int end, decimal target, ref int count)
        {
            //add counter
            count++;
            Output.UpdateOperations(count);

            if (end >= start)
            {
                //get midpoint
                int mid = start + (end - start) / 2;

                //highlight
                Highlight(mid);

                //if found
                if (target == input[mid])
                {
                    //add location to string
                    string tmp = $"Location: {mid + 1}";

                    //return string
                    return tmp;
                }

                // If element is smaller than 
                // mid, then it can only be  
                // present n left subarray 
                if (input[mid] > target)
                    return BSearch(ref input, start, mid - 1, target, ref count);

                // Else the element can only  
                // be present in right subarray 
                return BSearch(ref input, mid + 1, end, target, ref count);
            }

            // We reach here when element 
            // is not present in array 
            return "Not Found";
        }
    }
}
