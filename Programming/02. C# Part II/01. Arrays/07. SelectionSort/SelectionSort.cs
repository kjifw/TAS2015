// ### Problem 7. Selection sort
// * Sorting an array means to arrange its elements in increasing order. 
//   Write a program to sort an array.
// * Use the Selection sort algorithm: Find the smallest element, move it 
//   at the first position, find the smallest from the rest, move it at 
//   the second position, etc.

namespace _07.SelectionSort
{
    using System;

    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr;

            arr = ReadArray();
            arr = SelectionSortArray(arr);

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

        private static int[] SelectionSortArray(int[] arr)
        {
            int min;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }        
                }

                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            return arr;
        }
    }
}
