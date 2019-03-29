using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Fibonacci : Algorithm
    {
        public Fibonacci(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"private string FSearch(decimal[] input, decimal target, int length, ref int count)
{
	//get the fib numbers
	int fib2 = 0;
	int fib1 = 1;
	int fib = fib2 + fib1;

	//get the smallest fib1/2 >= fib
	while (fib < length)
	{
		fib2 = fib1;
		fib1 = fib;
		fib = fib2 + fib1;
	}
	
	int offset = -1;

	while (fib > 1)
	{
		//check if fib2 is valid 
		int i = Math.Min(offset + fib2, length - 1);

		//if target is greater, split array before offset
		if (input[i] < target)
		{
			fib = fib1;
			fib1 = fib2;
			fib2 = fib - fib1;
			offset = i;
		}

		//if target is greater, split array after offset
		else if (input[i] > target)
		{
			fib = fib2;
			fib1 = fib1 - fib2;
			fib2 = fib - fib1;
		}

		//found
		else
		{
			return $""Location: {i + 1}"";
		}
	}

	//if final element
	if (fib1 == 1 && input[offset + 1] == target)
	{
		return $""Location: {offset + 2}"";
	}

	//doesnt exist
	return ""Not Found"";
}");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return FSearch(input, target, input.Length, ref count);
        }

        private string FSearch(decimal[] input, decimal target, int length, ref int count)
        {
            Update(3,6);
            //get the smallest fib1/2 >= fib
            int fib2 = 0;
            int fib1 = 1;
            int fib = fib2 + fib1;

            Update(8,10);
            //get the smallest fib1/2 >= fib
            while (fib < length)
            {
                Update(10,13);
                fib2 = fib1;
                fib1 = fib;
                fib = fib2 + fib1;
            }

            Update(16,17);
            int offset = -1;

            Update(18,19);
            while (fib > 1)
            {
                Update(20,21);
                //check if fib2 is valid 
                int i = Math.Min(offset + fib2, length - 1);

                Update(23,25);
                count++;
                Output.UpdateOperations(count);
                
		        //if target is greater, split array before offset
                if (input[i] < target)
                {
                    Update(26,29);
                    Highlight(i);
                    fib = fib1;
                    fib1 = fib2;
                    fib2 = fib - fib1;
                    offset = i;
                }

                //if target is greater, split array after offset
                else if (input[i] > target)
                {
                    Update(35,37);
                    Highlight(i);
                    fib = fib2;
                    fib1 = fib1 - fib2;
                    fib2 = fib - fib1;
                }

                //found
                else
                {
                    Update(43,44);
                    HighlightFound(i);
                    return $"Location: {i + 1}";
                }
            }

            Update(47, 49);
            //if final element
            if (fib1 == 1 && input[offset + 1] == target)
            {
                Update(50,51);
                HighlightFound(offset + 1);
                return $"Location: {offset + 2}";
            }

            Update(53,54);
            //doesnt exist
            return "Not Found";
        }
    }
}
