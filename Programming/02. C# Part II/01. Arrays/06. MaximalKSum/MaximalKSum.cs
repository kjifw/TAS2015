// ### Problem 6. Maximal K sum
// * Write a program that reads two integer numbers `N` and `K` and an array of `N` elements from the console.
// * Find in the array those `K` elements that have maximal sum.

// Additional tests
// { 5, 6, -7, 1, 2, 3, -4 };
// { 3, -2, 3, 4, 2, 2, -4, 5, 6, 7, 8, -8, 9 };
// { 2, 1, -1, 2, 3, 3, -1, 2, 4, 1 };

namespace _06.MaximalKSum
{
    using System;
    using System.Collections.Generic;

    class MaximalKSum
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            int k;
            int[] arr;
            int[] maxKSumMembers;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            k = Convert.ToInt32(inputStr);

            while (n < 0 || k < 0 || n < k)
            {
                Console.Clear();
                Console.WriteLine("n > k, k > 0:");
                inputStr = Console.ReadLine();
                n = Convert.ToInt32(inputStr);
                inputStr = Console.ReadLine();
                k = Convert.ToInt32(inputStr);
            }

            arr = ReadArray(n);

            maxKSumMembers = FindMaxKSum(arr, k);

            PrintArray(maxKSumMembers);
        }

        private static int[] ReadArray(int length)
        {
            string inputStr;
            string[] inputArr;
            int[] integerArr;

            inputStr = Console.ReadLine().TrimStart().TrimEnd();
            inputStr = inputStr.Replace(", ", " ");
            inputStr = inputStr.Replace(",", " ");
            inputArr = inputStr.Split(' ');

            while (length != inputArr.Length)
            {
                Console.Clear();
                Console.WriteLine("Array Length must be: {0}", length);
                inputStr = Console.ReadLine().TrimStart().TrimEnd();
                inputStr = inputStr.Replace(", ", " ");
                inputStr = inputStr.Replace(",", " ");
                inputArr = inputStr.Split(' ');
            }

            integerArr = new int[length];
            for (int i = 0; i < length; i++)
            {
                integerArr[i] = Convert.ToInt32(inputArr[i]);
            }

            return integerArr;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write("{0}", arr[i]);
                }
                else
                {
                    Console.Write("{0} ", arr[i]);
                }
            }

            Console.WriteLine();
        }

        private static int[] FindMaxKSum(int[] arr, int k)
        {
            int[] maxKSeq = new int[k];
            int currentSum = 0;
            int maxSum = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i <= arr.Length - k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    currentSum += arr[i + j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxIndex = i;
                }

                currentSum = 0;
            }

            int maxKSeqIndex = 0;
            for (int i = maxIndex; i < maxIndex + k; i++)
            {
                maxKSeq[maxKSeqIndex] = arr[i];
                maxKSeqIndex++;
            }

            return maxKSeq;
        } 
    }
}
