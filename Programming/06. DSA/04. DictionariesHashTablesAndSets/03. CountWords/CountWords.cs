namespace _03.CountWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CountWords
    {
        public static void Main()
        {
            string textFilePath = "..//..//text.txt";
            string resultFilePath = "..//..//result.txt";

            string content = ReadFile(textFilePath);
            Dictionary<string, int> words = CountWordsInText(content);
            SaveContentToFile(resultFilePath, words);

            Console.WriteLine("Words from text.txt have been counted.");
            Console.WriteLine("The result is saved in result.txt");
            Console.WriteLine("Please check the project directory for the new file.");
        }

        public static string ReadFile(string textFilePath)
        {
            StringBuilder content = new StringBuilder();
            string line = string.Empty;
            StreamReader textFileReader = new StreamReader(textFilePath);

            using (textFileReader)
            {
                line = textFileReader.ReadLine();

                while (line != null)
                {
                    content.Append(line);
                    line = textFileReader.ReadLine();
                }
            }

            return content.ToString();
        }

        public static Dictionary<string, int> CountWordsInText(string text)
        {
            Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            MatchCollection wordsInLine = Regex.Matches(text, @"\w+");

            foreach (Match item in wordsInLine)
            {
                if (words.ContainsKey(item.Value))
                {
                    words[item.Value]++;
                }
                else
                {
                    words.Add(item.Value, 1);
                }
            }

            return words;
        }

        public static void SaveContentToFile(string resultFilePath, Dictionary<string, int> words)
        {
            StreamWriter resultFileWriter = new StreamWriter(resultFilePath);

            using (resultFileWriter)
            {
                foreach (var item in words.OrderBy(x => x.Value))
                {
                    resultFileWriter.WriteLine("{0} --> {1}", item.Key.ToLower(), item.Value);
                }
            }
        }
    }
}
