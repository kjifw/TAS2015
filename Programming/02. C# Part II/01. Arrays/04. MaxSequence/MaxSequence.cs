// ### Problem 4. Maximal sequence 
// * Write a program that finds the **maximal sequence** of equal elements in an array.
// 
// _Example:_
// 
// |              input            | result  |
// |-------------------------------|---------|
// | 2, 1, 1, 2, 3, 3, 2, 2, 2, 1  | 2, 2, 2 |

namespace _04.MaxSequence
{
    using System;

    class MaxSequence
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] maxSeqArr;

            arr = ReadArray();

            maxSeqArr = FindMaxSequence(arr);

            PrintArray(maxSeqArr);
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
        }

        private static int[] FindMaxSequence(int[] arr)
        {
            int currentSeqCount = 0;
            int currentSeqIndex = 0;
            int maxSeqIndex = 0;
            int maxSeqCount = 0;
            int[] maxSubArr;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentSeqCount++;
                    currentSeqIndex = i;
                }
                else
                {
                    currentSeqCount = 1;
                    currentSeqIndex = i + 1;
                }

                if (currentSeqCount > maxSeqCount)
                {
                    maxSeqCount = currentSeqCount;
                    maxSeqIndex = currentSeqIndex;
                }
            }

            maxSubArr = new int[maxSeqCount];

            int maxSubArrIndex = 0;
            for (int i = 0; i < maxSeqCount; i++)
            {
                maxSubArr[maxSubArrIndex] = arr[maxSeqIndex];
                maxSubArrIndex++;
            }

            return maxSubArr;
        }
    }
}
