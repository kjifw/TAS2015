// ### Problem 6. The Biggest of Five Numbers
// * Write a program that finds the biggest of five numbers by using only five if statements.
// 
// _Examples:_
// 
// | a    | b    | c    |  d |   e  | biggest |
// |------|------|------|:--:|:----:|---------|
// | 5    | 2    | 2    | 4  | 1    | 5       |
// | -2   | -22  | 1    | 0  | 0    | 1       |
// | -2   | 4    | 3    | 2  | 0    | 4       |
// | 0    | -2.5 | 0    | 5  | 5    | 5       |
// | -3   | -0.5 | -1.1 | -2 | -0.1 | -0.1    |

namespace _06.TheBiggestOfFiveNumbers
{
    using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double fourthNumber;
            double fifthNumber;
            double biggestNumber;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            fourthNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            fifthNumber = Convert.ToDouble(inputStr);

            biggestNumber = firstNumber;

            if (secondNumber > biggestNumber)
            {
                biggestNumber = secondNumber;
            }

            if (thirdNumber > biggestNumber)
            {
                biggestNumber = thirdNumber;
            }

            if (fourthNumber > biggestNumber)
            {
                biggestNumber = fourthNumber;
            }

            if (fifthNumber > biggestNumber)
            {
                biggestNumber = fifthNumber;
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
