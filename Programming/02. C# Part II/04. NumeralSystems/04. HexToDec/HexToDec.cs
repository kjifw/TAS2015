// Problem 4. Hexadecimal to decimal
// * Write a program to convert hexadecimal numbers to their decimal representation.
//
// _Examples:_
// 
// | hexadecimal       | decimal                      |
// |-------------------|------------------------------|
// | FE                | 254                          |
// | 1AE3              | 6883                         |
// | 4ED528CBB4        | 338583669684                 |

namespace _04.HexToDec
{
    using System;
    using System.Text.RegularExpressions;

    class HexToDec
    {
        static void Main(string[] args)
        {
            const int HexSystemBase = 16;

            string inputStr;

            long numberInDec;
            bool isValidHexNumber;
            string hexPattern = @"^[A-F0-9]+$";

            inputStr = Console.ReadLine();
            isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);

            while (!isValidHexNumber)
            {
                Console.Clear();
                Console.WriteLine("Hex numbers use - 0 to 9 and A to F");
                inputStr = Console.ReadLine();
                isValidHexNumber = Regex.IsMatch(inputStr, hexPattern);
            }

            numberInDec = HexidecimalToDecimal(inputStr, HexSystemBase);

            Console.WriteLine(numberInDec);
        }

        private static long HexidecimalToDecimal(string input, int numeralSystemBase)
        {
            char[] symbols;
            long numberInDecimal = 0;

            symbols = input.ToCharArray();

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

                numberInDecimal += (long)(currentSymbolAsNumber * Math.Pow(numeralSystemBase, power));
            }

            return numberInDecimal;
        }
    }
}
