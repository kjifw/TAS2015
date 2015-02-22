// Problem 1. Leap year
// * Write a program that reads a year from the console and checks whether it is a leap one.
// * Use System.DateTime.

namespace _01.LeapYears
{
    using System;

    class LeapYears
    {
        static void Main(string[] args)
        {
            string inputStr;
            int year;
            bool result;

            inputStr = Console.ReadLine();
            year = Convert.ToInt32(inputStr);

            result = LeapYear(year);

            Console.WriteLine(result);
        }

        private static bool LeapYear(int year)
        {
            bool isLeap = false;

            isLeap = DateTime.IsLeapYear(year);

            return isLeap;
        }
    }
}
