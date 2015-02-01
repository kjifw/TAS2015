// ### Problem 8. Prime Number Check
// * Write an expression that checks if given positive integer number n (n = 100) is prime 
//   (i.e. it is divisible without remainder only to itself and 1).
// 
// _Examples:_
// 
// |  n | Prime? |
// |:--:|:------:|
// | 1  | false  |
// | 2  | true   |
// | 3  | true   |
// | 4  | false  |
// | 9  | false  |
// | 97 | true   |
// | 51 | false  |
// | -3 | false  |
// | 0  | false  |

namespace _08.PrimeNumberCheck
{
    using System;

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            double numberSqrt;
            bool isPrime = true;

            Console.Write("input number: ");
            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);
            numberSqrt = Math.Sqrt(Math.Abs(number));

            if (number < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Convert.ToInt32(numberSqrt); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("prime: {0}", isPrime);
        }
    }
}
