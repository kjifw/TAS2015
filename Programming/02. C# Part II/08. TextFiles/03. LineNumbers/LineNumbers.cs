// ### Problem 3. Line numbers
// * Write a program that reads a text file and inserts line numbers in front of each of its lines.
// * The result should be written to another text file.

namespace _03.LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    class LineNumbers
    {
        static void Main(string[] args)
        {
            string firstFilePath = "..//..//file1.txt";
            string secondFilePath = "..//..//file2.txt";

            InsertLineNumbers(firstFilePath, secondFilePath);
            Console.WriteLine("Line numbers inserted.");
            Console.WriteLine("Please check project directory for the new file with line numbers.");
        }

        private static void InsertLineNumbers(string firstPath, string secondPath)
        {
            StreamReader firstFileReader = new StreamReader(firstPath);
            StreamWriter secondFileWriter = new StreamWriter(secondPath);

            string line = string.Empty;
            int lineNumber = 1;

            using (firstFileReader)
            using (secondFileWriter)
            {
                line = firstFileReader.ReadLine();
                while (line != null)
                {
                    secondFileWriter.WriteLine("{0} {1}", lineNumber, line);
                    lineNumber++;
                    line = firstFileReader.ReadLine();
                }
            }
        }
    }
}
