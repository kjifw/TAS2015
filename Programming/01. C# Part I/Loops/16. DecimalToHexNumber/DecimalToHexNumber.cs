// ### Problem 16. Decimal to Hexadecimal Number
// * Using loops write a program that converts an integer number to its hexadecimal representation.
// * The input is entered as long. The output should be a variable of type string.
// * Do not use the built-in .NET functionality.
// 
// _Examples:_
// 
// | decimal      | hexadecimal |
// |--------------|-------------|
// | 254          | FE          |
// | 6883         | 1AE3        |
// | 338583669684 | 4ED528CBB4  |

namespace _16.DecimalToHexNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class DecimalToHexNumber
    {
        static void Main(string[] args)
        {
            const int HexSystemBase = 16;

            string inputStr;
            List<long> listOfSymbols = new List<long>();
            long[] symbolsArr;
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
                long currentSymbol = numberInDecimal % HexSystemBase;
                numberInDecimal /= HexSystemBase;
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

            Console.WriteLine(output.ToString());
        }
    }
}
