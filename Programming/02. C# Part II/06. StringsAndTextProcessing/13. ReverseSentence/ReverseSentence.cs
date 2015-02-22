// Problem 13. Reverse sentence
// * Write a program that reverses the words in given sentence.
//
// Example:
// input 	                                output
// C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

namespace _13.ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string inputStr;// = "C# is not C++, not PHP and not Delphi!";
            string reverced;

            inputStr = Console.ReadLine();

            reverced = Reverse(inputStr);

            Console.WriteLine(reverced);
        }

        private static string Reverse(string sentence)
        {
            StringBuilder reversed = new StringBuilder();
            List<KeyValuePair<char, int>> symbols = new List<KeyValuePair<char, int>>();

            char sentenceEnding = sentence[sentence.Length - 1];
            sentence = sentence.Remove(sentence.Length - 1);

            string[] words = sentence.Split(new char[] { ' ' });

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i].Contains(','))
                {
                    words[i] = words[i].Replace(",", string.Empty);
                    symbols.Add(new KeyValuePair<char, int>(',', i));
                }
                
                reversed.Append(words[i] + " ");
            }

            reversed.Replace(" ", sentenceEnding.ToString(), reversed.Length - 1, 1);

            sentence = reversed.ToString().Trim();
            words = sentence.Split(' ');
            reversed.Clear();

            foreach (var item in symbols)
            {
                words[item.Value] += item.Key;
            }

            for (int i = 0; i < words.Length; i++)
            {
                reversed.Append(words[i] + " ");
            }

            return reversed.ToString();
        }
    }
}
