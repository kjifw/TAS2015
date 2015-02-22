// Problem 12. Parse URL
// * Write a program that parses an URL address given in the format: 7
//   [protocol]://[server]/[resource] and extracts from it the [protocol], 
//   [server] and [resource] elements.
// 
// Example:
//  URL 	                                                Information
//  http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
//                                                          [server] = telerikacademy.com
//                                                          [resource] = /Courses/Courses/Details/212

namespace _12.ParseURL
{
    using System;
    using System.Text;

    class ParseURL
    {
        static void Main(string[] args)
        {
            string inputStr;// = "http://telerikacademy.com/Courses/Courses/Details/212";
            string urlInfo;

            inputStr = Console.ReadLine();

            urlInfo = ExtractURLInfromation(inputStr);

            Console.WriteLine(urlInfo);
        }

        private static string ExtractURLInfromation(string url)
        {
            bool isValidUrl = Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
            StringBuilder result = new StringBuilder();

            if (isValidUrl)
            {
                Uri currentUrl = new Uri(url);
                result.AppendLine("[protocol] = " + currentUrl.Scheme);
                result.AppendLine("[server] = " + currentUrl.Host);
                result.AppendLine("[resource] = " + currentUrl.LocalPath);
            }
            else
            {
                result.Append("invalid url");
            }

            return result.ToString().Trim();
        }
    }
}
