// ### Problem 2. Compare arrays
// * Write a program that reads two `integer` arrays from the 
//   console and compares them element by element.

namespace _02.CompareArrays
{
    using System;

    class CompareArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr;
            int[] secondArr;
            bool areEqual;

            firstArr = ReadArray();
            secondArr = ReadArray();

            while (firstArr.Length != secondArr.Length)
            {
                Console.Clear();
                Console.WriteLine("Arrays must have equal length to be compared.");
                firstArr = ReadArray();
                secondArr = ReadArray();
            }

            areEqual = CompareIntegerArrays(firstArr, secondArr);

            if (areEqual)
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }

        private static int[] ReadArray()
        {
            string inputStr;
            string[] inputArr;
            int[] integerArr;

            inputStr = Console.ReadLine().TrimEnd();
            inputArr = inputStr.Split(new char[] { ' ', ',' });

            integerArr = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                integerArr[i] = Convert.ToInt32(inputArr[i]);
            }

            return integerArr;
        }

        private static bool CompareIntegerArrays(int[] firstArr, int[] secondArr)
        {
            bool areEqual = false;
            int counter = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
            }

            if (counter == firstArr.Length)
            {
                areEqual = true;
            }

            return areEqual;
        }
    }
}
