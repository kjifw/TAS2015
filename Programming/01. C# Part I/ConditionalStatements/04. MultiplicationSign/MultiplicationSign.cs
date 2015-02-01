// ### Problem 4. Multiplication Sign
// * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// * Use a sequence of `if` operators.
// 
// _Examples:_
// 
// | a    | b    | c    | result |
// |------|------|------|:------:|
// | 5    | 2    | 2    | +      |
// | -2   | -2   | 1    | +      |
// | -2   | 4    | 3    | -      |
// | 0    | -2.5 | 4    | 0      |
// | -1   | -0.5 | -5.1 | -      |

namespace _04.MultiplicationSign
{
    using System;

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            string multiplicationResult;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToDouble(inputStr);

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                multiplicationResult = "0";
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                multiplicationResult = "-";
            }
            else if ((firstNumber < 0 && secondNumber < 0) ||
                (firstNumber < 0 && thirdNumber < 0) ||
                (secondNumber < 0 && thirdNumber < 0))
            {
                multiplicationResult = "+";
            }
            else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                multiplicationResult = "-";
            }
            else
            {
                multiplicationResult = "+";
            }

            Console.WriteLine(multiplicationResult);
        }
    }
}
