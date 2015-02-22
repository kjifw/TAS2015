// Problem 5. Parse tags
//   * You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//     The tags cannot be nested.
// 
// Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
// 
// The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.ParseTags
{
    using System;
    using System.Text.RegularExpressions;

    class ParseTags
    {
        static void Main(string[] args)
        {
            string inputStr;
            string parsedTags;

            inputStr = Console.ReadLine();

            parsedTags = ParseInputTags(inputStr);

            Console.WriteLine(parsedTags);
        }

        private static string ParseInputTags(string str)
        {
            str = Regex.Replace(str, "<upcase>(.*?)</upcase>", x => x.ToString().ToUpper());
            str = str.Replace("<UPCASE>", string.Empty);
            str = str.Replace("</UPCASE>", string.Empty);

            return str;
        }
    }
}
