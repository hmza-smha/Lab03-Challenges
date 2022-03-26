using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    public class Challenge2
    {
        /*
         * Create a method that asks the user to enter a number between 2-10.
         * Then, prompt the user that number of times for random numbers.
         * After the user has inputted all of the numbers. Find the average of all the numbers inputted.
         */

        public static void Start()
        {
            string input;
            int n = -1;

            do
            {
                Console.WriteLine("Enter number between 2 and 10");
                input = Console.ReadLine();

                try
                {
                    n = Convert.ToInt32(input);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (n < 2 || n > 10);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter No. " + (i + 1) + " of " + n);
                string inputNo = Console.ReadLine();

                int num;

                try
                {
                    num = Convert.ToInt32(inputNo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                    continue;
                }

                if(num < 0)
                {
                    i--;
                    Console.WriteLine("You can not Enter Negative Numbers");
                    continue;
                }

                arr[i] = num;
            }

            int result = GetAvg(arr);
             
            Console.WriteLine("Avg: " + result);
        }

        public static int GetAvg(int[] numbers)
        {   
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (int) sum / numbers.Length;
        }
    }
}
