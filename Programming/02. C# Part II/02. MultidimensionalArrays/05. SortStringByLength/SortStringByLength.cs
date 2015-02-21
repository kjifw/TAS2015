// ### Problem 5. Sort by string length
// * You are given an array of strings. Write a method that sorts the array
//   by the length of its elements (the number of characters composing them).

namespace _05.SortStringByLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortStringByLength
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();
            string inputStr;

            inputStr = Console.ReadLine();

            while (inputStr != string.Empty)
            {
                listOfStrings.Add(inputStr);
                inputStr = Console.ReadLine();
            }

            // can be moved in seperate method
            List<string> orderedByLength = listOfStrings.OrderBy(x => x.Length).ToList();

            foreach (var item in orderedByLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}
