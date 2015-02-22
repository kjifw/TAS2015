// Problem 11. Format number
// * Write a program that reads a number and prints it as a decimal number, 
//   hexadecimal number, percentage and in scientific notation.
// * Format the output aligned right in 15 symbols.

namespace _11.FormatNumber
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Text.RegularExpressions;

    class FormatNumber
    {
        static void Main(string[] args)
        {
            string numberInAllFormats;
            string numberAsStr;

            numberAsStr = Console.ReadLine();

            numberInAllFormats = NumberInFormats(numberAsStr);

            Console.WriteLine(numberInAllFormats);
        }

        private static string NumberInFormats(string number)
        {
            StringBuilder result = new StringBuilder();
            bool isValidNumber = Regex.IsMatch(number, @"^[0-9]+$");

            if (isValidNumber)
            {
                long num = Convert.ToInt64(number);

                result.AppendFormat("{0, 15}\n", num);
                result.AppendFormat("{0, 15:X}\n", num);
                result.AppendFormat("{0, 15:P2}\n", (double)num / 100);
                result.AppendFormat("{0, 15:0.###E+0}", num);
            }
            else
            {
                result.Append("invalid number");
            }

            return result.ToString();
        }
    }
}
