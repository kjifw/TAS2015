// Problem 4. Sub-string in text
// * Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
// 
// Example:
// 
// The target sub-string is in
// 
//  The text is as follows: 
//  We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
// The result is: 9

namespace _04.SubStringInText
{
    using System;
    using System.Text.RegularExpressions;

    class SubStringInText
    {
        static void Main(string[] args)
        {
            string inputStr;
            string subStr;
            int subStrCount;

            inputStr = Console.ReadLine();

            subStr = Console.ReadLine();

            subStrCount = SubstringCount(inputStr, subStr);

            Console.WriteLine(subStrCount);
        }

        private static int SubstringCount(string str, string subStr)
        {
            int count = 0;

            count = Regex.Matches(str, subStr, RegexOptions.IgnoreCase).Count;

            return count;
        }
    }
}
