// ### Problem 7. Sum of 5 Numbers
// * Write a program that enters 5 numbers (given in a single line, separated by a space), 
//   calculates and prints their sum.
// 
// _Examples:_
// 
// |      numbers      |  sum  |
// |-------------------|-------|
// | 1 2 3 4 5         | 15    |
// | 10 10 10 10 10    | 50    |
// | 1.5 3.14 8.2 -1 0 | 11.84 |

namespace _07.SumOfFiveNumbers
{
    using System;

    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            string[] numbersStr;
            string inputStr;
            double sum = 0;

            Console.Write("numbers: ");
            inputStr = Console.ReadLine();

            numbersStr = inputStr.Split(' ');

            for (int i = 0; i < numbersStr.Length; i++)
            {
                sum += Convert.ToDouble(numbersStr[i]);
            }

            Console.WriteLine("sum: {0}", sum);
        }
    }
}
