// Problem 11. Prefix "test"
// * Write a program that deletes from a text file all words that start with the prefix test.
// * Words contain only the symbols 0…9, a…z, A…Z, _.

namespace _11.PrefixTest
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class PrefixTest
    {
        static void Main(string[] args)
        {
            string inputFilePath = "..//..//file1.txt";
            string outputFilePath = "..//..//result.txt";
            string strToBeReplaced = "test";
            string replacingStr = string.Empty;

            ReplaceStringInFile(inputFilePath, outputFilePath, strToBeReplaced, replacingStr);

            Console.WriteLine("Words starting with {0} are removed", strToBeReplaced);
            Console.WriteLine("from the first file and all else is saved to new file.");
            Console.WriteLine("Please check project directory for the new file.");
        }

        private static void ReplaceStringInFile(
            string inputFilePath,
            string outputFilePath,
            string strToBeReplaced,
            string replacingStr)
        {
            StreamReader inputFileReader = new StreamReader(inputFilePath);
            StreamWriter outputFileWriter = new StreamWriter(outputFilePath);

            string line = string.Empty;

            using (inputFileReader)
            using (outputFileWriter)
            {
                line = inputFileReader.ReadLine();
                while (line != null)
                {
                    MatchCollection words = Regex.Matches(line, @"\b" + strToBeReplaced + @"\w+\b");

                    foreach (Match item in words)
                    {
                        line = line.Replace(item.Value, replacingStr);
                    }

                    outputFileWriter.WriteLine(line);
                    line = inputFileReader.ReadLine();
                }
            }
        }
    }
}
