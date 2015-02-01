// ### Problem 4. Number Comparer
// * Write a program that gets two numbers from the console and prints the greater of them.
// * Try to implement this without if statements.
// 
// _Examples:_
// 
// |  a  |  b  | greater |
// |:---:|:---:|:-------:|
// | 5   | 6   | 6       |
// | 10  | 5   | 10      |
// | 0   | 0   | 0       |
// | -5  | -2  | -2      |
// | 1.5 | 1.6 | 1.6     |

namespace _04.NumberComparer
{
    using System;

    class NumberComparer
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double biggerNumber;

            Console.Write("first number: ");
            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            Console.Write("second number: ");
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);

            biggerNumber = firstNumber >= secondNumber ? firstNumber : secondNumber;

            Console.WriteLine("bigger number is: {0}", biggerNumber);
        }
    }
}
