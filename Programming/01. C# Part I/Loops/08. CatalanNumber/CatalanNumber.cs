// ### Problem 8. Catalan Numbers
// * In combinatorics, the Catalan numbers are calculated by the following formula:
//   ![catalan-formula](https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png)
// * Write a program to calculate the `nth` Catalan number by given `n` (1 < n < 100). 
// 
// _Examples:_
// 
// | n           | Catalan(n) |
// |-------------|------------|
// | 0           | 1          |
// | 5           | 42         |
// | 10          | 16796      |
// | 15          | 9694845    |

namespace _08.CatalanNumber
{
    using System;
    using System.Numerics;

    class CatalanNumber
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            BigInteger factNPlus1 = 1;
            BigInteger productNPlus1To2N = 1; 
            BigInteger catalanNumber = 0;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            while (n < 0 || n > 100)
            {
                Console.Clear();
                Console.WriteLine("0 <= n <= 100");
                inputStr = Console.ReadLine();
                n = Convert.ToInt32(inputStr);
            }

            for (int i = n + 1; i <= 2 * n; i++)
            {
                productNPlus1To2N *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                factNPlus1 *= i;
            }

            catalanNumber = productNPlus1To2N / factNPlus1;

            Console.WriteLine("{0}", catalanNumber);
        }
    }
}
