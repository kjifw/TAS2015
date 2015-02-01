// ### Problem 14. Decimal to Binary Number
// * Using loops write a program that converts an integer number to its binary representation.
// * The input is entered as long. The output should be a variable of type string.
// * Do not use the built-in .NET functionality.
// 
// _Examples:_
// 
// | decimal           | binary                       |
// |-------------------|------------------------------|
// | 0                 | 0                            |
// | 3                 | 11                           |
// | 43691             | 1010101010101011             |
// | 236476736         | 1110000110000101100101000000 |

namespace _14.DecimalToBinaryNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class DecimalToBinaryNumbers
    {
        static void Main(string[] args)
        {
            const int BinarySystemBase = 2;

            string inputStr;
            List<long> listOfBits = new List<long>();
            long[] bitArr;
            long numberInDecimal;
            StringBuilder output = new StringBuilder();

            inputStr = Console.ReadLine();
            numberInDecimal = Convert.ToInt64(inputStr);

            if (numberInDecimal == 0)
            {
                output.Append("0");
            }

            while (numberInDecimal > 0)
            {
                long currentBit = numberInDecimal % BinarySystemBase;
                numberInDecimal /= BinarySystemBase;
                listOfBits.Add(currentBit);
            }

            bitArr = listOfBits.ToArray();

            for (int i = bitArr.Length - 1; i >= 0; i--)
            {
                output.AppendFormat("{0}", bitArr[i]);
            }

            Console.WriteLine(output.ToString());
        }
    }
}
