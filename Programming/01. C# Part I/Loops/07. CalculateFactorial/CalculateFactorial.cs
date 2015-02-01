// ### Problem 7. Calculate N! / (K! * (N-K)!)
// * In combinatorics, the number of ways to choose `k` different members out of a group of `n` 
//   different elements (also known as the number of combinations) is calculated by the following formula:
//   ![formula](https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// * Your task is to write a program that calculates `n! / (k! * (n-k)!)` for given 
//   `n` and `k` (1 < k < n < 100). Try to use only two loops.
// 
// _Examples:_
// 
// | n           | k | n! / (k! * (n-k)!) |
// |-------------|---|--------------------|
// | 3           | 2 | 3                  |
// | 4           | 2 | 6                  |
// | 10          | 6 | 210                |
// | 52          | 5 | 2598960            |

namespace _07.CalculateFactorial
{
    using System;
    using System.Numerics;

    class CalculateFactorial
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            int k;
            BigInteger factK = 1;
            BigInteger productKPlus1ToN = 1;
            BigInteger quotient = 0;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            k = Convert.ToInt32(inputStr);

            while ((k > 1 && k < n && n < 100) == false)
            {
                Console.Clear();
                Console.WriteLine("1 < k < n < 100");
                inputStr = Console.ReadLine();
                n = Convert.ToInt32(inputStr);
                inputStr = Console.ReadLine();
                k = Convert.ToInt32(inputStr);
            }

            for (int i = 1; i <= k; i++)
            {
                factK *= i;
            }

            for (int i = n - k + 1; i <= n; i++)
            {
                productKPlus1ToN *= i;
            }

            quotient = productKPlus1ToN / factK;

            Console.WriteLine("{0}", quotient);
        }
    }
}
