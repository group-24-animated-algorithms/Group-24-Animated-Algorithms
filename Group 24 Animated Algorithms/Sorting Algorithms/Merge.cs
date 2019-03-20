using Group_24_Animated_Algorithms.Output;
using System;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Merge : Algorithm
    {
        //Algorithm
        public Merge(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(nLogn)", space = "O(n)" };
        }

        public override void Ascending(Decimal[] input)
        {
            Output.UpdateInfo(@"private void AscendingSort(ref decimal[] input, int start, int end, ref int count)
{
	//check for overlap
	if (start < end)
	{
		//add counter
		count++;

		//get mid
		int m = start + (end - start) / 2;

		//split array in recursion
		AscendingSort(ref input, start, m, ref count);
		AscendingSort(ref input, m + 1, end, ref count);

		//merge back
		AscendingMerge(ref input, start, m, end, ref count);
	}
}

private void AscendingMerge(ref decimal[] input, int start, int mid, int end, ref int count)
{
	//place holder variable for navigating array and ranges
	int i, j, k;
	int range1 = mid - start + 1;
	int range2 = end - mid;

	//declare containers
	decimal[] leftVal = new decimal[range1];
	decimal[] rightVal = new decimal[range2];

	//Add values to containers
	for (i = 0; i < range1; i++)
	{
		leftVal[i] = input[start + i];
	}

	for (j = 0; j < range2; j++)
	{
		rightVal[j] = input[mid + 1 + j];
	}

	//reset variables
	i = 0;
	j = 0;
	k = start;

	//sort
	while (i < range1 && j < range2)
	{
		//check for higher value
		if (leftVal[i] <= rightVal[j])
		{
			input[k] = leftVal[i];
			i++;
		}
		else
		{
			input[k] = rightVal[j];
			j++;
		}

		k++;
	}

	while (i < range1)
	{
		//move
		input[k] = leftVal[i];
		i++;
		k++;
	}

	while (j < range2)
	{
		//move
		input[k] = rightVal[j];
		j++;
		k++;
	}
}");
            //creates counter
            int count = 0;

            //call initial sort
            AscendingSort(ref input, 0, input.Length - 1, ref count);
            Update(1, 2);
        }
        private void AscendingSort(ref decimal[] input, int start, int end, ref int count)
        {
            Update(3, 5);
            //check for overlap
            if (start < end)
            {
                Update(6, 7);
                //add counter
                count++;
                Output.UpdateOperations(count);

                Update(9, 10);
                //get mid
                int m = start + (end - start) / 2;

                Update(12, 13);
                //split array in reccursion
                AscendingSort(ref input, start, m, ref count);

                Update(14, 15);
                AscendingSort(ref input, m + 1, end, ref count);

                Update(16, 17);
                Update(21, 22);
                //merge back
                AscendingMerge(ref input, start, m, end, ref count);
            }
        }
        private void AscendingMerge(ref decimal[] input, int start, int mid, int end, ref int count)
        {
            Update(23, 26);
            //place holder variable for navigating array and ranges
            int i, j, k;
            int range1 = mid - start + 1;
            int range2 = end - mid;

            Update(28, 30);
            //declare containers
            decimal[] leftVal = new decimal[range1];
            decimal[] rightVal = new decimal[range2];

            Update(32, 36);
            //Add values to containers
            for (i = 0; i < range1; i++)
            {
                leftVal[i] = input[start + i];
            }

            Update(38, 41);
            for (j = 0; j < range2; j++)
            {
                rightVal[j] = input[mid + 1 + j];
            }

            Update(43, 46);
            //reset variables
            i = 0;
            j = 0;
            k = start;

            Update(48, 50);
            //sort
            while (i < range1 && j < range2)
            {
                Update(51, 53);
                //check for higher value
                if (leftVal[i] <= rightVal[j])
                {
                    Update(54, 55);
                    SwapBars(k, i);
                    input[k] = leftVal[i];
                    i++;
                }
                else
                {
                    Update(59, 60);
                    SwapBars(k, mid + i - 1);
                    input[k] = rightVal[j];
                    j++;
                }

                Update(63, 64);
                k++;
            }

            Update(66, 67);
            while (i < range1)
            {
                Update(68, 71);
                //move
                SwapBars(k, i);
                input[k] = leftVal[i];
                i++;
                k++;
            }

            Update(74, 75);
            while (j < range2)
            {
                Update(76, 79);
                //move
                SwapBars(k, mid + i - 1);
                input[k] = rightVal[j];
                j++;
                k++;
            }
        }

        public override void Descending(Decimal[] input)
        {

        }
    }
}
