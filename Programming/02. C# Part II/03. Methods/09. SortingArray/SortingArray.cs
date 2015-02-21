// Problem 9. Sorting array
// * Write a method that return the maximal element in a portion of array of integers 
//   starting at given index.
// * Using it write another method that sorts an array in ascending / descending order.
// 
// Test Array
// 4 2 5 3 7 5 6 9 1 3 8 9

namespace _09.SortingArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortingArray
    {
        static void Main(string[] args)
        {
            int[] arr;
            bool isAscending = false;

            arr = ReadArray();

            arr = Sort(arr, isAscending);
            Console.WriteLine("descending");
            PrintArray(arr);

            isAscending = true;

            arr = Sort(arr, isAscending);
            Console.WriteLine("ascending");
            PrintArray(arr);
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
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }

        private static int FindMaxElementIndex(int[] arr, int startIndex)
        {
            int maxIndex = startIndex;

            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private static int[] Sort(int[] arr, bool isAscending)
        {            
            int elementIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                elementIndex = FindMaxElementIndex(arr, i);

                int temp = arr[i];
                arr[i] = arr[elementIndex];
                arr[elementIndex] = temp;
            }

            if (isAscending)
            {
                List<int> arrayAsList = new List<int>();
                arrayAsList = arr.ToList();
                arrayAsList.Reverse();
                arr = arrayAsList.ToArray();
            }

            return arr;
        }
    }
}
