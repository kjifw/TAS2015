// ### Problem 8. Replace whole word
// * Modify the solution of the previous problem to replace only whole words (not strings).

namespace _08.ReplaceWholeWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceWholeWords
    {
        static void Main(string[] args)
        {
            string inputFilePath = "..//..//file1.txt";
            string outputFilePath = "..//..//result.txt";
            string strToBeReplaced = "start";
            string replacingStr = "finish";

            ReplaceStringInFile(inputFilePath, outputFilePath, strToBeReplaced, replacingStr);

            Console.WriteLine("Words from the first file are replaced and saved to new file.");
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
                    MatchCollection words = Regex.Matches(line, @"\w+");

                    foreach (Match item in words)
                    {
                        if (item.Value == strToBeReplaced)
                        {
                            line = line.Replace(item.Value, replacingStr);
                        }
                    }

                    outputFileWriter.WriteLine(line);
                    line = inputFileReader.ReadLine();
                }
            }
        }
    }
}
