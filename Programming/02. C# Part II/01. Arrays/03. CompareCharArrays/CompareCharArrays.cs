// ### Problem 3. Compare char arrays
// * Write a program that compares two `char` arrays lexicographically (letter by letter).

namespace _03.CompareCharArrays
{
    using System;

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr;
            char[] secondArr;
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

            areEqual = CompareArrays(firstArr, secondArr);

            if (areEqual)
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }

        private static char[] ReadArray()
        {
            string inputStr;
            char[] arr;

            inputStr = Console.ReadLine();
            arr = inputStr.ToCharArray();

            return arr;
        }

        private static bool CompareArrays(char[] firstArr, char[] secondArr)
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
