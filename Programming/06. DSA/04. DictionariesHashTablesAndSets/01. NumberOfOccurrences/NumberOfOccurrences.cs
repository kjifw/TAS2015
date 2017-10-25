// Task 1. Write a program that counts in a given array of double values the number of occurrences of 
// each value. Use Dictionary<TKey,TValue>.
// 
// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
// -2.5 -> 2 times
// 3 -> 4 times
// 4 -> 3 times

namespace _01.NumberOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOfOccurrences
    {
        public static void Main()
        {
            Dictionary<double, int> sequence = ReadSequence();

            PrintSequence(sequence);
        }

        private static void PrintSequence(Dictionary<double, int> sequence)
        {
            foreach (var item in sequence.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }

            Console.WriteLine();
        }

        private static Dictionary<double, int> ReadSequence()
        {
            Dictionary<double, int> sequence = new Dictionary<double, int>();

            string inputStr = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(inputStr))
            {
                double currentNumber = Convert.ToDouble(inputStr);

                if (sequence.ContainsKey(currentNumber))
                {
                    sequence[currentNumber]++;
                }
                else
                {
                    sequence.Add(currentNumber, 1);
                }

                inputStr = Console.ReadLine();
            }

            return sequence;
        }
    }
}
