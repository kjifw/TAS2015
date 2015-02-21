

namespace _06.FirstLargerThanNeighbours
{
    using System;

    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arr;
            int position;

            arr = ReadArray();

            position = BiggerThanNeighbours(arr);

            Console.WriteLine(position);
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

        private static int BiggerThanNeighbours(int[] arr)
        {
            int index = -1;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] >= arr[i - 1]) && (arr[i] >= arr[i + 1]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
