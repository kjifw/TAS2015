// Problem 8. Extract sentences
// Write a program that extracts from a given text all sentences containing given word.
// 
// Example:
// 
// The word is: in
// 
// The text is: We are living in a yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
// 
// The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//
// Consider that the sentences are separated by . and the words – by non-letter symbols.

namespace _08.ExtractSentences
{
    using System;
    using System.Collections.Generic;

    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string inputStr;// = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searchWord = "in";
            List<string> result = new List<string>();

            inputStr = Console.ReadLine();

            result = ExtractSpecificSenteces(inputStr, searchWord);
            
            PrintListOfSentences(result);
        }

        private static void PrintListOfSentences(List<string> sentances)
        {
            foreach (var item in sentances)
            {
                Console.Write("{0}. ", item.Trim());
            }

            Console.WriteLine();
        }

        private static List<string> ExtractSpecificSenteces(string str, string searchWord)
        {
            List<string> extractedSenteces = new List<string>();
            string[] senteces = str.Split('.', '?', '!');

            for (int i = 0; i < senteces.Length; i++)
            {
                string currentSentence = senteces[i];
                string[] words = currentSentence.Split(' ', ',');

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == searchWord)
                    {
                        extractedSenteces.Add(currentSentence);
                        break;
                    }
                }
            }

            return extractedSenteces;
        }
    }
}
