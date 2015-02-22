// Problem 7. One system to any other
// * Write a program to convert from any numeral system of 
//   given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

namespace _07.OneSystemToAnyOther
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class OneSystemToAnyOther
    {
        static void Main(string[] args)
        {
            string inputStr;
            string result;
            int firstSystemBase;
            int secondSystemBase;

            Console.Write("input first system base: ");
            inputStr = Console.ReadLine();
            firstSystemBase = Convert.ToInt32(inputStr);
            Console.Write("input second system base: ");
            inputStr = Console.ReadLine();
            secondSystemBase = Convert.ToInt32(inputStr);

            while (firstSystemBase < 2 
                || firstSystemBase > 16 
                || secondSystemBase < 2
                || secondSystemBase > 16)
            {
                Console.Clear();
                Console.WriteLine("systems bases must be between 2 and 16");
                Console.Write("input first system base: ");
                inputStr = Console.ReadLine();
                firstSystemBase = Convert.ToInt32(inputStr);
                Console.Write("input second system base: ");
                inputStr = Console.ReadLine();
                secondSystemBase = Convert.ToInt32(inputStr);
            }

            Console.WriteLine("input number in {0} to be converted to number in {1}", 
                firstSystemBase, 
                secondSystemBase);

            inputStr = Console.ReadLine();

            result = AnyToAny(inputStr, firstSystemBase, secondSystemBase);

            Console.WriteLine("number in system with base {0}: {1}", firstSystemBase, inputStr);
            Console.WriteLine("number in system with base {0}: {1}", secondSystemBase, result);
        }

        private static string AnyToAny(string number, int firstSystemBase, int secondSystemBase)
        {
            string numberInSecondSystem = string.Empty;
            long numberInDecimal;

            numberInDecimal = AnyToDecimal(number, firstSystemBase);

            numberInSecondSystem = DecimalToAny(numberInDecimal, secondSystemBase);

            return numberInSecondSystem;
        }

        private static long AnyToDecimal(string input, int numeralSystemBase)
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

        private static string DecimalToAny(long number, int numeralSystemBase)
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
