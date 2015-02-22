// Problem 2. Binary to decimal
// * Write a program to convert binary numbers to their decimal representation.
//
// _Examples:_
// 
// | binary                       | decimal   |
// |------------------------------|-----------|
// | 0                            | 0         |
// | 11                           | 3         |
// | 1010101010101011             | 43691     |
// | 1110000110000101100101000000 | 236476736 |

namespace _02.BinToDec
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class BinToDec
    {
        static void Main(string[] args)
        {
            const int BinarySystemBase = 2;

            string pattern = @"^[0-1]+$";
            string inputStr;
            long numberInDecimal;

            inputStr = Console.ReadLine();
            bool isValidBinaryNumber = Regex.IsMatch(inputStr, pattern);

            while (!isValidBinaryNumber)
            {
                Console.Clear();
                Console.WriteLine("Binary numbers use - 0 and 1");
                inputStr = Console.ReadLine();
                isValidBinaryNumber = Regex.IsMatch(inputStr, pattern);
            }

            numberInDecimal = BinaryToDecimal(inputStr, BinarySystemBase);

            Console.WriteLine(numberInDecimal);
        }

        private static long BinaryToDecimal(string numberAsStr, int numeralSystemBase)
        {
            char[] bits;
            long numberInDecimal = 0;

            bits = numberAsStr.ToCharArray();

            for (int power = 0, currentBit = bits.Length - 1; power < bits.Length; power++, currentBit--)
            {
                numberInDecimal += (long)((bits[currentBit] - '0') * Math.Pow(numeralSystemBase, power));
            }

            return numberInDecimal;
        }
    }
}
