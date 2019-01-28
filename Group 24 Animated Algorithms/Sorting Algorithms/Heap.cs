using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Heap
    {
        internal class Ascending
        {
            public Ascending(decimal[] input, ref OutputScreen OutputWin)
            {
                //creates counter
                int count = 0;

                //call initial sort
                Sort(ref input, ref count, ref OutputWin);
            }

            private void Sort(ref decimal[] input, ref int count, ref OutputScreen OutputWin)
            {
                //get size
                int heapSize = input.Length;

                //backwards loop through array
                for (int i = (heapSize - 1) / 2; i >= 0; i--)
                {
                    //heapify
                    Heap(ref input, heapSize, i, ref count, ref OutputWin);
                }

                for (int i = input.Length - 1; i > 0; i--)
                {
                    //swap
                    OutputWin.SwapBars(i, input[i], 0, input[0]);
                    OutputWin.UpdateOperations(count);

                    decimal temp = input[i];
                    input[i] = input[0];
                    input[0] = temp;

                    //reduce size
                    heapSize--;

                    //heapify
                    Heap(ref input, heapSize, 0, ref count, ref OutputWin);
                }
            }

            private void Heap(ref decimal[] input, int size, int current, ref int count, ref OutputScreen OutputWin)
            {
                //get variables
                int left = (current + 1) * 2 - 1;
                int right = (current + 1) * 2;
                int max = 0;

                //add counter
                count++;

                //compare
                if (left < size && input[left] > input[current])
                {
                    max = left;
                }
                else
                {
                    max = current;
                }

                if (right < size && input[right] > input[max])
                {
                    max = right;
                }

                if (max != current)
                {
                    //swap
                    OutputWin.SwapBars(current, input[current], max, input[max]);
                    OutputWin.UpdateOperations(count);

                    decimal temp = input[current];
                    input[current] = input[max];
                    input[max] = temp;

                    //heapify
                    Heap(ref input, size, max, ref count, ref OutputWin);
                }
            }
        }
        internal class Descending
        {
            public Descending(decimal[] input, ref OutputScreen OutputWin)
            {
                //creates counter
                int count = 0;

                //call initial sort
                Sort(ref input, ref count, ref OutputWin);
            }

            private void Sort(ref decimal[] input, ref int count, ref OutputScreen OutputWin)
            {
                //get size
                int heapSize = input.Length;

                //backwards loop through array
                for (int i = (heapSize - 1) / 2; i >= 0; i--)
                {
                    //heapify
                    Heap(ref input, heapSize, i, ref count, ref OutputWin);
                }

                for (int i = input.Length - 1; i > 0; i--)
                {
                    //swap
                    OutputWin.SwapBars(i, input[i], 0, input[0]);
                    OutputWin.UpdateOperations(count);

                    decimal temp = input[i];
                    input[i] = input[0];
                    input[0] = temp;

                    //reduce size
                    heapSize--;

                    //heapify
                    Heap(ref input, heapSize, 0, ref count, ref OutputWin);
                }
            }

            private void Heap(ref decimal[] input, int size, int current, ref int count, ref OutputScreen OutputWin)
            {
                //get variables
                int left = (current + 1) * 2 - 1;
                int right = (current + 1) * 2;
                int max = 0;

                //add counter
                count++;

                //compare
                if (left < size && input[left] < input[current])
                {
                    max = left;
                }
                else
                {
                    max = current;
                }

                if (right < size && input[right] < input[max])
                {
                    max = right;
                }

                if (max != current)
                {
                    //swap
                    OutputWin.SwapBars(current, input[current], max, input[max]);
                    OutputWin.UpdateOperations(count);

                    decimal temp = input[current];
                    input[current] = input[max];
                    input[max] = temp;

                    //heapify
                    Heap(ref input, size, max, ref count, ref OutputWin);
                }
            }
        }
    }
}
