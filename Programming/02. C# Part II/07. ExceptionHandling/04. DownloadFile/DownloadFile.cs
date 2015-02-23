// Problem 4. Download file
// * Write a program that downloads a file from Internet (e.g. Ninja image) 
//   and stores it the current directory.
// * Find in Google how to download files in C#.
// * Be sure to catch all exceptions and to free any used resources in the 
//   finally block.

namespace _04.DownloadFile
{
    using System;
    using System.Net;

    class DownloadFile
    {
        static void Main(string[] args)
        {
            string filePath = "..//..//image.png";
            string fileUrl = "http://telerikacademy.com/Content/Images/news-img01.png";

            try
            {
                DownloadFileFromUrl(fileUrl, filePath);

                Console.WriteLine("Download complete!");
                Console.WriteLine("Please check project directory for the file.");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Null reference passed to method.");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("Method or functionality not supported.");
            }
        }

        private static void DownloadFileFromUrl(string fileUrl, string filePath)
        {
            WebClient client = new WebClient();

            using (client)
            {
                client.DownloadFile(fileUrl, filePath);
            }
        }
    }
}
