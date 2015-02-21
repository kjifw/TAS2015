// Problem 7. Reverse number
// * Write a method that reverses the digits of given decimal number.
// 
// Example:
// input 	output
// 256 	652

namespace _07.ReverseNumber
{
    using System;

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string inputStr;
            string reversedStr;

            inputStr = Console.ReadLine();

            reversedStr = Reverse(inputStr);

            Console.WriteLine(reversedStr);
        }

        private static string Reverse(string str)
        {
            string revStr = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            return revStr;
        }
    }
}
