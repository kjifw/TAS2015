// ### Problem 15. Hexadecimal to Decimal Number
// * Using loops write a program that converts a hexadecimal integer number to its decimal form.
// * The input is entered as string. The output should be a variable of type long.
// * Do not use the built-in .NET functionality.
// 
// _Examples:_
// 
// | hexadecimal       | decimal                      |
// |-------------------|------------------------------|
// | FE                | 254                          |
// | 1AE3              | 6883                         |
// | 4ED528CBB4        | 338583669684                 |

namespace _15.HexToDecimalNumber
{
    using System;
    using System.Text.RegularExpressions;

    class HexToDecimalNumber
    {
        static void Main(string[] args)
        {
            const int HexSystemBase = 16;

            string inputStr;
            char[] symbols;
            long numberInDecimal = 0;
            bool isValidHexNumber;
            string hexPattern = @"^[A-F0-9]+$";

            inputStr = Console.ReadLine();

            isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);

            while (isValidHexNumber == false)
            {
                Console.Clear();
                Console.WriteLine("Hex numbers use - 0 to 9 and A to F");
                inputStr = Console.ReadLine();

                isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);
            }

            symbols = inputStr.ToCharArray();

            for (int power = 0, currentSymbol = symbols.Length - 1; power < symbols.Length; power++, currentSymbol--)
            {
                long currentSymbolAsNumber;

                switch (symbols[currentSymbol])
                {
                    case 'A': currentSymbolAsNumber = 10; break;
                    case 'B': currentSymbolAsNumber = 11; break;
                    case 'C': currentSymbolAsNumber = 12; break;
                    case 'D': currentSymbolAsNumber = 13; break;
                    case 'E': currentSymbolAsNumber = 14; break;
                    case 'F': currentSymbolAsNumber = 15; break;
                    default:
                        currentSymbolAsNumber = symbols[currentSymbol] - '0';
                        break;
                }

                numberInDecimal += (long)(currentSymbolAsNumber * Math.Pow(HexSystemBase, power));
            }

            Console.WriteLine(numberInDecimal);
        }
    }
}
