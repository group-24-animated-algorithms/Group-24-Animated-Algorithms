using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Gnome : Algorithm
    {
        //Algorithm
        public Gnome(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(n^2)", space = "O(1)" };
        }

        public override void Ascending(Decimal[] input)
        {
            int index = 0;
            while (index < input.Length)
            {
                if (index == 0)
                    index++;
                if (input[index] >= input[index - 1])
                    index++;
                else
                {
                    decimal temp = 0;
                    temp = input[index];
                    input[index] = input[index - 1];
                    input[index - 1] = temp;
                    SwapBars(index, index - 1);
                    index--;
                }
            }
            return;
        }
        public override void Descending(Decimal[] input)
        {
            int index = 0;
            while (index < input.Length)
            {
                if (index == 0)
                    index++;
                if (input[index] <= input[index - 1])
                    index++;
                else
                {
                    decimal temp = 0;
                    temp = input[index];
                    input[index] = input[index - 1];
                    input[index - 1] = temp;
                    SwapBars(index, index - 1);
                    index--;
                }
            }
            return;
        }

    }
}
