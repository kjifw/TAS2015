
namespace _02.MovingLetters
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    class MovingLetters
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            words = ReadWords();

            string result = ExtractLetters(words);

            result = ReorderLetters(result);

            Console.WriteLine(result);
        }

        private static List<string> ReadWords()
        {
            string line = Console.ReadLine();

            List<string> words = line.Split(' ').ToList();

            return words;
        }

        private static string ReorderLetters(string result)
        {
            StringBuilder res = new StringBuilder();
           
            foreach (var item in result)
            {
                res.Append(item);
            }

            for (int i = 0; i < res.Length; i++)
            {
                int positionsToRight = char.ToLower(res[i]) - 'a' + 1;

                positionsToRight = (i + positionsToRight) % res.Length;
               
                string currentLetter = res[i].ToString();
                
                res = res.Remove(i, 1);
                res = res.Insert(positionsToRight, currentLetter);
            }

            return res.ToString();
        }

        private static string ExtractLetters(List<string> words)
        {
            int len = 0;
            foreach (var item in words)
            {
                len += item.Length;
            }

            StringBuilder result = new StringBuilder(2 * len);

            for (int i = 0; i < 2 * len; i++)
            {
                result.Append("0");
            }

            int step = 0;

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];

                for (int j = currentWord.Length - 1; j >= 0; j--)
                {
                    result.Replace("0", currentWord[j].ToString(), step + i, 1);
                    step += words.Count;
                }

                step = 0;
            }

            return result.Replace("0", string.Empty).ToString();
        }
    }
}
