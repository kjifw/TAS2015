

namespace _04.BinarySearch
{
    using System;
    using System.Linq;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr;
            int k;
            string inputStr;
            int index = -1;

            arr = ReadArray();

            inputStr = Console.ReadLine();
            k = Convert.ToInt32(inputStr);

            Array.Sort(arr);
            index = arr.ToList().BinarySearch(k, null);

            if (index < 0)
            {
                index = Math.Abs(index) - 2;
            }

            if (index == -1)
            {
                Console.WriteLine("element not found");
            }
            else
            {
                Console.WriteLine(index);
                Console.WriteLine(arr[index]);
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
    }
}
