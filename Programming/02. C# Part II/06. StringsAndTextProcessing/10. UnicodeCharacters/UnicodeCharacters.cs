// Problem 10. Unicode characters
// * Write a program that converts a string to a sequence of C# Unicode character literals.
// * Use format strings.
// 
// Example:
// input 	output
// Hi! 	    \u0048\u0069\u0021

namespace _10.UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string inputStr;
            string stringInUnicode;

            inputStr = Console.ReadLine();

            stringInUnicode = ConvertToUnicode(inputStr);

            Console.WriteLine(stringInUnicode);
        }

        private static string ConvertToUnicode(string str)
        {
            string reslut = string.Empty;
           
            foreach (var item in str)
            {
                reslut += string.Format("\\u00{0:X}", (int)item);
            }
            
            return reslut;
        }
    }
}
