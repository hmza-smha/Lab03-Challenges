using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    /*
     * Write a method that reads in the file from Challenge 6. Removes one of the words, and rewrites it back to the file.
     */
    class Challenge8
    {

        public static void Start()
        {
            Console.WriteLine("Please Enter a word to be deleted from 'Words.txt'");
            string input = Console.ReadLine();
            RemoveWord(input);
        }
        public static void RemoveWord(string input)
        {
            String[] fileContent = File.ReadAllLines("Words.txt");

            // spliting first line => becase it allways one line
            string[] words = fileContent[0].Split(" ");

            string newContent = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != input)
                    newContent += words[i] + " ";
            }

            File.WriteAllText("Words.txt", newContent);

            Console.WriteLine("The new content is");
            String[] newfileContent = File.ReadAllLines("Words.txt");
            for (int i = 0; i < newfileContent.Length; i++)
                Console.WriteLine(newfileContent[i]);
        }
    }
}
