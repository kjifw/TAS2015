// ### Problem 3. Read file contents
// * Write a program that enters file name along with its full file path 
//   (e.g. `C:\WINDOWS\win.ini`), reads its contents and prints it on the console.
// * Find in MSDN how to use `System.IO.File.ReadAllText(…)`.
// * Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.ReadFileContents
{
    using System;
    using System.IO;
    using System.Security;

    class ReadFileContents
    {
        static void Main(string[] args)
        {
            string path;
            string fileContents;
     
            try
            {
                path = "..//..//file.txt";
                fileContents = ReadFile(path);
                Console.WriteLine(fileContents);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is empty");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path is not valid");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path or file name is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Wrong directory");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found");
            }
            catch (IOException)
            {
                Console.WriteLine("Input/Output error");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Functionality not supported");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Security error");
            }
        }

        private static string ReadFile(string path)
        {
            string fileContents = string.Empty;

            fileContents = File.ReadAllText(path);

            return fileContents;
        }
    }
}
