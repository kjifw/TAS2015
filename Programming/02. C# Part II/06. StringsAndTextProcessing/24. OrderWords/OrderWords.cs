// Problem 24. Order words
// * Write a program that reads a list of words, separated by spaces 
//   and prints the list in an alphabetical order.

namespace _24.OrderWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OrderWords
    {
        static void Main(string[] args)
        {
            string inputStr; // = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";
            List<string> words = new List<string>();

            inputStr = Console.ReadLine();

            words = WordsInAlphabeticalOrder(inputStr);

            PrintList(words);
        }

        private static void PrintList(List<string> words)
        {
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        private static List<string> WordsInAlphabeticalOrder(string text)
        {
            List<string> words = new List<string>();

            words = text.Split(' ').ToList();
            words.Sort();

            return words;
        }
    }
}
