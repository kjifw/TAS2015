// ### Problem 12. Index of letters
// * Write a program that creates an array containing all letters from the alphabet (`A-Z`).
// * Read a word from the console and print the index of each of its letters in the array.

namespace _12.IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            int[] lettersInEnglish = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
                                         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 
                                         'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            string wordPattern = @"^[A-Za-z]+$";
            string inputStr;
            List<int> listOfIndexesOfWord;

            inputStr = Console.ReadLine();

            bool isValidWord = Regex.IsMatch(inputStr, wordPattern);

            while (!isValidWord)
            {
                Console.Clear();
                Console.Write("Input word - only letters: ");
                inputStr = Console.ReadLine();
                isValidWord = Regex.IsMatch(inputStr, wordPattern);
            }

            listOfIndexesOfWord = FindIndexOfLetters(inputStr, lettersInEnglish);

            foreach (var item in listOfIndexesOfWord)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }

        private static List<int> FindIndexOfLetters(string input, int[] indexes)
        {
            char[] letters;
            List<int> lettersIndexes = new List<int>();

            letters = input.ToUpper().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (letters[i] == indexes[j])
                    {
                        lettersIndexes.Add((indexes[j] - 'A') + 1);
                    }
                }

            }

            return lettersIndexes;
        }
    }
}
