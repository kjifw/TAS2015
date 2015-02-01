// ### Problem 6. Calculate N! / K!
// * Write a program that calculates `n! / k!` for given `n` and `k` (1 < k < n < 100).
// * Use only one loop.
// 
// _Examples:_
// 
// | n           | k          | n! / k! |
// |-------------|------------|---------|
// | 5           | 2          | 60      |
// | 6           | 5          | 6       |
// | 8           | 3          | 6720    |

namespace _06.Factorial
{
    using System;
    using System.Numerics;

    class Factorial
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            int k;
            BigInteger productKplus1ToN = 1;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            k = Convert.ToInt32(inputStr);

            while ((k > 1 && n > k && n < 100) == false)
            {
                Console.Clear();
                Console.WriteLine("1 < k < n < 100");
                inputStr = Console.ReadLine();
                n = Convert.ToInt32(inputStr);
                inputStr = Console.ReadLine();
                k = Convert.ToInt32(inputStr); 
            }
            
            for (int i = k + 1; i <= n; i++)
            {
                productKplus1ToN *= i;
            }

            Console.WriteLine("{0}", productKplus1ToN);

        }
    }
}
