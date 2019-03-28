using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Fibonacci : Algorithm
    {
        public Fibonacci(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return FSearch(input, target, input.Length, ref count);
        }

        private string FSearch(decimal[] input, decimal target, int length, ref int count)
        {
            /* Initialize fibonacci numbers */
            int fib2 = 0; // (n-2)'th Fibonacci No. 
            int fib1 = 1; // (n-1)'th Fibonacci No. 
            int fib = fib2 + fib1; // n'th Fibonacci 

            /* fibM is going to store the smallest  
            Fibonacci Number greater than or equal to n */
            while (fib < length)
            {
                fib2 = fib1;
                fib1 = fib;
                fib = fib2 + fib1;
            }

            // Marks the eliminated range from front 
            int offset = -1;

            /* while there are elements to be inspected.  
            Note that we compare arr[fibMm2] with x.  
            When fibM becomes 1, fibMm2 becomes 0 */
            while (fib > 1)
            {
                // Check if fibMm2 is a valid location 
                int i = Math.Min(offset + fib2, length - 1);

                Highlight(i);
                count++;
                Output.UpdateOperations(count);

                /* If x is greater than the value at  
                index fibMm2, cut the subarray array  
                from offset to i */
                if (input[i] < target)
                {
                    fib = fib1;
                    fib1 = fib2;
                    fib2 = fib - fib1;
                    offset = i;
                }

                /* If x is greater than the value at index  
                fibMm2, cut the subarray after i+1 */
                else if (input[i] > target)
                {
                    fib = fib2;
                    fib1 = fib1 - fib2;
                    fib2 = fib - fib1;
                }

                /* element found. return index */
                else return $"Location: {i+1}";
            }

            /* comparing the last element with x */
            if (fib1 == 1 && input[offset + 1] == target)
                return $"Location: {offset + 2}";

            /*element not found. return -1 */
            return "Not Found";
        }
    }
}
