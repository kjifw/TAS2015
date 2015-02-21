// Problem 13. Solve tasks
//
//   * Write a program that can solve these tasks:
//     * Reverses the digits of a number
//     * Calculates the average of a sequence of integers
//     * Solves a linear equation a * x + b = 0
//   * Create appropriate methods.
//   * Provide a simple text-based menu for the user to choose which task to solve.
//   * Validate the input data:
//     * The decimal number should be non-negative
//     * The sequence should not be empty
//     * a should not be equal to 0

namespace _13.SolveTasks
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class SolveTasks
    {
        static bool Exit { get; set; }

        static void Main()
        {
            while (true)
            {
                if (SolveTasks.Exit == true)
                {
                    break;
                }
                else
                {
                    InitializeMenu();
                }
            }
        }

        private static void InitializeMenu()
        {
            string inputStr;

            Console.Clear();
            Console.WriteLine("please choose: ");
            Console.WriteLine("1 - reverse digits of number");
            Console.WriteLine("2 - Calculate the average of a sequence of integers");
            Console.WriteLine("3 - Solve a linear equation a * x + b = 0");
            Console.WriteLine("4 - Exit");

            inputStr = Console.ReadLine();

            switch (inputStr)
            {
                case "1":
                    FirstChoice();
                    break;
                case "2":
                    SecondChoice();
                    break;
                case "3":
                    ThirdChoice();
                    break;
                case "4": 
                    SolveTasks.Exit = true;
                    return;
                default:
                    SolveTasks.Exit = false;
                    return;
            }

            Console.Write("press any key to restart");
            Console.ReadKey();
        }

        private static void FirstChoice()
        {
            string inputStr;
            string pattern = @"^[0-9]+$";

            Console.Write("input number: ");
            inputStr = Console.ReadLine();
            bool isValidNumber = Regex.IsMatch(inputStr, pattern);

            while (!isValidNumber)
            {
                Console.Clear();
                Console.Write("Input valid number: ");
                inputStr = Console.ReadLine();
                isValidNumber = Regex.IsMatch(inputStr, pattern);
            }

            string revercedNumber = Reverse(inputStr.TrimStart(new char[] { '0' }));
            Console.WriteLine("reverced number: {0}", revercedNumber.TrimStart(new char[] { '0' }));

        }

        private static void SecondChoice()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("input numbers: ");
            numbers = ReadNumbers();

            while (numbers.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("input numbers: ");
                numbers = ReadNumbers();
            }

            double avg = FindAverage(numbers);
            Console.WriteLine("average of numbers: {0}", avg);

        }

        private static void ThirdChoice()
        {
            int a;
            int b;
            double equationResult;
            string inputStr;

            Console.Write("input a: ");
            inputStr = Console.ReadLine();
            a = Convert.ToInt32(inputStr);

            while (a == 0)
            {
                Console.Clear();
                Console.WriteLine("a must not be 0");
                Console.Write("input a: ");
                inputStr = Console.ReadLine();
                a = Convert.ToInt32(inputStr);
            }

            Console.Write("input b: ");
            inputStr = Console.ReadLine();
            b = Convert.ToInt32(inputStr);

            equationResult = SolveLinearEquation(a, b);

            Console.WriteLine("result of a * x + b = 0: {0}", equationResult);

        }

        private static string Reverse(string str)
        {
            string revStr = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            return revStr;
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

            if (inputStr.Length > 0)
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    numbers.Add(Convert.ToInt32(inputArr[i]));
                }
            }

            return numbers;
        }

        private static double FindAverage(List<int> listOfNumbers)
        {
            double avg = 0.0;
            long sum = FindSum(listOfNumbers);

            avg = sum / (double)listOfNumbers.Count;

            return avg;
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

        private static double SolveLinearEquation(int a, int b)
        {
            double result = (-b) / (double)a;

            return result;
        }
    }
}
