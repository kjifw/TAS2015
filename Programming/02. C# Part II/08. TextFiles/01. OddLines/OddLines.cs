// ### Problem 1. Odd lines
// * Write a program that reads a text file and prints on the console its odd lines.

namespace _01.OddLines
{
    using System;
    using System.IO;
    using System.Text;

    class OddLines
    {
        static void Main(string[] args)
        {
            string path = "..//..//file.txt";
            StringBuilder fileContent = new StringBuilder();

            fileContent = ReadFile(path);

            Console.WriteLine(fileContent.ToString().Trim());
        }

        private static StringBuilder ReadFile(string path)
        {
            StringBuilder fileContent = new StringBuilder();
            StreamReader reader = new StreamReader(path);
           
            string line = string.Empty;
            int lineNumber = 1;

            using (reader)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    if ((lineNumber & 1) == 1)
                    {
                        fileContent.AppendLine(line);
                    }

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }

            return fileContent;
        }
    }
}
