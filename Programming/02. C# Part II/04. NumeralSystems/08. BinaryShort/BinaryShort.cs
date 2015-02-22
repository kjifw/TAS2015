// Problem 8. Binary short
// * Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _08.BinaryShort
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class BinaryShort
    {
        static void Main(string[] args)
        {
            string inputStr;
            short number;
            string numberInBin;

            inputStr = Console.ReadLine();
            number = Convert.ToInt16(inputStr);

            numberInBin = ShortToBinary(number);
            
            Console.WriteLine(numberInBin);
        }

        private static string ShortToBinary(short number)
        {
            string numberInBinary = string.Empty;

            if (number < 0)
            {
                numberInBinary = "1" + DecimalToBinary(short.MaxValue + number + 1, 2);
            }
            else
            {
                numberInBinary = "0" + DecimalToBinary(number, 2);
            }

            return numberInBinary;
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

            return output.ToString().PadLeft(15, '0');
        }
    }
}
