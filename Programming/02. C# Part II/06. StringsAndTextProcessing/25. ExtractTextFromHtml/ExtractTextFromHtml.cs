// Problem 25. Extract text from HTML
// * Write a program that extracts from given HTML file its title 
//   (if available), and its body text without the HTML tags.
// 
// Example input:
// 
// <html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
// </html>
// 
// Output:
// 
// Title: News
// 
// Text: Telerik Academy aims to provide free real-world practical training 
// for young people who want to turn into skilful .NET software engineers.

namespace _25.ExtractTextFromHtml
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractTextFromHtml
    {
        static void Main(string[] args)
        {
//            string inputStr = @"
//            <html>
//                <head>
//                    <title>News</title>
//                </head>
//                <body>
//                    <p><a href=""http://academy.telerik.com"">Telerik
//                        Academy</a> aims to provide free real-world practical
//                        training for young people who want to turn into
//                        skilful .NET software engineers.
//                    </p>
//                </body>
//            </html>";

            string inputStr = Console.ReadLine();

            string extractedText = ExtractTexFromHtmlCode(inputStr);

            Console.WriteLine(extractedText);
        }

        private static string ExtractTexFromHtmlCode(string htmlSource)
        {
            MatchCollection htmlTags = Regex.Matches(htmlSource, @"(.*?)(<.*?>)(.*?)");
            
            foreach (Match item in htmlTags)
            {
                if (item.Groups[2].Value == "<title>")
                {
                    htmlSource = htmlSource.Replace(item.Groups[2].Value, "Title: ");
                }
                else if (item.Groups[2].Value == "<p>")
                {
                    htmlSource = htmlSource.Replace(item.Groups[2].Value, "Text: ");
                }
                else
                {
                    htmlSource = htmlSource.Replace(item.Groups[2].Value, string.Empty);
                }
            }
            
            htmlSource = Regex.Replace(htmlSource, @"\s+", " ");
            htmlSource = htmlSource.Replace("Text: ", "\nText: ");
            return htmlSource.Trim();
        }
    }
}
