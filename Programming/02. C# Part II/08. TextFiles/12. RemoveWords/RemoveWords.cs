// Problem 12. Remove words
// * Write a program that removes from a text file all words listed in given another text file.
// * Handle all possible exceptions in your methods.

namespace _12.RemoveWords
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Security;

    class RemoveWords
    {
        static void Main(string[] args)
        {
            string textFilePath = "..//..//text.txt";
            string wordsFilePath = "..//..//words.txt";
            string resutlFilePath = "..//..//result.txt";

            try
            {
                RemoveWordsFromFile(textFilePath, wordsFilePath, resutlFilePath);

                Console.WriteLine("Words from words.txt are removed from text.txt");
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

        private static void RemoveWordsFromFile(
            string textFilePath,
            string wordsFilePath,
            string resultFilePath)
        {
            StreamReader textFileReader = new StreamReader(textFilePath);
            StreamReader wordsFileReader = new StreamReader(wordsFilePath);
            StreamWriter resultFileWriter = new StreamWriter(resultFilePath);

            List<string> words = new List<string>();
            string line = string.Empty;

            using (wordsFileReader)
            {
                line = wordsFileReader.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = wordsFileReader.ReadLine();
                }
            }

            line = string.Empty;

            using (textFileReader)
            using (resultFileWriter)
            {
                line = textFileReader.ReadLine();
                while (line != null)
                {
                    MatchCollection wordsInLine = Regex.Matches(line, @"\w+");

                    foreach (Match item in wordsInLine)
                    {
                        if (words.Any(x => x.Equals(item.Value, StringComparison.OrdinalIgnoreCase)))
                        {
                            line = line.Replace(item.Value, string.Empty);
                        }
                    }

                    resultFileWriter.WriteLine(line);
                    line = textFileReader.ReadLine();
                }
            }
        }
    }
}
