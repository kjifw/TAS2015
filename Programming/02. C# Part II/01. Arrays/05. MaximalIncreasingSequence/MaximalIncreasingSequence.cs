// ### Problem 5. Maximal increasing sequence
// * Write a program that finds the maximal increasing sequence in an array.
// _Example:_
// 
// |          input       | result  |
// |----------------------|---------|
// | 3, 2, 3, 4, 2, 2, 4  | 2, 3, 4 |

// Additional tests
// { 5, 6, 7, 1, 2, 3, 4 };
// { 3, 2, 3, 4, 2, 2, 4, 5, 6, 7, 8, 8, 9 };
// { 2, 1, 1, 2, 3, 3, 1, 2, 4, 1 };

namespace _05.MaximalIncreasingSequence
{
    using System;

    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] maxIncreasingArr;

            arr = ReadArray();

            maxIncreasingArr = FindMaxSequence(arr);

            PrintArray(maxIncreasingArr);
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

        private static int[] FindMaxSequence(int[] arr)
        {
            int maxSeqCount = 1;
            int currentSeqCount = 1;
            int maxSeqIndex = 0;
            int currentSeqIndex = 0;
            int[] maxSubArr;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    currentSeqCount++;
                    currentSeqIndex = i;
                }
                else
                {
                    currentSeqCount = 1;
                }

                if (currentSeqCount > maxSeqCount)
                {
                    maxSeqCount = currentSeqCount;
                    maxSeqIndex = currentSeqIndex - currentSeqCount + 1;
                }
            }

            maxSubArr = new int[maxSeqCount];

            int maxSubArrIndex = 0;
            for (int index = maxSeqIndex; index < maxSeqIndex + maxSeqCount; index++)
            {
                maxSubArr[maxSubArrIndex] = arr[index];
                maxSubArrIndex++;
            }

            return maxSubArr;
        }
    }
}
