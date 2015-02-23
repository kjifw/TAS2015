// Problem 1. Square root
// * Write a program that reads an integer number and calculates and prints its square root.
//    * If the number is invalid or negative, print Invalid number.
//    * In all cases finally print Good bye.
// * Use try-catch-finally block.

namespace _01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            double numberSqrt;

            try
            {
                inputStr = Console.ReadLine();
                number = Convert.ToInt32(inputStr);

                if (number < 0)
                {
                    throw new ArgumentException();
                }

                numberSqrt = Math.Sqrt((double)number);
                
                Console.WriteLine(numberSqrt);
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("invalid number");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("invalid number");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
