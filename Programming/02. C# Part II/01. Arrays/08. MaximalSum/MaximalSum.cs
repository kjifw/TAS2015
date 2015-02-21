// ### Problem 8. Maximal sum
// * Write a program that finds the sequence of maximal sum in given array.
//
// _Example:_
//
// |                 input             |    result   |
// |-----------------------------------|-------------|
// | 2, 3, -6, -1, 2, -1, 6, 4, -8, 8  | 2, -1, 6, 4 |
// 
// * _Can you do it with only one loop (with single scan through the elements of the array)?_

namespace _08.MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] maxSumElem;

            arr = ReadArray();
            
            maxSumElem = FindMaxSumElements(arr);
            
            PrintArray(maxSumElem);
        }

        private static int[] ReadArray()
        {
            string inputStr;
            string[] inputArr;
            int[] integerArr;

            inputStr = Console.ReadLine().TrimStart().TrimEnd();
            inputStr = inputStr.Replace(", ", " ");
            inputStr = inputStr.Replace(",", " ");
            inputArr = inputStr.Split(' ');

            integerArr = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
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

        private static int[] FindMaxSumElements(int[] arr)
        {
            int currentSum = arr[0];
            int currentCount = 1;
            int currentIndex = 0;
            int maxSum = arr[0];
            int maxCount = 1;
            int maxIndex = 0;
            int[] maxElements;

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum += arr[i];
                currentIndex = i;
                currentCount++;

                if (arr[i] >= currentSum)
                {
                    currentSum = arr[i];
                    currentCount = 1;
                }

                if (currentSum >= maxSum)
                {
                    maxSum = currentSum;
                    maxCount = currentCount;
                    maxIndex = currentIndex - currentCount + 1;
                }
            }

            maxElements = new int[maxCount];

            int j = 0;
            for (int i = maxIndex; i < maxIndex + maxCount; i++)
            {
                maxElements[j] = arr[i];
                j++;
            }

            return maxElements;
        }
    }
}
