using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Bubble
    {
        private OutputScreen Output;

        public Bubble(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
        }

        private void Update(string info, string code)
        {
            Output.UpdateInfo(info, code);
            System.Threading.Thread.Sleep(100);
        }

        public void Ascending(Decimal[] input)
        {
            //Thread.CurrentThread.IsBackground = true;

            //creates counter, length and placeholder
            int count = 0;
            decimal tmp;
            int length = input.Length;

            //Outer loop
            for (int j = 0; j < length; j++)
            {
                Update("Increment the outer loop", "for (int j = 0; j < length; j++)");

                //Inner loop
                for (int i = 0; i < length - 1; i++)
                {
                    Update("Increment the inner loop", "for (int i = 0; i < length - 1; i++)");

                    //check to see which is bigger
                    Update("Check to see which value is bigger", "if (input[i] > input[i + 1])");
                    if (input[i] > input[i + 1])
                    {
                        //Add counter
                        Update("Increment Counter", "count++;");
                        count++;

                        //move
                        Output.SwapBars(i, input[i], i + 1, input[i + 1]);
                        Output.UpdateOperations(count);
                        Update("If true, swap the values", @"tmp = input[i + 1];
input[i + 1] = input[i];
input[i] = tmp;");
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }
                }
            }
        }
        public void Descending(Decimal[] input)
        {
            //creates counter, length and placeholder
            int count = 0;
            decimal tmp;
            int length = input.Length;

            //outer loop
            for (int j = 0; j < length; j++)
            {
                Update("Increment the outer loop", "for (int j = 0; j < length; j++)");

                //inner loop
                for (int i = 0; i < length - 1; i++)
                {
                    Update("Increment the inner loop", "for (int i = 0; i < length - 1; i++)");

                    //check to see which is bigger
                    if (input[i] < input[i + 1])
                    {
                        //add counter
                        Update("Increment Counter", "count++;");
                        count++;

                        //move
                        Output.SwapBars(i, input[i], i + 1, input[i + 1]);
                        Output.UpdateOperations(count);
                        Update("If true, swap the values", @"tmp = input[i + 1];
input[i + 1] = input[i];
input[i] = tmp;");
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }

                }
            }
        }
    }
}
