using Group_24_Animated_Algorithms.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class Interpolation: Algorithm
    {
        //Algorithm
        public Interpolation(ref OutputScreen OutputWin, int time)
        {
            Output = OutputWin;
            this.time = time;
            data = new Data() { time = "O(LogLogn)", space = "O(1)" };
            Output.UpdateInfo(@"//midpoint container
int mid;
int count = 0;

while (min <= max)
{
    //add counter
    count++;

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
        //add location to string
        string tmp = $""Location: {mid}"";

        //check for duiplicates
        int countLeft = 0;
        SearchChecking.LookForDupesLeft(ref input, mid, ref key, ref countLeft);
        int countRight = 0;
        SearchChecking.LookForDupesRight(ref input, mid, ref key, ref countRight, ref max);

        //add duplicate locations
        for (int i = 1; i <= countLeft; i++)
        {
            tmp = $""{tmp}\nLocation: {mid - i}"";
        }

        for (int i = 1; i <= countRight; i++)
        {
            tmp = $""{tmp}\nLocation: {mid + i}"";
        }

        //return string
        return tmp;
    }

    //check if it belongs above the array
    else if (SearchChecking.AboveBounds(mid, ref key, ref max))
    {
        //return location and closest value
        return $""Location: {mid} Value: {input[mid]}"";
    }
    //check if it belongs below the array
    else if (SearchChecking.BelowBounds(mid, ref key))
    {
        //return location and closest value
        return $""Location: {mid} Value: {input[mid]}"";
    }

    //check if it fits between two items in array
    else if (SearchChecking.ShouldGoHere(input[mid], input[mid + 1], ref key, ref max)) //if it fits here and not here, find closest
    {
        //return closest value and location
        return SearchChecking.ClosestValue(ref input, mid, mid + 1, ref key);
    }

    //where to look next
    else if (key<input[mid])
    {
        max = mid - 1;
    }
    else
    {
        min = mid + 1;
    }
}

//return error
return ""Item not found"";");
}

        public override string Search(decimal[] input, decimal target)
        {
            return ISearch(input, 0, input.Count() - 1, target);
        }

        public string ISearch(decimal[] input, int min, int max, decimal key)
        {
            Update(1, 3); //Line number
            //midpoint container
            int mid;
            int count = 0;

            Update(5, 6);
            while (min <= max)
            {
                Update(7, 9);
                //add counter
                count++;
                Output.UpdateOperations(count);

                Update(10, 11);
                //get midpoint
                mid = (int)(min + (max - min) * ((key - input[min]) / (input[max] - input[min])));

                //highlight
                Output.HighlightBar(mid);

                Update(13, 22);
                //keep it in bounds of array
                if (mid < 0)
                {
                    mid = 0;
                }

                else if (mid > max)
                {
                    mid = max;
                }

                Update(24, 26);
                //if found
                if (key == input[mid])
                {
                    Update(27, 28);
                    //add location to string
                    string tmp = $"Location: {mid}";
                    Update(30, 34);
                    //check for duiplicates
                    int countLeft = 0;
                    SearchChecking.LookForDupesLeft(ref input, mid, ref key, ref countLeft);
                    int countRight = 0;
                    SearchChecking.LookForDupesRight(ref input, mid, ref key, ref countRight, ref max);

                    Update(36, 40);
                    //add duplicate locations
                    for (int i = 1; i <= countLeft; i++)
                    {
                        tmp = $"{tmp}\nLocation: {mid - i}";
                    }
                    Update(42, 45);
                    for (int i = 1; i <= countRight; i++)
                    {
                        tmp = $"{tmp}\nLocation: {mid + i}";
                    }

                    Update(47, 48);
                    //return string
                    return tmp;
                }

                //check if it belongs above the array
                else if (SearchChecking.AboveBounds(mid, ref key, ref max))
                {
                    Update(51, 56);
                    //return location and closest value
                    return $"Location: {mid} Value: {input[mid]}";
                }
                //check if it belongs below the array
                else if (SearchChecking.BelowBounds(mid, ref key))
                {
                Update(57, 62);
                    //return location and closest value
                    return $"Location: {mid} Value: {input[mid]}";
                }

                //check if it fits between two items in array
                else if (SearchChecking.ShouldGoHere(input[mid], input[mid + 1], ref key, ref max)) //if it fits here and not here, find closest
                {
                    Update(64, 69);
                    //return closest value and location
                    return SearchChecking.ClosestValue(ref input, mid, mid + 1, ref key);
                }

                //where to look next
                else if (key < input[mid])
                {
                    Update(71, 75);
                    max = mid - 1;
                }
                else
                {
                    Update(76, 79);
                    min = mid + 1;
                }
            }

            Update(82, 83);
            //return error
            return "Item not found";

        }


    }
}
