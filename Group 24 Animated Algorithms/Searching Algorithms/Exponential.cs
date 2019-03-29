using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Exponential : Algorithm
    {
        public Exponential(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(Logn)", space = "O(1)" };
            Output.UpdateInfo(@"private string ExSearch(ref decimal[] input, int length, decimal target, ref int count)
{
	//look in the first position
	if (input[0] == target)
	{
		return 0.ToString();
	}

	//find the next range for the binary search
	int i = 1;

	while (i < length && input[i] <= target)
	{
		i = i * 2;
	}

	//call binary search function for found range
	return BSearch(ref input, i / 2, Math.Min(i, length), target, ref count);
}");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return ExSearch(ref input, input.Length, target, ref count);
        }

        private string ExSearch(ref decimal[] input, int length, decimal target, ref int count)
        {
            //add counter
            count++;
            Output.UpdateOperations(count);

            Update(3,5);

            //look in the first position
            if (input[0] == target)
            {
                Update(6,7);
                HighlightFound(0);
                return input[0].ToString();
            }
            else
            {
                //highlight
                Highlight(0);
            }

            Update(9,10);

            //find the next range for the binary search
            int i = 1;

            Update(12,13);
            while (i < length && input[i] <= target)
            {
                Update(13,14);
                i = i * 2;
            }

            Update(17,18);
            //call binary search function for found range
            return BSearch(ref input, i / 2, Math.Min(i, length), target, ref count);
        }

        private string BSearch(ref decimal[] input, int start, int end, decimal target, ref int count)
        {
            count++;
            Output.UpdateOperations(count);

            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (target == input[mid]){HighlightFound(mid);string tmp = $"Location: {mid + 1}";return tmp;}
                else{Highlight(mid);}

                if (input[mid] > target) { return BSearch(ref input, start, mid - 1, target, ref count); }
                else { return BSearch(ref input, mid + 1, end, target, ref count); }
            }
            return "Not Found";
        }
    }
}
