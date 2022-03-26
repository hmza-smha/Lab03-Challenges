using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    /*
     * Write a method that brings in an integer array and returns the number that appears the most times.
     * If there are no duplicates, return the first number in the array.
     * If more than one number show up the same amount of time, return the first found.
     * 
     */
    public class Challenge4
    {
        
        public static int GetMostRepeated(int[] arr)
        {
            int max = arr[0];

            // get the max of the array
            foreach (int e in arr)
            {
                if (e > max)
                    max = e;
            }
            
            // create a new array with size of max number 
            int[] temp = new int[max + 1];

            // count appear numbers in arr
            for (int i = 0; i < arr.Length; i++)
            {
                temp[arr[i]]++;
            }

            int result = temp[0];
            int index = 1;

            // get the max appear number
            for(int i = 0; i < temp.Length; i++)
            {
                if(temp[i] > result)
                {
                    result = temp[i];
                    index = i;
                }
            }
            // by default every number apear at least one time, so If there are no duplicates, return the first number in the array.
            return index == 1 ? arr[0] : index;
        }
    }
}
