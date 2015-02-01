// ### Problem 1. Sum of 3 Numbers
// * Write a program that reads 3 real numbers from the console and prints their sum.
// 
// _Examples:_
// 
// |      a      |   b  |   c  |  sum |
// |:-----------:|:----:|:----:|:----:|
// | 3           | 4    | 11   | 18   |
// | -2          | 0    | 3    | 1    |
// | 5.5         | 4.5  | 20.1 | 30.1 |

namespace _01.SumOfThreeNumbers
{
    using System;

    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double sum;

            Console.Write("a: ");
            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            Console.Write("b: ");
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);
            Console.Write("c: ");
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToDouble(inputStr);

            sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("sum: {0}", sum);
        }
    }
}
