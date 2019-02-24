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
        internal class Ascending
        {
            public Ascending(Decimal[] input)
            {
                OutputScreen OutputWin = new OutputScreen(input) { Text = "Output Insertion Sort Ascending" };
                OutputWin.Show();
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
                    OutputWin.SwapBars(index, input[index], index + 1, input[index - 1]);
                    OutputWin.UpdateOperations(its);
                    input[index] = temp;
                    Sorted++;

                }



            }
        }

        internal class Descending
        {
            public Descending(Decimal[] input)
            {

            }
        }

    }
}

