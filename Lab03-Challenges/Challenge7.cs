using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge7
    {
        /*
         * Write a method that reads the file in from Challenge 6, and outputs the contents to the console.
         */
        public static void Read()
        {
            Console.WriteLine("The Content of 'Words.txt' is");
            String[] fileContent = File.ReadAllLines("Words.txt");
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }
    }
}
