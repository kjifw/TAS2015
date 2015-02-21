// Problem 5. Larger than neighbours
// * Write a method that checks if the element at given position 
//   in given array of integers is larger than its two neighbours 
//   (when such exist).

namespace _05.LargerThanNeighbours
{
    using System;

    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arr;
            string inputStr; 
            int position;
            bool isBiggerThanNeighbours;

            arr = ReadArray();
           
            inputStr = Console.ReadLine();
            position = Convert.ToInt32(inputStr);
           
            while (position < 0 || position > arr.Length)
            {
                Console.Clear();
                Console.WriteLine("position must be between 0 and {0}", arr.Length);
                inputStr = Console.ReadLine();
                position = Convert.ToInt32(inputStr);
            }

            isBiggerThanNeighbours = BiggerThanNeighbours(arr, position);

            Console.WriteLine(isBiggerThanNeighbours);
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

        private static bool BiggerThanNeighbours(int[] arr, int index)
        {
            bool isBigger = false;

            if (index > 0 && index < arr.Length - 1)
            {
                if ((arr[index] >= arr[index - 1]) && (arr[index] >= arr[index + 1]))
                {
                    isBigger = true;
                }
            }

            return isBigger;
        }
    }
}
