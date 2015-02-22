// Problem 1. Decimal to binary
// * Write a program to convert decimal numbers to their binary representation.
//
// _Examples:_
// 
// | decimal           | binary                       |
// |-------------------|------------------------------|
// | 0                 | 0                            |
// | 3                 | 11                           |
// | 43691             | 1010101010101011             |
// | 236476736         | 1110000110000101100101000000 |

namespace _01.DecToBin
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class DecToBin
    {
        static void Main(string[] args)
        {
            const int BinarySystemBase = 2;

            string inputStr;
            long numberInDecimal;
            string result;

            inputStr = Console.ReadLine();
            numberInDecimal = Convert.ToInt64(inputStr);

            result = DecimalToBinary(numberInDecimal, BinarySystemBase);

            Console.WriteLine(result);
        }

        private static string DecimalToBinary(long number, int numeralSystemBase)
        {
            List<long> listOfBits = new List<long>();
            long[] bitArr;
            StringBuilder output = new StringBuilder();

            if (number == 0)
            {
                output.Append("0");
            }

            while (number > 0)
            {
                long currentBit = number % numeralSystemBase;
                number /= numeralSystemBase;
                listOfBits.Add(currentBit);
            }

            bitArr = listOfBits.ToArray();

            for (int i = bitArr.Length - 1; i >= 0; i--)
            {
                output.AppendFormat("{0}", bitArr[i]);
            }

            return output.ToString();
        }
    }
}
