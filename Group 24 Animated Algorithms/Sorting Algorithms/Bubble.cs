using Group_24_Animated_Algorithms.Output;
using System;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Bubble : Algorithm
    {        
        //Algorithm
        public Bubble(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(n^2)", space = "O(1)" };
        }

        public override void Ascending(Decimal[] input)
        {
            Output.UpdateInfo(@"//creates counter, length and placeholder
int count = 0;
decimal tmp;
int length = input.Length;

//Outer loop
for (int j = 0; j < length; j++)
{

	//Inner loop
	for (int i = 0; i < length - 1; i++)
	{

		//check to see which is bigger
		if (input[i] > input[i + 1])
		{
			//Add counter
			count++;

			//move
			tmp = input[i + 1];
			input[i + 1] = input[i];
			input[i] = tmp;
		}
	}
}");
            Update(1, 3);
            //creates counter, length and placeholder
            int count = 0;
            decimal tmp;
            int length = input.Length;

            Update(6, 8);
            //Outer loop
            for (int j = 0; j < length; j++)
            {

                Update(10, 12);
                //Inner loop
                for (int i = 0; i < length - 1; i++)
                {

                    Update(14, 16);
                    //check to see which is bigger
                    if (input[i] > input[i + 1])
                    {
                        Update(17, 18);
                        //Add counter
                        count++;

                        Update(20, 23);
                        //move
                        SwapBars(i, i + 1);
                        Output.UpdateOperations(count);
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }
                }
            }
        }

        public override void Descending(Decimal[] input)
        {
            Output.UpdateInfo(@"//creates counter, length and placeholder
int count = 0;
decimal tmp;
int length = input.Length;

//Outer loop
for (int j = 0; j < length; j++)
{

	//Inner loop
	for (int i = 0; i < length - 1; i++)
	{

		//check to see which is bigger
		if (input[i] < input[i + 1])
		{
			//Add counter
			count++;

			//move
			tmp = input[i + 1];
			input[i + 1] = input[i];
			input[i] = tmp;
		}
	}
}");
            Update(1, 3);
            //creates counter, length and placeholder
            int count = 0;
            decimal tmp;
            int length = input.Length;

            Update(6, 8);
            //outer loop
            for (int j = 0; j < length; j++)
            {

                Update(10, 12);
                //inner loop
                for (int i = 0; i < length - 1; i++)
                {
                    Update(14, 16);
                    //check to see which is bigger
                    if (input[i] < input[i + 1])
                    {
                        Update(17, 18);
                        //add counter
                        count++;

                        Update(20, 23);
                        //move
                        SwapBars(i, i + 1);
                        Output.UpdateOperations(count);
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }
                }
            }
        }
    }
}
