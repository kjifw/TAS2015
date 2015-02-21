// ### Problem 1. Allocate array
// * Write a program that allocates array of `20` integers and 
//   initializes each element by its index multiplied by `5`.
// * Print the obtained array on the console.

namespace _01.AllocateArray
{
    using System;

    class AllocateArray
    {
        static void Main(string[] args)
        {
            int arrLength = 20;
            int[] numbers;

            numbers = FillArray(arrLength);

            PrintArray(numbers);
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

        private static int[] FillArray(int length)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = i * 5;
            }

            return arr;
        }
    }
}
