// Problem 9. Forbidden words
// * We are given a string containing a list of forbidden words and a text containing some of these words.
// * Write a program that replaces the forbidden words with asterisks.
// 
// Example text: Microsoft announced its next generation PHP compiler today. 
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// 
// Forbidden words: PHP, CLR, Microsoft
// 
// The expected result: ********* announced its next generation *** compiler today. 
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09.ForbiddenWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string inputStr;// = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string result;
            List<string> wordsToReplace = new List<string>();
            wordsToReplace.Add("PHP");
            wordsToReplace.Add("CLR");
            wordsToReplace.Add("Microsoft");

            inputStr = Console.ReadLine();

            result = RemoveForbiddenWords(inputStr, wordsToReplace);

            Console.WriteLine(result);
        }

        private static string RemoveForbiddenWords(string text, List<string> words)
        {
            foreach (var item in words)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Count()));
                }
            }

            return text;
        }
    }
}
