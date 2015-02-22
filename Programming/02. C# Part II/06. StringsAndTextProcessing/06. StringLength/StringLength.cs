// Problem 6. String length
// * Write a program that reads from the console a string of maximum 20 characters. 
//   If the length of the string is less than 20, the rest of the characters should be filled with *.
// * Print the result string into the console.

namespace _06.StringLength
{
    using System;

    class StringLength
    {
        static void Main(string[] args)
        {
            string str;

            str = ReadString();

            Console.WriteLine(str);
        }

        private static string ReadString()
        {
            string inputStr;
            int strLength = 20;

            inputStr = Console.ReadLine();

            while (inputStr.Length > strLength)
            {
                Console.Clear();
                Console.Write("string must be max 20 chars: ");
                inputStr = Console.ReadLine();
            }

            inputStr = inputStr + new string('*', strLength - inputStr.Length);

            return inputStr;
        }
    }
}
