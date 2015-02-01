// ### Problem 18.* Trailing Zeroes in N!
// * Write a program that calculates with how many zeroes the factorial of a given number `n` has at its end.
// * Your program should work well for very big numbers, e.g. `n=100000`.
// 
// _Examples:_
// 
// | n      | trailing zeroes of n! | explaination        |
// |--------|-----------------------|---------------------|
// | 10     | 2                     | 3628800             |
// | 20     | 4                     | 2432902008176640000 |
// | 100000 | 24999                 | think why           |

namespace _18.TrailingZeroes
{
    using System;

    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            const int NumberFive = 5;

            string inputStr;
            int number;
            int trailingZeros = 0;
            int powerOfFive = 0;
            int denom = 0;

            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            while (denom <= number)
            {
                powerOfFive++;
                denom = Convert.ToInt32(Math.Pow(NumberFive, powerOfFive));
                trailingZeros += number / denom; 
            }


            Console.WriteLine(trailingZeros);
        }
    }
}
