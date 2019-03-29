using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Linear : Algorithm
    {
        public Linear(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
            data = new Data() { time = "O(n)", space = "O(1)" };
            Output.UpdateInfo(@"private string LSearch(decimal[] input, decimal target, ref int count)
{
//loop through the array
	for (int i = 0; i < input.Length; i++)
	{
		//if target then  return
		if (input[i] == target)
		{
			return $""Location: {i + 1}"";
		}
	}
	//else not in the array
	return ""Not Found"";
}");
        }

        public override string Search(decimal[] input, decimal target)
        {
            int count = 0;
            return LSearch(input,  target, ref count);
        }
        private string LSearch(decimal[] input, decimal target, ref int count)
        {
            Update(3, 5);
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                Output.UpdateOperations(count);
                Update(6,8);
                if (input[i] == target)
                {
                    Update(9,10);
                    HighlightFound(i);
                    return $"Location: {i + 1}";
                }
                else
                {
                    Highlight(i);
                }
                Update(3,5);
            }
            Update(12,14);
            return "Not Found";
        }
    }
}
