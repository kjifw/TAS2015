// Problem 23. Series of letters
// * Write a program that reads a string from the console and replaces 
//   all series of consecutive identical letters with a single one.
//
// Example:
// input 	                output
// aaaaabbbbbcdddeeeedssaa 	abcdedsa

namespace _23.SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string inputStr;// = "aaaaabbbbbcdddeeeedssaaaaaaabbbbbcdddeeeedssaaaaaaabbbbbcdddeeeedssaa";
            string output;

            inputStr = Console.ReadLine();

            output = ReplaceLetters(inputStr);

            Console.WriteLine(output);
        }

        private static string ReplaceLetters(string str)
        {
            List<char> replaced = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (replaced.Contains(str[i]) && str[i] == replaced.Last())
                {
                    continue;
                }
                else
                {
                    replaced.Add(str[i]);
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (var item in replaced)
            {
                result.Append(item);
            }

            return result.ToString();
        }
    }
}
