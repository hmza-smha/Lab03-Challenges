using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    public class Challenge9
    {
        /*
         * Write a method that asks the user to input a sentence and returns an array
         * that with the word and the number of characters each word has
         */
        public static void Start()
        {
            Console.WriteLine("Enter a sentence to be counted.");
            string text = Console.ReadLine();
            string[] words = CountLetters(text);
            foreach (string e in words)
            {
                Console.Write(e + ", ");
            }
        }
        public static string[] CountLetters(string text)
        {
            string[] arr = text.Split(" ");

            int len;
            string wordWithLen;
            for(int i = 0; i < arr.Length; i++)
            {
                len = arr[i].Length;

                wordWithLen = arr[i] + ":" + len;

                arr[i] = wordWithLen;
            }

            return arr;
        }
    }
}
