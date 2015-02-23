// ### Problem 2. Concatenate text files
// * Write a program that concatenates two text files into another text file.

namespace _02.ConcatenateTextFiles
{
    using System;
    using System.IO;

    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string firstFilePath = "..//..//file1.txt";
            string secondFilePath = "..//..//file2.txt";
            string concatenatedFilePath = "..//..//concatenated.txt";

            ConcatenateFiles(firstFilePath, secondFilePath, concatenatedFilePath);
            Console.WriteLine("Files concatenated.");
            Console.WriteLine("Please check project directory for the concatenated file.");
        }

        private static void ConcatenateFiles(string firstPath, string secondPath, string concatPath)
        {
            StreamReader firstFileReader = new StreamReader(firstPath);
            StreamReader secondFileReader = new StreamReader(secondPath);

            StreamWriter concatFileWriter = new StreamWriter(concatPath);

            string firstFileContent = firstFileReader.ReadToEnd();
            string secondFileContent = secondFileReader.ReadToEnd();

            using (firstFileReader)
            using (secondFileReader)
            using (concatFileWriter)
            {
                concatFileWriter.WriteLine(firstFileContent);
                concatFileWriter.WriteLine(secondFileContent);
            }
        }
    }
}
