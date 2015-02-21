// Problem 2. Get largest number
// * Write a method GetMax() with two parameters that returns the larger of two integers.
// * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02.GetLargestNumber
{
    using System;

    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            const int arrayLength = 3;

            int[] arr;

            arr = ReadArray(arrayLength);
            int largest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                largest = GetMax(largest, arr[i]);
            }

            Console.WriteLine(largest);
        }

        private static int[] ReadArray(int n)
        {
            int[] arr = new int[n];
            string inputStr;

            for (int i = 0; i < arr.Length; i++)
            {
                inputStr = Console.ReadLine();
                arr[i] = Convert.ToInt32(inputStr);
            }

            return arr;
        }

        private static int GetMax(int a, int b)
        {
            //return a >= b ? a : b;
            int max;

            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;     
        }
    }
}
