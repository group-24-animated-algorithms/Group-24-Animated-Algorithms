using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_24_Animated_Algorithms.Sorting_Algorithms
{
    class Bubble
    {
        private OutputScreen Output;

        public Bubble(ref OutputScreen OutputWin)
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
                        Output.SwapBars(i, input[i], i + 1, input[i + 1]);
                        Output.UpdateOperations(count);
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }
                }
            }
        }
        public void Descending(Decimal[] input)
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
                        Output.SwapBars(i, input[i], i + 1, input[i + 1]);
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
