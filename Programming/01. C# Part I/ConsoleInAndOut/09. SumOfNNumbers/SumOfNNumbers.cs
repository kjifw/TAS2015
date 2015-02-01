// ### Problem 9. Sum of n Numbers
// * Write a program that enters a number `n` and after that enters 
//   more `n` numbers and calculates and prints their `sum`.
// _Note: You may need to use a for-loop._
// 
// _Examples:_
// 
// | numbers | sum |
// |---------|-----|
// | 3       | 90  |
// | 20      |     |
// | 60      |     |
// | 10      |     |
// | 5       | 6.5 |
// | 2       |     |
// | -1      |     |
// | -0.5    |     |
// | 4       |     |
// | 2       |     |
// | 1       | 1   |
// | 1       |     |

namespace _09.SumOfNNumbers
{
    using System;

    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            double sum = 0.0;

            Console.Write("n: ");
            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int i = 0; i < n; i++)
            {
                inputStr = Console.ReadLine();
                sum += Convert.ToDouble(inputStr);
            }

            Console.WriteLine("sum: {0}", sum);
        }
    }
}
