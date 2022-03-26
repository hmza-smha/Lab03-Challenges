using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge6
    {
        /*
         * Write a method that asks the user to input a word, and then saves that word into an external file named 'Words.txt'
         */

        public static void SaveWord()
        {
            Console.WriteLine("Enter a text to be saved into (Words.txt)");

            string text = Console.ReadLine();

            File.WriteAllText("Words.txt", text);
        }
    }
}
