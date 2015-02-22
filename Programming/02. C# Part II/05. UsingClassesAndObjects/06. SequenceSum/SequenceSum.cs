// Problem 6. Sum integers
// * You are given a sequence of positive integer values written into a string, separated by spaces.
// * Write a function that reads these values from given string and calculates their sum.
//
// Example:
// input 	            output
// "43 68 9 23 318" 	461

namespace _06.SequenceSum
{
    using System;
    using System.Collections.Generic;

    class SequenceSum
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            long sum;

            numbers = ReadNumbers();

            sum = SumList(numbers);

            Console.WriteLine(sum);
        }

        private static List<int> ReadNumbers()
        {
            List<int> numbers = new List<int>();
            string inputStr;
            string[] inputArr;

            inputStr = Console.ReadLine();
            inputArr = inputStr.Split(' ');

            for (int i = 0; i < inputArr.Length; i++)
            {
                numbers.Add(Convert.ToInt32(inputArr[i]));
            }

            return numbers;
        }

        private static long SumList(List<int> numbers)
        {
            long sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }
    }
}
