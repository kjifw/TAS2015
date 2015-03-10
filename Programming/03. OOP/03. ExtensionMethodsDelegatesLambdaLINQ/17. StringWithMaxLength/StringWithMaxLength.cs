// Problem 17.
// * Write a program to return the string with maximum length from an array of strings.
// * Use LINQ.

namespace _17.StringWithMaxLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StringWithMaxLength
    {
        static void Main(string[] args)
        {
            List<string> strList = FillList();

            var maxLengthWord = (from str in strList
                                 orderby str.Length ascending
                                 select str).Last();

            Console.WriteLine(maxLengthWord);
        }

        private static List<string> FillList()
        {
            List<string> strList = new List<string>();
            strList.Add("made");
            strList.Add("interval");
            strList.Add("desperation");
            strList.Add("defence");
            strList.Add("somehow");
            strList.Add("front");
            strList.Add("away");
            strList.Add("hopes");
            strList.Add("supporter");
            strList.Add("dangerous");

            return strList;
        }
    }
}
