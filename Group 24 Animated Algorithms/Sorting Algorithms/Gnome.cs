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
        public Gnome(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(n^2)", space = "O(1)" };
        }

        public override void Ascending(Decimal[] input)
        {
            int count = 0;
            Output.UpdateInfo(@"public override void Ascending(Decimal[] input)
{
	//hold position
	int index = 0;
	
	//loop through array
	while (index < input.Length)
	{
		//move away from 0
		if (index == 0)
		{
			index++;
		}
		
		//if greater than previous move on
		if (input[index] >= input[index - 1])
		{
			index++;
		}
		
		//else swap
		else
		{
			decimal temp = 0;
			temp = input[index];
			input[index] = input[index - 1];
			input[index - 1] = temp;
			index--;
		}
	}
	return;
}");
            Update(3,4);
            //hold position
            int index = 0;

            Update(6,8);
            //loop through array
            while (index < input.Length)
            {
                count++;
                Output.UpdateOperations(count);

                Update(9,10);
                //move away from 0
                if (index == 0)
                {
                    Update(11,12);
                    index++;
                }

                Update(15,16);
                //if greater than previous move on
                if (input[index] >= input[index - 1])
                {
                    Update(17,18);
                    index++;
                }

                //else swap
                else
                {
                    Update(23,28);
                    decimal temp = 0;
                    temp = input[index];
                    input[index] = input[index - 1];
                    input[index - 1] = temp;
                    SwapBars(index, index - 1);
                    index--;
                }
            }
            Update(31,32);
            return;
        }
        public override void Descending(Decimal[] input)
        {
            int count = 0;
            Output.UpdateInfo(@"public override void Ascending(Decimal[] input)
{
	//hold position
	int index = 0;
	
	//loop through array
	while (index < input.Length)
	{
		//move away from 0
		if (index == 0)
		{
			index++;
		}
		
		//if less than previous move on
		if (input[index] <= input[index - 1])
		{
			index++;
		}
		
		//else swap
		else
		{
			decimal temp = 0;
			temp = input[index];
			input[index] = input[index - 1];
			input[index - 1] = temp;
			index--;
		}
	}
	return;
}");
            Update(3, 4);
            //hold position
            int index = 0;

            Update(6, 8);
            //loop through array
            while (index < input.Length)
            {
                count++;
                Output.UpdateOperations(count);

                Update(9, 10);
                //move away from 0
                if (index == 0)
                {
                    Update(11, 12);
                    index++;
                }

                Update(15, 16);
                //if less than previous move on
                if (input[index] <= input[index - 1])
                {
                    Update(17, 18);
                    index++;
                }

                //else swap
                else
                {
                    Update(23, 28);
                    decimal temp = 0;
                    temp = input[index];
                    input[index] = input[index - 1];
                    input[index - 1] = temp;
                    SwapBars(index, index - 1);
                    index--;
                }
            }
            Update(31, 32);
            return;
        }

    }
}
