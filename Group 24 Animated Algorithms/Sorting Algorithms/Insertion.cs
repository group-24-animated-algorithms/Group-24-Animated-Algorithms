using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Insertion
    {
        private OutputScreen Output;

        public Insertion(ref OutputScreen OutputWin)
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
            int its = 0;
            int Sorted = 1;
            int index;
            while (Sorted < input.Length)
            {
                its++;

                decimal temp = input[Sorted];

                for (index = Sorted; index > 0; index--)
                {
                    its++;
                    if (temp < input[index - 1])
                    {
                        input[index] = input[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                Output.SwapBars(index, input[index], index + 1, input[index - 1]);
                Output.UpdateOperations(its);
                input[index] = temp;
                Sorted++;

            }



        }

        public void Descending(Decimal[] input)
        {

        }

    }
}

