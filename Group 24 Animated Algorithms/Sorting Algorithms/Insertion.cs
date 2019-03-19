using Group_24_Animated_Algorithms.Output;
using System;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Insertion : Algorithm
    {
        //Algorithm
        public Insertion(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(n^2)", space = "O(1)" };
        }

        public override void Ascending(Decimal[] input)
        {
            Output.UpdateInfo(@"int its = 0;
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
	input[index] = temp;
	Sorted++;
}");
            Update(1, 3);
            int its = 0;
            int Sorted = 1;
            int index;
            Update(4, 5);
            while (Sorted < input.Length)
            {
                Update(6, 7);
                its++;
                decimal temp = input[Sorted];

                Update(9, 10);
                for (index = Sorted; index > 0; index--)
                {
                    Update(11, 12);
                    its++;
                    Output.UpdateOperations(its);

                    Update(13, 14);
                    if (temp < input[index - 1])
                    {
                        Update(15, 16);
                        input[index] = input[index - 1];
                        Output.SwapBars(index, index - 1);
                    }
                    else
                    {
                        Update(18, 19);
                        break;
                    }
                }
                Update(22, 23);
                input[index] = temp;
                Sorted++;
            }
        }

        public override void Descending(Decimal[] input)
        {
            Output.UpdateInfo(@"int its = 0;
int Sorted = 1;
int index;
while (Sorted < input.Length)
{
	its++;
	decimal temp = input[Sorted];

	for (index = Sorted; index > 0; index--)
	{
		its++;

		if (temp > input[index - 1])
		{
			input[index] = input[index - 1];
		}
		else
		{
			break;
		}
	}
	input[index] = temp;
	Sorted++;
}");
            Update(1, 3);
            int its = 0;
            int Sorted = 1;
            int index;
            Update(4, 5);
            while (Sorted < input.Length)
            {
                Update(6, 7);
                its++;
                decimal temp = input[Sorted];

                Update(9, 10);
                for (index = Sorted; index > 0; index--)
                {
                    Update(11, 12);
                    its++;
                    Output.UpdateOperations(its);

                    Update(13, 14);
                    if (temp > input[index - 1])
                    {
                        Update(15, 16);
                        input[index] = input[index - 1];
                        Output.SwapBars(index, index - 1);
                    }
                    else
                    {
                        Update(18, 19);
                        break;
                    }
                }
                Update(22, 23);
                input[index] = temp;
                Sorted++;
            }
        }
    }
}

