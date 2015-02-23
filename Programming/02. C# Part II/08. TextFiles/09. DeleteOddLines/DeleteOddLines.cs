// Problem 9. Delete odd lines
// * Write a program that deletes from given text file all odd lines.
// * The result should be in the same file.

namespace _09.DeleteOddLines
{
    using System;
    using System.IO;

    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            string firstFilePath = "..//..//file1.txt";
            string secondFilePath = "..//..//file2.txt";

            RemoveOddLines(firstFilePath, secondFilePath);

            Console.WriteLine("Odd lines removed. Everything else added to new file.");
            Console.WriteLine("Please check project directory for the new file.");
        }

        private static void RemoveOddLines(string firstFilePath, string secondFilePath)
        {
            StreamReader firstFileReader = new StreamReader(firstFilePath);
            StreamWriter secondFileWriter = new StreamWriter(secondFilePath);

            string line = string.Empty;
            int lineNumber = 1;

            using (firstFileReader)
            using (secondFileWriter)
            {
                line = firstFileReader.ReadLine();
                while (line != null)
                {
                    if ((lineNumber & 1) == 0)
                    {
                        secondFileWriter.WriteLine(line);
                    }

                    lineNumber++;
                    line = firstFileReader.ReadLine();
                }
            }
        }
    }
}
