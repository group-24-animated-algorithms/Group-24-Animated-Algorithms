using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Interpolation
    {
        private OutputScreen Output;

        public Interpolation(ref OutputScreen OutputWin)
        {
            Output = OutputWin;
        }

        private void Update(string info, string code)
        {
            Output.UpdateInfo(info, code);
        }

        public string ISearch(decimal[] input, int min, int max, decimal key)
        {
            //midpoint container
            int mid;
            int count = 0;

            while (min <= max)
            {
                //add counter
                count++;
                Output.UpdateOperations(count);

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

                //highlight
                Output.HighlightBar(mid);

                //if found
                if (key == input[mid])
                {
                    //add location to string
                    string tmp = $"Location: {mid}";
                    //check for duiplicates
                    int countLeft = 0;
                    SearchChecking.LookForDupesLeft(ref input, mid, ref key, ref countLeft);
                    int countRight = 0;
                    SearchChecking.LookForDupesRight(ref input, mid, ref key, ref countRight, ref max);

                    //add duplicate locations
                    for (int i = 1; i <= countLeft; i++)
                    {
                        tmp = $"{tmp}\nLocation: {mid - i}";
                    }
                    for (int i = 1; i <= countRight; i++)
                    {
                        tmp = $"{tmp}\nLocation: {mid + i}";
                    }

                    //return string
                    return tmp;
                }

                //check if it belongs above the array
                else if (SearchChecking.AboveBounds(mid, ref key, ref max))
                {
                    //return location and closest value
                    return $"Location: {mid} Value: {input[mid]}";
                }
                //check if it belongs below the array
                else if (SearchChecking.BelowBounds(mid, ref key))
                {
                    //return location and closest value
                    return $"Location: {mid} Value: {input[mid]}";
                }

                //check if it fits between two items in array
                else if (SearchChecking.ShouldGoHere(input[mid], input[mid + 1], ref key, ref max)) //if it fits here and not here, find closest
                {
                    //return closest value and location
                    return SearchChecking.ClosestValue(ref input, mid, mid + 1, ref key);
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
            return "Item not found";

        }
    }
}
