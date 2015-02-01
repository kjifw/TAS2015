// ### Problem 3. Min, Max, Sum and Average of N Numbers
// * Write a program that reads from the console a sequence of `n` integer numbers 
//   and returns the minimal, the maximal number, the sum and the average of all numbers 
//   (displayed with 2 digits after the decimal point).
// * The input starts by the number `n` (alone in a line) followed by `n` lines, each holding an integer number.
// * The output is like in the examples below.
// 
// _Example 1:_              _Example 2:_
// 
// | input | output     |    | input | output     |
// |-------|------------|    |-------|------------|
// | 3     | min = 1    |    | 2     | min = -1   |
// | 2     | max = 5    |    | -1    | max = 4    |
// | 5     | sum = 8    |    | 4     | sum = 3    |
// | 1     | avg = 2.67 |    |       | avg = 1.50 |

namespace _03.MinMaxSumAverageOfNumbers
{
    using System;

    class MinMaxSumAverageOfNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            int min = int.MaxValue;
            int max = int.MinValue;
            long sum = 0;
            double average;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int i = 0; i < n; i++)
            {
                int currentNumber;
                inputStr = Console.ReadLine();
                currentNumber = Convert.ToInt32(inputStr);

                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                if (currentNumber > max)
                {
                    max = currentNumber;
                }

                sum += currentNumber;
            }

            average = (double)sum / n;

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:0.00}", average);
        }
    }
}
