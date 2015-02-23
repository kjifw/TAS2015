// Problem 13. Count words
// * Write a program that reads a list of words from the file words.txt and 
//   finds how many times each of the words is contained in another file test.txt.
// * The result should be written in the file result.txt and the words should be 
//   sorted by the number of their occurrences in descending order.
// * Handle all possible exceptions in your methods.

namespace _13.CountWords
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Security;

    class CountWords
    {
        static void Main(string[] args)
        {
            string textFilePath = "..//..//text.txt";
            string wordsFilePath = "..//..//words.txt";
            string resutlFilePath = "..//..//result.txt";

            try
            {
                CountWordsFromFile(textFilePath, wordsFilePath, resutlFilePath);

                Console.WriteLine("Words from words.txt are counted in text.txt");
                Console.WriteLine("The result is saved in result.txt");
                Console.WriteLine("Please check the project directory for the new file");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Some of the arguments are null.");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("Some of the arguments are invalid.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("One of the files was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Directory of one of the files was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("Permissions required to write in the selected file.");
            }
            catch (PathTooLongException)
            {
                Console.Error.WriteLine("One of the paths to the files is too long.");
            }
            catch (SecurityException)
            {
                Console.Error.WriteLine("Permissions required to access a resource.");
            }
            catch (OutOfMemoryException)
            {
                Console.Error.WriteLine("Insufficient memory.");
            }
        }

        private static void CountWordsFromFile(
            string textFilePath,
            string wordsFilePath,
            string resultFilePath)
        {
            StreamReader textFileReader = new StreamReader(textFilePath);
            StreamReader wordsFileReader = new StreamReader(wordsFilePath);
            StreamWriter resultFileWriter = new StreamWriter(resultFilePath);

            Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            string line = string.Empty;
            int count = 0;

            using (wordsFileReader)
            {
                line = wordsFileReader.ReadLine();
                while (line != null)
                {
                    words.Add(line, count);
                    line = wordsFileReader.ReadLine();
                }
            }

            line = string.Empty;

            using (textFileReader)
            {
                line = textFileReader.ReadLine();
                while (line != null)
                {
                    MatchCollection wordsInLine = Regex.Matches(line, @"\w+");

                    foreach (Match item in wordsInLine)
                    {
                        if (words.ContainsKey(item.Value))
                        {
                            words[item.Value]++;
                        }
                    }

                    line = textFileReader.ReadLine();
                }
            }

            using (resultFileWriter)
            {
                foreach (var item in words.OrderByDescending(x => x.Value))
                {
                    resultFileWriter.WriteLine("{0} --> {1}", item.Key, item.Value);
                }
            }
        }
    }
}