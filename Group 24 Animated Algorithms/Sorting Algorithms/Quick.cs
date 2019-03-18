using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Quick
    {
        private OutputScreen Output;

        public Quick(ref OutputScreen OutputWin)
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
            //creates counter
            int count = 0;

            //call initial sort
            SortAscending(input, 0, input.Length - 1, ref count);
        }

        private void SortAscending(decimal[] input, int start, int end, ref int count)
        {
            //get current and split arrays in reccursion
            int current = PartitionAscending(input, start, end, ref count);

            //left array
            if (start < current - 1)
            {
                SortAscending(input, start, current - 1, ref count);
            }

            //right array
            if (end > current)
            {
                SortAscending(input, current, end, ref count);
            }
        }

        private int PartitionAscending(decimal[] array, int left, int right, ref int count)
        {
            //add counter
            count++;

            //get pivot
            decimal pivot = array[left];

            while (left <= right)
            {
                //getting numbers less than pivot
                while (array[left] < pivot)
                {
                    left++;
                }
                //getting numbers greater than pivot
                while (array[right] > pivot)
                {
                    right--;
                }

                //swap
                if (left <= right)
                {
                    Output.SwapBars(left, array[left], right, array[right]);
                    ////Update("swap", "code here");
                    decimal tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;

                    left++;
                    right--;
                }
            }
            return left;
        }

        public void Descending(Decimal[] input)
        {
            //creates counter
            int count = 0;

            //call initial sort
            SortDescending(input, 0, input.Length - 1, ref count);
        }

        private void SortDescending(decimal[] input, int start, int end, ref int count)
        {
            //get current and split arrays in reccursion
            int current = PartitionDescending(input, start, end, ref count);

            //left array
            if (start < current - 1)
            {
                SortDescending(input, start, current - 1, ref count);
            }

            //right array
            if (end > current)
            {
                SortDescending(input, current, end, ref count);
            }
        }

        private int PartitionDescending(decimal[] array, int left, int right, ref int count)
        {
            //add counter
            count++;

            //get pivot
            decimal pivot = array[left];

            while (left <= right)
            {
                //getting numbers less than pivot
                while (array[left] > pivot)
                {
                    left++;
                }
                //getting numbers greater than pivot
                while (array[right] < pivot)
                {
                    right--;
                }

                //swap
                if (left <= right)
                {
                    decimal tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;

                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
