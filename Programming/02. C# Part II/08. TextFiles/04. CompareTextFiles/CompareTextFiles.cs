// ### Problem 4. Compare text files
// * Write a program that compares two text files line by line and 
//   prints the number of lines that are the same and the number of 
//   lines that are different.
// * Assume the files have equal number of lines.

namespace _04.CompareTextFiles
{
    using System;
    using System.IO;
    using System.Text;

    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            string firstFilePath = "..//..//file1.txt";
            string secondFilePath = "..//..//file2.txt";
            string result;

            result = CompareFiles(firstFilePath, secondFilePath);

            Console.WriteLine(result);
        }

        private static string CompareFiles(string firstPath, string secondPath)
        {
            StreamReader firstFileReader = new StreamReader(firstPath);
            StreamReader secondFileReader = new StreamReader(secondPath);
            
            string firstFileLine = string.Empty;
            string secondFileLine = string.Empty;
            int equalLinesCount = 0;
            int differentLinesCount = 0;

            string result = string.Empty;

            using(firstFileReader)
            using (secondFileReader)
            {
                firstFileLine = firstFileReader.ReadLine();
                secondFileLine = secondFileReader.ReadLine();

                while (firstFileLine != null)
                {
                    if (firstFileLine.Equals(secondFileLine))
                    {
                        equalLinesCount++;
                    }
                    else
                    {
                        differentLinesCount++;
                    }

                    firstFileLine = firstFileReader.ReadLine();
                    secondFileLine = secondFileReader.ReadLine();
                }
            }

            result = string.Format(
                "equal lines: {0}\ndifferent lines: {1}",
                equalLinesCount, 
                differentLinesCount);

            return result;
        }
    }
}
