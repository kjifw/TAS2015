// ### Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
// * Write a program that, for a given two integer numbers `n` and `x`, 
//   calculates the sum `S = 1 + 1!/x + 2!/x2 + … + n!/xn`.
// * Use only one loop. Print the result with `5` digits after the decimal point.
// 
// _Examples:_
// 
// | n           | x          | S       |
// |-------------|------------|---------|
// | 3           | 2          | 2.75000 |
// | 4           | 3          | 2.07407 |
// | 5           | -4         | 0.75781 |

namespace _05.CalculateSum
{
    using System;
    using System.Numerics;

    class CalculateSum
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            int x;
            double sum = 1.0;
            BigInteger factN = 1;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            x = Convert.ToInt32(inputStr);

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                sum += (double)factN / Math.Pow((double)x, i);
            }

            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
