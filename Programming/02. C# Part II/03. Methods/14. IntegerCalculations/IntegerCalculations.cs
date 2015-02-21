// Problem 14. Integer calculations
// * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// * Use variable number of arguments.
//
// Test Numbers
// 4 2 5 3 7 5 6 9 1 3 8 9

namespace _14.IntegerCalculations
{
    using System;
    using System.Collections.Generic;

    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int min;
            int max;
            double average;
            long sum;
            long product;

            numbers = ReadNumbers();

            min = FindMin(numbers);
            Console.WriteLine("min: {0}", min);

            max = FindMax(numbers);
            Console.WriteLine("max: {0}", max);

            sum = FindSum(numbers);
            Console.WriteLine("sum: {0}", sum);

            average = FindAverage(numbers);
            Console.WriteLine("average: {0}", average);

            product = FindProduct(numbers);
            Console.WriteLine("product: {0}", product);
        }

        private static List<int> ReadNumbers()
        {
            string inputStr;
            string[] inputArr;
            List<int> numbers = new List<int>();

            inputStr = Console.ReadLine().TrimStart().TrimEnd();
            inputStr = inputStr.Replace(", ", " ");
            inputStr = inputStr.Replace(",", " ");
            inputArr = inputStr.Split(' ');

            for (int i = 0; i < inputArr.Length; i++)
            {
                numbers.Add(Convert.ToInt32(inputArr[i]));
            }

            return numbers;
        }

        private static int FindMin(List<int> listOfNumbers)
        {
            int min = int.MaxValue;

            foreach (var item in listOfNumbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        private static int FindMax(List<int> listOfNumbers)
        {
            int max = int.MinValue;

            foreach (var item in listOfNumbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        private static long FindSum(List<int> listOfNumbers)
        {
            long sum = 0;

            foreach (var item in listOfNumbers)
            {
                sum += item;
            }

            return sum;
        }

        private static double FindAverage(List<int> listOfNumbers)
        {
            double avg = 0.0;
            long sum = FindSum(listOfNumbers);

            avg = sum / (double)listOfNumbers.Count;

            return avg;
        }

        private static long FindProduct(List<int> listOfNumbers)
        {
            long product = 1;

            foreach (var item in listOfNumbers)
            {
                product *= item;
            }

            return product;
        }
    }
}
