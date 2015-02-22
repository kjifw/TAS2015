// Problem 3. Decimal to hexadecimal
// * Write a program to convert decimal numbers to their hexadecimal representation.
// 
// _Examples:_
// 
// | decimal      | hexadecimal |
// |--------------|-------------|
// | 254          | FE          |
// | 6883         | 1AE3        |
// | 338583669684 | 4ED528CBB4  |

namespace _03.DecToHex
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class DecToHex
    {
        static void Main(string[] args)
        {
            const int HexSystemBase = 16;

            string inputStr;          
            long numberInDecimal;
            string numberInHex;

            inputStr = Console.ReadLine();
            numberInDecimal = Convert.ToInt64(inputStr);

            numberInHex = DecimalToHexiDecimal(numberInDecimal, HexSystemBase);

            Console.WriteLine(numberInHex);
        }

        private static string DecimalToHexiDecimal(long number, int numeralSystemBase)
        {
            List<long> listOfSymbols = new List<long>();
            long[] symbolsArr;
            StringBuilder output = new StringBuilder();

            if (number == 0)
            {
                output.Append("0");
            }

            while (number > 0)
            {
                long currentSymbol = number % numeralSystemBase;
                number /= numeralSystemBase;
                listOfSymbols.Add(currentSymbol);
            }

            symbolsArr = listOfSymbols.ToArray();

            for (int symbol = symbolsArr.Length - 1; symbol >= 0; symbol--)
            {
                switch (symbolsArr[symbol])
                {
                    case 10: output.Append("A");
                        break;
                    case 11: output.Append("B");
                        break;
                    case 12: output.Append("C");
                        break;
                    case 13: output.Append("D");
                        break;
                    case 14: output.Append("E");
                        break;
                    case 15: output.Append("F");
                        break;
                    default: output.AppendFormat("{0}", symbolsArr[symbol]);
                        break;
                }
            }

            return output.ToString();
        }
    }
}
