// ### Problem 8. Digit as Word
// * Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// * Print `“not a digit”` in case of invalid input.
// * Use a switch statement.
// 
// _Examples:_
// 
// | d    | result      |
// |------|-------------|
// | 2    | two         |
// | 1    | one         |
// | 0    | zero        |
// | 5    | five        |
// | -0.1 | not a digit |
// | hi   | not a digit |
// | 9    | nine        |
// | 10   | not a digit |

namespace _08.DigitAsWord
{
    using System;

    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string inputStr;
            string digitAsWord;
            int digit;

            inputStr = Console.ReadLine();
            digit = Convert.ToInt32(inputStr);

            switch (digit)
            {
                case 0: digitAsWord = "zero"; break;
                case 1: digitAsWord = "one"; break;
                case 2: digitAsWord = "two"; break;
                case 3: digitAsWord = "three"; break;
                case 4: digitAsWord = "four"; break;
                case 5: digitAsWord = "five"; break;
                case 6: digitAsWord = "six"; break;
                case 7: digitAsWord = "seven"; break;
                case 8: digitAsWord = "eight"; break;
                case 9: digitAsWord = "nine"; break;
                default:
                    digitAsWord = "not a digit";
                    break;
            }

            Console.WriteLine(digitAsWord);
        }
    }
}
