// ### Problem 8. Square Root
// * Create a console application that calculates and prints the square root of the number `12345`.
// * Find in Internet “how to calculate square root in C#”.

namespace _08.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            int number = 12345;
            double sqrtNumber = 0.0;

            sqrtNumber = Math.Sqrt(number);

            Console.WriteLine(sqrtNumber);
        }
    }
}
