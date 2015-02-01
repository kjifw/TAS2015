// ### Problem 5. Formatting Numbers
// * Write a program that reads 3 numbers:
//    * integer `a` (0 <= a <= 500)
//    * floating-point `b`
//    * floating-point `c` 
// * The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    * The number `a` should be printed in hexadecimal, left aligned
//    * Then the number `a` should be printed in binary form, padded with zeroes
//    * The number `b` should be printed with 2 digits after the decimal point, right aligned
//    * The number c should be printed with 3 digits after the decimal point, left aligned. 
//
// _Examples:_
// 
// |  a  |    b    |    c    |                      result                    |
// |:---:|:-------:|:-------:|------------------------------------------------|
// | 254 | 11.6    | 0.5     | `FE        |0011111110|     11.60|0.500     |` |
// | 499 | -0.5559 | 10000   | `1F3       |0111110011|     -0.56|10000     |` |
// | 0   | 3       | -0.1234 | `0         |0000000000|         3|-0.123    |` |

namespace _05.FormattingNumbers
{
    using System;

    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            int numberA;
            double numberB;
            double numberC;
            string numberAHex;
            string numberABin;

            Console.Write("0 <= integer <= 500: ");
            inputStr = Console.ReadLine();
            numberA = Convert.ToInt32(inputStr);

            while (numberA < 0 || numberA > 500)
            {
                Console.Clear();
                Console.Write("0 <= integer <= 500: ");
                inputStr = Console.ReadLine();
                numberA = Convert.ToInt32(inputStr);
            }

            Console.Write("first double: ");
            inputStr = Console.ReadLine();
            numberB = Convert.ToDouble(inputStr);
            Console.Write("second double: ");
            inputStr = Console.ReadLine();
            numberC = Convert.ToDouble(inputStr);

            numberAHex = Convert.ToString(numberA, 16);
            numberABin = Convert.ToString(numberA, 2);

            Console.WriteLine("{0, -10}|{1}|{2, 10:0.00}|{3, -10:0.000}|",
                numberAHex.ToUpper(), numberABin.PadLeft(10, '0'), numberB, numberC);
        }
    }
}
