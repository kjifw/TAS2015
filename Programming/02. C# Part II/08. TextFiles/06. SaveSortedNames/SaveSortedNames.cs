// ### Problem 6. Save sorted names
// * Write a program that reads a text file containing a list of strings, 
//   sorts them and saves them to another text file.
// 
// _Example:_
// 
// |  input.txt | output.txt |
// |:----------:|:----------:|
// | Ivan       | George     |
// | Peter      | Ivan       |
// | Maria      | Maria      |
// | George     | Peter      |

namespace _06.SaveSortedNames
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            string inputFilePath = "..//..//names.txt";
            string outputFilePath = "..//..//sorted-names.txt";

            SaveSortedStrings(inputFilePath, outputFilePath);
            Console.WriteLine("Lines from the first file are sorted and saved to new file.");
            Console.WriteLine("Please check project directory for the new file.");
        }

        private static void SaveSortedStrings(string inputFilePath, string outputFilePath)
        {
            StreamReader inputFileReader = new StreamReader(inputFilePath);
            StreamWriter outputFileWriter = new StreamWriter(outputFilePath);

            List<string> strsList = new List<string>();
            string line = string.Empty;

            using(inputFileReader)
            using (outputFileWriter)
            {
                line = inputFileReader.ReadLine();
                while (line != null)
                {
                    strsList.Add(line);
                    line = inputFileReader.ReadLine();
                }

                strsList.Sort();

                foreach (var item in strsList)
                {
                    outputFileWriter.WriteLine(item);                    
                }
            }
        }
    }
}
