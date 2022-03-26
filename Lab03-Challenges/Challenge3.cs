using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge3
    {
        /*
         * Drawing a diamond using stars
         */
        public static void Draw(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = size; i >= 1; i--)
            {
                for (int j = size - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
