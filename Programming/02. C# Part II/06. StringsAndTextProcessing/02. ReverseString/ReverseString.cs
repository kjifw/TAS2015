// Problem 2. Reverse string
// * Write a program that reads a string, reverses it and prints the result at the console.
// 
// Example:
// input 	output
// sample 	elpmas

namespace _02.ReverseString
{
    using System;

    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputStr;
            string reversed;

            inputStr = Console.ReadLine();

            reversed = Reverse(inputStr);

            Console.WriteLine(reversed);
        }

        private static string Reverse(string str)
        {
            string reversed = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
