// Problem 4. Appearance count
// * Write a method that counts how many times given number appears in given array.
// * Write a test program to check if the method is workings correctly.


namespace _04.AppearanceCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppearanceCount
    {
        static void Main(string[] args)
        {
            string inputStr;
            int[] arrOfIntegers;
            int number;
            int count;

            arrOfIntegers = ReadArray();

            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            count = AppearCount(arrOfIntegers, number);

            Console.WriteLine("{0} ({1} times)", number, count);
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

        private static int AppearCount(int[] arr, int number)
        {
            int count;

            count = arr.ToList().Count(x => x == number);

            return count;
        }
    }
}
