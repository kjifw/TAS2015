// Problem 22. Words count
// * Write a program that reads a string from the console and lists all 
//   different words in the string along with information how many times 
//   each word is found.

namespace _22.WordsCount
{
    using System;
    using System.Collections.Generic;

    class WordsCount
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
//            string text = @"Lorem ipsum dolod tit amet, consectetur adipiscing elit. 
//                                        Aenean consequat id lorol sed lorem varius. Fusce egestas dictum nunc et mollis. 
//                                        Donec elementum libero velit, teget lorem ullamcorper est maximus ut. 
//                                        Suspendisse condimentum lamal pellentesque lebel et porttitor. Aenean ut semper eros.";

            string text = Console.ReadLine();

            words = WordsCountInText(text);

            PrintDictionary(words);
        }

        private static void PrintDictionary(Dictionary<string, int> letters)
        {
            foreach (var item in letters)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }
        }

        private static Dictionary<string, int> WordsCountInText(string text)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            text = text.ToLower().Replace("\r\n", string.Empty);
            string[] wordsAsStr = text.Split(
                new char[] { ' ', '.', ',', '!', '?', ':', ';', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            int count = 1;
            for (int i = 0; i < wordsAsStr.Length; i++)
            {
                string currentWord = wordsAsStr[i];

                if (words.ContainsKey(currentWord))
                {
                    words[currentWord]++;
                }
                else
                {
                    words.Add(currentWord, count);
                }
            }

            return words;
        }
    }
}
