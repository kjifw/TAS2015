// Problem 8. Number as array
// * Write a method that adds two positive integer numbers represented 
//   as arrays of digits (each array element arr[i] contains a digit; 
//   the last digit is kept in arr[0]).
// * Each of the numbers that will be added could have up to 10 000 digits.

namespace _08.NumberAsArray
{
    using System;
    using System.Collections.Generic;

    class NumberAsArray
    {
        static void Main(string[] args)
        {
            string firstNumber;
            string secondNumber;
            string sum;

            firstNumber = Console.ReadLine();
            secondNumber = Console.ReadLine();

            sum = SumOfNumbers(firstNumber, secondNumber);

            Console.WriteLine(sum);
        }

        private static string SumOfNumbers(string first, string second)
        {
            string result = string.Empty;
            List<int> sum = new List<int>();

            if (first.Length >= second.Length)
            {
                second = new string('0', first.Length - second.Length) + second;
            }
            else
            {
                first = new string('0', second.Length - first.Length) + first;
            }

            int length = first.Length;
            int inMind = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                int currentSum = (first[i] - '0') + (second[i] - '0') + inMind;

                if (currentSum > 9)
                {
                    sum.Add(currentSum % 10);
                    inMind = 1;
                }
                else
                {
                    sum.Add(currentSum);
                    inMind = 0;
                }

                if (inMind == 1 && i == 0)
                {
                    sum.Add(inMind);
                    inMind = 0;
                }
            }

            sum.Reverse();
            foreach (var item in sum)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
