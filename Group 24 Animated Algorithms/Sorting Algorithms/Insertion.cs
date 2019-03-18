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

        private void Update(int lineNo, int lineLength)
        {
            Output.UpdateBox(lineNo, lineLength);
            System.Threading.Thread.Sleep(1000);
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
                    Output.UpdateOperations(its);
                    if (temp < input[index - 1])
                    {
                        input[index] = input[index - 1];
                        Output.SwapBars(index, index - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                input[index] = temp;
                Sorted++;

            }



        }

        public void Descending(Decimal[] input)
        {

        }

    }
}

