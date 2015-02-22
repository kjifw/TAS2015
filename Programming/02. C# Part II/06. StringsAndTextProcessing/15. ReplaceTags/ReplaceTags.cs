// Problem 15. Replace tags
// * Write a program that replaces in a HTML document given as string all the tags
//   <a href="…">…</a> with corresponding tags [URL=…]…[/URL].
// Example:
// input
// 
// <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose 
// a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//
// output
// <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
// Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace _15.ReplaceTags
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string inputStr;// = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string replacedTags;

            inputStr = Console.ReadLine();

            replacedTags = ReplaceAnchors(inputStr);

            Console.WriteLine(replacedTags);
        }

        private static string ReplaceAnchors(string htmlSource)
        {
            MatchCollection hrefAttributeList = Regex.Matches(htmlSource, @"<a href=""(?<hrefVlaue>)(.*?)"">");

            foreach (Match item in hrefAttributeList)
            {
                htmlSource = htmlSource.Replace(item.Groups[0].Value, "[URL=" + item.Groups[1].Value + "]");
            }

            htmlSource = htmlSource.Replace("</a>", "[/URL]");      

            return htmlSource;
        }
    }
}
