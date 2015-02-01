// ### Problem 13. Binary to Decimal Number
// * Using loops write a program that converts a binary integer number to its decimal form.
// * The input is entered as string. The output should be a variable of type long.
// * Do not use the built-in .NET functionality.
// 
// _Examples:_
// 
// | binary                       | decimal   |
// |------------------------------|-----------|
// | 0                            | 0         |
// | 11                           | 3         |
// | 1010101010101011             | 43691     |
// | 1110000110000101100101000000 | 236476736 |

namespace _13.BinaryToDecimalNumber
{
    using System;

    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            const int BinarySystemBase = 2;

            string inputStr;
            char[] bits;
            long numberInDecimal = 0;

            inputStr = Console.ReadLine();
            bits = inputStr.ToCharArray();

            for (int power = 0, currentBit = bits.Length - 1; power < bits.Length; power++, currentBit--)
            {
                numberInDecimal += (long)((bits[currentBit] - '0') * Math.Pow(BinarySystemBase, power));
            }

            Console.WriteLine(numberInDecimal);
        }
    }
}
