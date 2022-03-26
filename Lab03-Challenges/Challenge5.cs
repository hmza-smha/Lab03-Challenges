using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    public class Challenge5
    {
        /* Write a method in that finds the maximum value in the array. The array is not sorted. You may not use Array.Sort();
         * Tests: 1. Negative numbers 2. All values are the same
         */
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int e in arr)
            {
                if (e > max)
                    max = e;
            }

            return max;
        }
    }
}
