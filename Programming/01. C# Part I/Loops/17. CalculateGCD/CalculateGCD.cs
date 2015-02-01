// ### Problem 17.* Calculate GCD
// * Write a program that calculates the greatest common divisor (GCD) of given two integers `a` and `b`.
// * Use the Euclidean algorithm (find it in Internet).
// 
// _Examples:_
// 
// | a  | b   | GCD(a, b) |
// |----|-----|-----------|
// | 3  | 2   | 1         |
// | 60 | 40  | 20        |
// | 5  | -15 | 5         |

namespace _17.CalculateGCD
{
    using System;

    class CalculateGCD
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string inputStr;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);

            while (secondNumber != 0)
            {
                double reminder = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = reminder;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
