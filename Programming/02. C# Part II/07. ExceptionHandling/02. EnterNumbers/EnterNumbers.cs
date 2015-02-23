// Problem 2. Enter numbers
// * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//    * If an invalid number or non-number text is entered, the method should throw an exception.
// * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.EnterNumbers
{
    using System;
    using System.Collections.Generic;

    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int leftBoundary = 1;
            int rigthBoundry = 100;
            int count = 10;

            List<int> numbers = new List<int>();
            int currentLeftBoundary = leftBoundary;

            try
            {
                for (int i = 0; i < count; i++)
                {
                    currentLeftBoundary = ReadNumbers(currentLeftBoundary, rigthBoundry);
                    numbers.Add(currentLeftBoundary);
                }

                Console.Write("{0}", leftBoundary);

                foreach (var item in numbers)
                {
                    Console.Write(" < {0}", item);
                }

                Console.Write(" < {0}", rigthBoundry);
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("number out of range [{0}, {1}]", currentLeftBoundary, rigthBoundry);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("number is in invalid format");
            }
        }

        private static int ReadNumbers(int left, int right)
        {
            string inputStr;
            int number;

            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            if (number < left || number > right)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
