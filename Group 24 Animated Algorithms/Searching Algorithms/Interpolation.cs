using Group_24_Animated_Algorithms.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Interpolation : Algorithm
    {
        //Algorithm
        public Interpolation(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(LogLogn)", space = "O(1)" };
            Output.UpdateInfo(@"public string ISearch(decimal[] input, int min, int max, decimal key)
{
	//midpoint container
	int mid;
	int count = 0;

	while (min <= max)
	{
		//get midpoint
		mid = (int)(min + (max - min) * ((key - input[min]) / (input[max] - input[min])));

		//keep it in bounds of array
		if (mid < 0)
		{
			mid = 0;
		}

		else if (mid > max)
		{
			mid = max;
		}

		//if found
		if (key == input[mid])
		{
			//return string
			return $"" Location: {mid + 1}"";
		}

		//where to look next
		else if (key < input[mid])
		{
			max = mid - 1;
		}
		else
		{
			min = mid + 1;
		}
	}
	//return error
	return ""Item not found"";

}");
        }

        public override string Search(decimal[] input, decimal target)
        {
            return ISearch(input, 0, input.Count() - 1, target);
        }

        public string ISearch(decimal[] input, int min, int max, decimal key)
        {
            Update(3, 5); //Line number
            //midpoint container
            int mid;
            int count = 0;

            if (input[min] > key || input[max] < key)
            {
                return "Item not found";
            }

            Update(7, 8);
            while (min <= max)
            {
                //add counter
                count++;
                Output.UpdateOperations(count);

                Update(9, 10);
                //get midpoint
                mid = (int)(min + (max - min) * ((key - input[min]) / (input[max] - input[min])));

                Update(12, 13);
                //keep it in bounds of array
                if (mid < 0)
                {
                    Update(14, 15);
                    mid = 0;
                }
                else if (mid > max)
                {
                    Update(19, 20);
                    mid = max;
                }

                Update(23, 24);
                //if found
                if (key == input[mid])
                {
                    Update(26, 27);

                    //highlight
                    HighlightFound(mid);

                    //return string
                    return $" Location: {mid + 1}";
                }

                //where to look next
                else if (key < input[mid])
                {
                    Update(32, 33);
                    max = mid - 1;
                }
                else
                {
                    Update(36, 37);
                    min = mid + 1;
                    Highlight(mid);
                }
            }

            Update(40, 43);
            //return error
            return "Item not found";

        }


    }
}
