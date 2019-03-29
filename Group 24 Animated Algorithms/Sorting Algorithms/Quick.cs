using Group_24_Animated_Algorithms.Output;
using System;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Quick: Algorithm
    {
        //Algorithm
        public Quick(ref OutputScreen OutputWin)
        {
            this.Output = OutputWin;
            data = new Data() { time = "O(nLogn)", space = "O(n)" };
        }

        public override void Ascending(Decimal[] input)
        {
            //creates counter
            int count = 0;
            Output.UpdateInfo(@"private void SortAscending(decimal[] input, int start, int end, ref int count)
{
	//get current and split arrays in recursion
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
			decimal tmp = array[left];
			array[left] = array[right];
			array[right] = tmp;

			left++;
			right--;
		}
	}
	return left;
}");
            Update(1, 2);
            //call initial sort
            SortAscending(input, 0, input.Length - 1, ref count);
        }
        private void SortAscending(decimal[] input, int start, int end, ref int count)
        {
            Update(3, 4);
            //get current and split arrays in reccursion
            Update(19, 20);
            int current = PartitionAscending(input, start, end, ref count);

            Update(6, 10);
            //left array
            if (start < current - 1)
            {
                Update(1, 2);
                SortAscending(input, start, current - 1, ref count);
            }

            Update(12, 16);
            //right array
            if (end > current)
            {
                Update(1, 2);
                SortAscending(input, current, end, ref count);
            }
        }
        private int PartitionAscending(decimal[] array, int left, int right, ref int count)
        {
            Update(21, 22);
            //add counter
            count++;
            Output.UpdateOperations(count);

            Update(24, 25);
            //get pivot
            decimal pivot = array[left];

            Update(27, 28);
            while (left <= right)
            {
                Update(29, 33);
                //getting numbers less than pivot
                while (array[left] < pivot)
                {
                    left++;
                }
                Update(34, 38);
                //getting numbers greater than pivot
                while (array[right] > pivot)
                {
                    right--;
                }

                Update(40, 42);
                //swap
                if (left <= right)
                {
                    Update(43, 48);
                    SwapBars(left, right);
                    decimal tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;

                    left++;
                    right--;
                }
            }
            Update(50, 51);
            return left;
        }


        public override void Descending(Decimal[] input)
        {
            //creates counter
            int count = 0;
            Output.UpdateInfo(@"private void SortDescending(decimal[] input, int start, int end, ref int count)
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
}");
            Update(1, 2);
            //call initial sort
            SortDescending(input, 0, input.Length - 1, ref count);
        }
        private void SortDescending(decimal[] input, int start, int end, ref int count)
        {
            Update(3, 4);
            //get current and split arrays in reccursion
            Update(19, 20);
            int current = PartitionDescending(input, start, end, ref count);

            Update(6, 10);
            //left array
            if (start < current - 1)
            {
                Update(1, 2);
                SortDescending(input, start, current - 1, ref count);
            }

            Update(12, 16);
            //right array
            if (end > current)
            {
                Update(1, 2);
                SortDescending(input, current, end, ref count);
            }
        }
        private int PartitionDescending(decimal[] array, int left, int right, ref int count)
        {
            Update(21, 22);
            //add counter
            count++;

            Update(24, 25);
            //get pivot
            decimal pivot = array[left];

            Update(27, 28);
            while (left <= right)
            {
                Update(29, 33);
                //getting numbers less than pivot
                while (array[left] > pivot)
                {
                    left++;
                }
                Update(34, 38);
                //getting numbers greater than pivot
                while (array[right] < pivot)
                {
                    right--;
                }

                Update(40, 42);
                //swap
                if (left <= right)
                {
                    Update(43, 48);
                    SwapBars(left, right);
                    decimal tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                    left++;
                    right--;
                }
            }
            Update(50, 51);
            return left;
        }
    }
}
