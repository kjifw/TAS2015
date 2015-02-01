// ### Problem 5. The Biggest of 3 Numbers
// * Write a program that finds the biggest of three numbers.
// 
// _Examples:_
// 
// | a    | b    | c    | biggest |
// |------|------|------|:-------:|
// | 5    | 2    | 2    | 5       |
// | -2   | -2   | 1    | 1       |
// | -2   | 4    | 3    | 4       |
// | 0    | -2.5 | 5    | 5       |
// | -0.1 | -0.5 | -1.1 | -0.1    |

namespace _05.TheBiggestOfThreeNumbers
{
    using System;

    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double biggestNumber;

            inputStr = Console.ReadLine();
            firstNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            secondNumber = Convert.ToDouble(inputStr);
            inputStr = Console.ReadLine();
            thirdNumber = Convert.ToDouble(inputStr);

            biggestNumber = firstNumber;

            if (secondNumber > biggestNumber)
            {
                biggestNumber = secondNumber;
            }

            if (thirdNumber > biggestNumber)
            {
                biggestNumber = thirdNumber;
            }

            Console.WriteLine(biggestNumber);

            // Simple Array Soulution
            //
            // string inputStr;
            // int arrayLength = 3;
            // double[] numbers = new double[arrayLength];
            //
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //    inputStr = Console.ReadLine();
            //    numbers[i] = Convert.ToDouble(inputStr);
            // }
            //
            // Array.Sort(numbers);
            //
            // Console.WriteLine(numbers[arrayLength - 1]);
        }
    }
}
