
namespace _04.RelevanceIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RelevanceIndex
    {
        static void Main(string[] args)
        {
            string inputStr;
            int numberOfParagrahps;
            List<string> paragrahps = new List<string>();

            string searchWord = Console.ReadLine();

            inputStr = Console.ReadLine();
            numberOfParagrahps = Convert.ToInt32(inputStr);

            paragrahps = ReadAndClearText(numberOfParagrahps);

            Dictionary<string, int> result = FindAndReplaceSearchWord(paragrahps, searchWord);
        
            PrintDictionary(result);
        }

        private static Dictionary<string, int> FindAndReplaceSearchWord(List<string> paragraphs, string searchWord)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in paragraphs)
            {
                MatchCollection words = Regex.Matches(item, @"\b" + searchWord + @"\b", RegexOptions.IgnoreCase);
                string paragraph = string.Empty;

                paragraph = Regex.Replace(item,
                    @"\b" + searchWord + @"\b",
                   searchWord.ToUpper(), 
                   RegexOptions.IgnoreCase);

                dict.Add(paragraph, words.Count);
            }

            return dict;
        }

        private static void PrintDictionary(Dictionary<string, int> relev)
        {
            foreach (var item in relev.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key);
            }
        }

        private static List<string> ReadAndClearText(int paragraphCount)
        {
            List<string> paragraphs = new List<string>();

            for (int i = 0; i < paragraphCount; i++)
            {
                string paragraph = Console.ReadLine()
                       .Replace(',', ' ')
                       .Replace('.', ' ')
                       .Replace('(', ' ')
                       .Replace(')', ' ')
                       .Replace(';', ' ')
                       .Replace('-', ' ')
                       .Replace('!', ' ')
                       .Replace('?', ' ');

                paragraph = Regex.Replace(paragraph, @"\s+", " ");

                paragraphs.Add(paragraph);
            }

            return paragraphs;
        }
    }
}
