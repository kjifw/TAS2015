
namespace _02.MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MagicWords
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            words = ReadWords();

            words = ReorderWords(words);
            
            PrintLetters(words);
        }

        private static void PrintLetters(List<string> words)
        {
            int longest = words.Max(x => x.Length);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < longest; i++)
            {
                foreach (string item in words)
                {
                    if (i <= item.Length - 1)
                    {
                        result.Append(item[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }

        private static List<string> ReadWords()
        {
            List<string> words = new List<string>();

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentWord = Console.ReadLine();
                words.Add(currentWord);
            }

            return words;
        }

        private static List<string> ReorderWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int newPosition = currentWord.Length % (words.Count + 1);

                words.Insert(newPosition, currentWord);

                if (newPosition < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }

            return words;
        }
    }
}
