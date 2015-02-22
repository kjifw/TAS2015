// Problem 20. Palindromes
// * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace _20.Palindromes
{
    using System;
    using System.Collections.Generic;

    class Palindromes
    {
        static void Main(string[] args)
        {
            List<string> palin = new List<string>();
            //string text = @"Lorem ipsum dolod tit amet, consectetur adipiscing elit. 
            //                Aenean consequat id lorol sed varius. Fusce egestas dictum nunc et mollis. 
            //                Donec elementum libero velit, teget ullamcorper est maximus ut. 
            //                Suspendisse condimentum lamal pellentesque lebel et porttitor. Aenean ut semper eros.";

            string text = Console.ReadLine();

            palin = ExtractPalindromes(text);

            foreach (var item in palin)
            {
                Console.WriteLine(item);
            }
        }

        private static List<string> ExtractPalindromes(string text)
        {
            List<string> palindromesList = new List<string>();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                string currentWord = words[i];

                int right = currentWord.Length - 1;
                for (int left = 0; left <= currentWord.Length - 1; left++)
                {
                    if (currentWord[left] == currentWord[right])
                    {
                        count++;
                    }

                    right--;
                }

                if (count == currentWord.Length)
                {
                    palindromesList.Add(currentWord);
                }
            }

            return palindromesList;
        }
    }
}
