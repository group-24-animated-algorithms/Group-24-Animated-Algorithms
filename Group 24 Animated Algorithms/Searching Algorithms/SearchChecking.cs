using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_24_Animated_Algorithms.Searching_Algorithms
{
    class SearchChecking
    {
        public static void LookForDupesLeft(ref decimal[] input, int mid, ref decimal key, ref int count)
        {
            //check if furthest left
            if (mid == 0)
            {
                return;
            }

            //check left for repeat
            if (input[mid] == input[mid - 1])
            {
                //add counter
                count++;
                //check for more
                LookForDupesLeft(ref input, mid - 1, ref key, ref count);
            }
        }

        public static void LookForDupesRight(ref decimal[] input, int mid, ref decimal key, ref int count, ref int length)
        {
            //check if furthest right
            if (mid == length)
            {
                return;
            }

            //check right for repeat
            if (input[mid] == input[mid + 1])
            {
                //add counter
                count++;
                //look for more
                LookForDupesRight(ref input, mid + 1, ref key, ref count, ref length);
            }
        }

        public static bool ShouldGoHere(decimal d1, decimal d2, ref decimal key, ref int length)
        {
            //check if it fits between the two found
            if (d1 < key && d2 > key)
            {
                return true;
            }
            return false;
        }

        public static bool BelowBounds(int i1, ref decimal key)
        {
            //check if number is outside of array
            if (i1 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool AboveBounds(decimal i1, ref decimal key, ref int length)
        {
            //check if number is outside of array
            if (i1 == length)
            {
                return true;
            }
            return false;
        }

        public static string ClosestValue(ref decimal[] input, int i1, int i2, ref decimal key, ref Algorithm Alg)
        {
            //find diference between values
            decimal d1 = key - input[i1];
            decimal d2 = input[i2] - key;

            //find the closest
            if (d1 > d2)
            {
                //highlight
                Alg.Highlight(i2);

                return $" Location: {i2+1} Value: {input[i2]}";
            }
            else if (d2 > d1)
            {
                //highlight
                Alg.Highlight(i1);

                return $" Location: {i1 + 1} Value: {input[i1]}";
            }
            else
            {
                //highlight
                Alg.Highlight(i1);
                Alg.Highlight(i2);

                return $" Locations: {i1 + 1}, {i2 + 1} Values: {input[i1]}, {input[i2]}";
            }
        }
    }
}
