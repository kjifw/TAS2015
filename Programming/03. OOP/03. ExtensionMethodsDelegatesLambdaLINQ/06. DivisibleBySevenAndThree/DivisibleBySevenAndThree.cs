// Problem 6. Divisible by 7 and 3
// * Write a program that prints from given array of integers all
//   numbers that are divisible by 7 and 3. Use the built-in extension 
//   methods and lambda expressions. Rewrite the same with LINQ.


namespace _06.DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBySevenAndThree
    {
        static void Main(string[] args)
        {
            int numbersCount = 50;
            List<int> numbers = FillNumbers(numbersCount);

            var extractNumbersWithLambda = numbers.FindAll(x => x % 7 == 0 || x % 3 == 0);

            PrintNumbers(extractNumbersWithLambda);

            var extractNumbersWithLinq = from num in numbers
                                         where num % 7 == 0 || num % 3 == 0
                                         select num;
            
            PrintNumbers(extractNumbersWithLinq);
        }

        private static void PrintNumbers<T>(IEnumerable<T> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
        }

        private static List<int> FillNumbers(int numbersCount)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
