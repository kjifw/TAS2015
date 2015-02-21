// Problem 3. English digit
// * Write a method that returns the last digit of given integer as an English word.
// 
// Examples:
// input 	output
// 512 	    two
// 1024 	four
// 12309 	nine

namespace _03.EnglishDigit
{
    using System;

    class EnglishDigit
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            string digitAsString;

            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            digitAsString = DigitInEnglish(number);

            Console.WriteLine(digitAsString);
        }

        private static string DigitInEnglish(int num)
        {
            string digitAsString = string.Empty;
            int digit = num % 10;

            switch (digit)
            {
                case 0: digitAsString = "zero"; break;
                case 1: digitAsString = "one"; break;
                case 2: digitAsString = "two"; break;
                case 3: digitAsString = "three"; break;
                case 4: digitAsString = "four"; break;
                case 5: digitAsString = "five"; break;
                case 6: digitAsString = "six"; break;
                case 7: digitAsString = "seven"; break;
                case 8: digitAsString = "eight"; break;
                case 9: digitAsString = "nine"; break;
            }

            return digitAsString;
        }
    }
}
