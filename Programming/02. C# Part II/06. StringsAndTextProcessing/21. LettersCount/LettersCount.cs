// Problem 21. Letters count
// * Write a program that reads a string from the console and prints 
//   all different letters in the string along with information how 
//   many times each letter is found.

namespace _21.LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class LettersCount
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
//            string text = @"Lorem ipsum dolod tit amet, consectetur adipiscing elit. 
//                            Aenean consequat id lorol sed varius. Fusce egestas dictum nunc et mollis. 
//                            Donec elementum libero velit, teget ullamcorper est maximus ut. 
//                            Suspendisse condimentum lamal pellentesque lebel et porttitor. Aenean ut semper eros.";

            string text = Console.ReadLine();

            letters = LettersCountInText(text);

            PrintDictionary(letters);
        }

        private static void PrintDictionary(Dictionary<char, int> letters)
        {
            foreach (var item in letters)
            {
                if (item.Key != '\r' && item.Key != '\n' && item.Key != ' ')
                {
                    Console.WriteLine("{0} --> {1}", item.Key, item.Value);
                }
                else if (item.Key == '\r')
                {
                    Console.WriteLine("\\r --> {0}", item.Value);
                }
                else if (item.Key == '\n')
                {
                    Console.WriteLine("\\n --> {0}", item.Value);
                }
                else if (item.Key == ' ')
                {
                    Console.WriteLine("space --> {0}", item.Value);
                }
            }
        }

        private static Dictionary<char, int> LettersCountInText(string text)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            int count = 1;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (symbols.ContainsKey(currentSymbol))
                {
                    symbols[currentSymbol]++;
                }
                else
                {
                    symbols.Add(currentSymbol, count);
                }
            }
            
            return symbols;
        }
    }
}
