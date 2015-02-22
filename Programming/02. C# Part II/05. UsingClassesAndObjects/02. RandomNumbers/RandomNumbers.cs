// Problem 2. Random numbers
// * Write a program that generates and prints to the console 
//   10 random values in the range [100, 200].

namespace _02.RandomNumbers
{
    using System;
    using System.Collections.Generic;

    class RandomNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int rangeStart = 100;
            int rangeEnd = 200;
            int numbersCount = 10;

            numbers = GenerateNumbers(rangeStart, rangeEnd, numbersCount);

            PrintList(numbers);

            Console.WriteLine();
        }

        private static void PrintList(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
        }

        private static List<int> GenerateNumbers(int start, int end, int count)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(rand.Next(start, end + 1));    
            }

            return numbers;
        }
    }
}
