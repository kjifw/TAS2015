// Problem 10. Extract text from XML
// * Write a program that extracts from given XML file all the text without the tags.
//
// Example:
// 
// <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
// <interest>Games</interest><interest>C#</interest><interest>Java</interest></interests>
// </student>

namespace _10.ExtractTextFromXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractTextFromXml
    {
        static void Main(string[] args)
        {
            string inputFilePath = "..//..//file1.txt";
            string outputFilePath = "..//..//file2.txt";
            string text;

            text = ExtractText(inputFilePath);
            Console.WriteLine("Text successfully extracted from code.");
            
            PrintTextToFile(outputFilePath,text);
            Console.WriteLine("Text saved to new file.");
            Console.WriteLine("Please check project directory for the new file.");
        }

        private static string ExtractText(string filePath)
        {
            StreamReader fileReader = new StreamReader(filePath);

            StringBuilder text = new StringBuilder();
            string line = string.Empty;

            using (fileReader)
            {
                line = fileReader.ReadLine();
                while (line != null)
                {
                    MatchCollection xmlTags = Regex.Matches(line, @"(.*?)(<.*?>)(.*?)");

                    foreach (Match item in xmlTags)
                    {
                        line = line.Replace(item.Groups[2].Value, " ");
                    }

                    line = Regex.Replace(line, @"\s+", string.Empty);

                    if (line != string.Empty)
                    {
                        text.AppendLine(line);
                    }

                    line = fileReader.ReadLine();
                }
            }

            return text.ToString().Trim();
        }

        private static void PrintTextToFile(string filePath, string text)
        {
            StreamWriter fileWriter = new StreamWriter(filePath);

            using (fileWriter)
            {
                fileWriter.WriteLine(text);
            }
        }
    }
}
