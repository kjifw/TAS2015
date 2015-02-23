// ### Problem 7. Replace sub-string
// * Write a program that replaces all occurrences of the sub-string `start` with the sub-string `finish` in a text file.
// * Ensure it will work with large files (e.g. `100 MB`).

namespace _07.ReplaceSubstring
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceSubstring
    {
        static void Main(string[] args)
        {
            string inputFilePath = "..//..//file1.txt";
            string outputFilePath = "..//..//result.txt";
            string strToBeReplaced = "start";
            string replacingStr = "finish";

            ReplaceStringInFile(inputFilePath, outputFilePath, strToBeReplaced, replacingStr);

            Console.WriteLine("Strings from the first file are replaced and saved to new file.");
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
                    line = Regex.Replace(line, strToBeReplaced, replacingStr);
                    outputFileWriter.WriteLine(line);
                    line = inputFileReader.ReadLine();
                }
            }
        }
    }
}
