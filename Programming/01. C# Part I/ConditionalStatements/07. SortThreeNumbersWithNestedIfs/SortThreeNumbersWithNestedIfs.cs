// ### Problem 7. Sort 3 Numbers with Nested Ifs
// * Write a program that enters 3 real numbers and prints them sorted in descending order.
// * Use nested `if` statements.
// 
// _Note: Don’t use arrays and the built-in sorting functionality._
// 
// _Examples:_
// 
// | a    | b    | c    |     result     |
// |------|------|------|----------------|
// | 5    | 1    | 2    | 5 2 1          |
// | -2   | -2   | 1    | 1 -2 -2        |
// | -2   | 4    | 3    | 4 3 -2         |
// | 0    | -2.5 | 5    | 5 0 -2.5       |
// | -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
// | 10   | 20   | 30   | 30 20 10       |
// | 1    | 1    | 1    | 1 1 1          |

namespace _07.SortThreeNumbersWithNestedIfs
{
    using System;

    class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            string result;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToDouble(inputStr);

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    result = firstNumber + " ";

                    if (secondNumber > thirdNumber)
                    {
                        result += secondNumber + " " + thirdNumber;
                    }
                    else
                    {
                        result += thirdNumber + " " + secondNumber;
                    }
                }
                else
                {
                    result = thirdNumber + " " + firstNumber + " " + secondNumber;
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    result = secondNumber + " ";

                    if (firstNumber > thirdNumber)
                    {
                        result += firstNumber + " " + thirdNumber;
                    }
                    else
                    {
                        result += thirdNumber + " " + firstNumber;
                    }
                }
                else
                {
                    result = thirdNumber + " " + secondNumber + " " + firstNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}
