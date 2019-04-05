using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Binary : Algorithm
    {
        public Binary(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"private string BSearch(decimal[] input, int start, int stop, decimal key, int length, ref int count)
{
	//ran out of array
	if (start > stop)
	{
		return null;
	}

	//get midpoint
	int mid = (start + stop) / 2;

	//if found
	if (key == input[mid])
	{
		//add location to string
		return $""Location: {mid + 1}"";
	}
	
	//where to look next
	else if (key < input[mid])
	{
		return BSearch(input, start, mid - 1, key, length, ref count);
	}

	else
	{
		return BSearch(input, mid + 1, stop, key, length, ref count);
	}
}");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return BSearch(input, 0, input.Length - 1, target, input.Length, ref count);
        }

        private string BSearch(decimal[] input, int start, int stop, decimal key, int length, ref int count)
        {


            Update(3, 5);
            //add counter
            count++;
            Output.UpdateOperations(count);

            if (!input.Contains(key))
            {
                return "Item not found";
            }

            //ran out of array
            if (start > stop)
            {
                Update(6, 7);
                return null;
            }

            Update(9, 10);
            //get midpoint
            int mid = (start + stop) / 2;

            Update(12, 14);
            //if found
            if (key == input[mid])
            {
                Update(15, 16);
                HighlightFound(mid);

                //add location to string
                return $"Location: {mid + 1}";
            }

            //where to look next
            else if (key < input[mid])
            {
                Update(21, 22);
                Update(1, 2);
                return BSearch(input, start, mid - 1, key, length, ref count);
            }

            else
            {
                Update(26, 27);
                Update(1, 2);
                return BSearch(input, mid + 1, stop, key, length, ref count);
            }
        }
    }
}
