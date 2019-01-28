using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Bubble
    {
        internal class Ascending
        {
            public Ascending(Decimal[] input, ref OutputScreen OutputWin)
            {
                //creates counter, length and placeholder
                int count = 0;
                decimal tmp;
                int length = input.Length;

                //Outer loop
                for (int j = 0; j < length; j++)
                {
                    //Inner loop
                    for (int i = 0; i < length - 1; i++)
                    {
                        //check to see which is bigger
                        if (input[i] > input[i + 1])
                        {
                            //Add counter
                            count++;

                            //move
                            OutputWin.SwapBars(i, input[i], i+1, input[i+1]);
                            OutputWin.UpdateOperations(count);
                            tmp = input[i + 1];
                            input[i + 1] = input[i];
                            input[i] = tmp;
                        }
                    }
                }
            }
        }


        internal class Descending
        {
            public Descending(Decimal[] input, ref OutputScreen OutputWin)
            {                
                //creates counter, length and placeholder
                int count = 0;
                decimal tmp;
                int length = input.Length;

                //outer loop
                for (int j = 0; j < length; j++)
                {
                    //inner loop
                    for (int i = 0; i < length - 1; i++)
                    {
                        //check to see which is bigger
                        if (input[i] < input[i + 1])
                        {
                            //add counter
                            count++;
                            //move
                            OutputWin.SwapBars(i, input[i], i + 1, input[i + 1]);
                            OutputWin.UpdateOperations(count);
                            tmp = input[i + 1];
                            input[i + 1] = input[i];
                            input[i] = tmp;
                        }

                    }
                }
            }
        }
    }
}
