// Problem 14. Word dictionary
// * A dictionary is stored as a sequence of text lines containing words and their explanations.
// * Write a program that enters a word and translates it by using the dictionary.
//
// Sample dictionary:
// input 	    output
// .NET 	    platform for applications from Microsoft
// CLR 	        managed execution environment for .NET
// namespace 	hierarchical organization of classes

namespace _14.WordDictionary
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        static void Main(string[] args)
        {
            string inputStr;
            Dictionary<string, string> termsDictionary = new Dictionary<string, string>();
            List<string> terms = new List<string>();
            terms.Add(".NET");
            terms.Add("CLR");
            terms.Add("namespace");
            List<string> explanations = new List<string>();
            explanations.Add("platform for applications from Microsoft");
            explanations.Add("managed execution environment for .NET");
            explanations.Add("hierarchical organization of classes");

            if (terms.Count == explanations.Count)
            {
                termsDictionary = PopulateDictionary(terms, explanations);
            }

            inputStr = Console.ReadLine();

            if (termsDictionary.ContainsKey(inputStr))
            {
                string value = string.Empty;
                termsDictionary.TryGetValue(inputStr, out value);

                Console.WriteLine(value);
            }
        }

        private static Dictionary<string, string> PopulateDictionary(List<string> terms, List<string> explanations)
        {
            Dictionary<string, string> termsDictionary = new Dictionary<string, string>();

            foreach (var item in terms)
            {
                termsDictionary.Add(item, explanations[terms.IndexOf(item)]);
            }

            return termsDictionary;
        }
    }
}
