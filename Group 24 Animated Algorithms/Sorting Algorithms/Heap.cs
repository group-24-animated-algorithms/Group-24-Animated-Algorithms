using Group_24_Animated_Algorithms.Output;
using System;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Heap : Algorithm
    {
        //Algorithm
        public Heap(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(nLogn)", space = "O(1)" };
        }

        public override void Ascending(decimal[] input)
        {
            //creates counter
            int count = 0;

            //call initial sort
            AscendingSort(ref input, ref count);
        }
        private void AscendingSort(ref decimal[] input, ref int count)
        {
            //get size
            int heapSize = input.Length;

            //backwards loop through array
            for (int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                //heapify
                AscendingHeap(ref input, heapSize, i, ref count);
            }

            for (int i = input.Length - 1; i > 0; i--)
            {
                //swap
                SwapBars(i, 0);
                Output.UpdateOperations(count);

                decimal temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                //reduce size
                heapSize--;

                //heapify
                AscendingHeap(ref input, heapSize, 0, ref count);
            }
        }
        private void AscendingHeap(ref decimal[] input, int size, int current, ref int count)
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
                SwapBars(current, max);
                Output.UpdateOperations(count);
                decimal temp = input[current];
                input[current] = input[max];
                input[max] = temp;

                //heapify
                AscendingHeap(ref input, size, max, ref count);
            }
        }

        public override void Descending(decimal[] input)
        {
            //creates counter
            int count = 0;

            //call initial sort
            DescendingSort(ref input, ref count);
        }
        private void DescendingSort(ref decimal[] input, ref int count)
        {
            //get size
            int heapSize = input.Length;

            //backwards loop through array
            for (int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                //heapify
                DescendingHeap(ref input, heapSize, i, ref count);
            }

            for (int i = input.Length - 1; i > 0; i--)
            {
                //swap
                SwapBars(i, 0);
                Output.UpdateOperations(count);

                decimal temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                //reduce size
                heapSize--;

                //heapify
                DescendingHeap(ref input, heapSize, 0, ref count);
            }
        }
        private void DescendingHeap(ref decimal[] input, int size, int current, ref int count)
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
                SwapBars(current, max);
                Output.UpdateOperations(count);

                decimal temp = input[current];
                input[current] = input[max];
                input[max] = temp;

                //heapify
                DescendingHeap(ref input, size, max, ref count);
            }
        }
    }
}
