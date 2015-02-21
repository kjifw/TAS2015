// ### Problem 11. Binary search
// * Write a program that finds the index of given element in a sorted array 
//   of integers by using the Binary search algorithm.

namespace _11.BinarySearchAlgorithm
{
    using System;

    class BinarySearchAlgorithm
    {
        static void Main(string[] args)
        {
            int[] arr;
            int indexOfElement;
            int valueOfElement;
            string inputStr;

            arr = ReadArray();

            inputStr = Console.ReadLine();
            valueOfElement = Convert.ToInt32(inputStr);

            indexOfElement = BinarySearch(arr, valueOfElement);
           
            if (indexOfElement == -1)
            {
                Console.WriteLine("element not found");
            }
            else
            {
                Console.WriteLine("index in the array is: {0}", indexOfElement);
            }
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

        private static int BinarySearch(int[] arr, int value)
        {
            int min = 0;
            int max = arr.Length - 1;
            Array.Sort(arr);
            int index = -1;

            while (max >= min)
            {
                int middle = min + ((max - min) / 2);

                if (arr[middle] == value)
                {
                    index = middle;
                    break;
                }
                else if (arr[middle] < value)
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }

            return index;
        }
    }
}
