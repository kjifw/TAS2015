// ### Problem 10. Find sum in array
// * Write a program that finds in given array of integers a sequence of given sum `S` (if present).
// 
// _Example:_
// 
// |        array        |  S |  result |
// |---------------------|----|---------|
// | 4, 3, 1, 4, 2, 5, 8 | 11 | 4, 2, 5 |

namespace _10.FindSumInArray
{
    using System;

    class FindSumInArray
    {
        static void Main(string[] args)
        {
            string inputStr;
            int[] arr;
            int[] sumElements;
            int sum;

            arr = ReadArray();

            inputStr = Console.ReadLine();
            sum = Convert.ToInt32(inputStr);

            sumElements = FindSum(arr, sum);
         
            if (sumElements == null || sumElements.Length == 0)
            {
                Console.WriteLine("Sum not found.");
            }
            else
            {
                PrintArray(sumElements);
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

        private static int[] FindSum(int[] arr, int sum)
        {
            int currentSum = arr[0];
            int currentIndex = 0;
            int currentCount = 1;
            int sumIndex = 0;
            int sumCount = 0;
            int[] sumArr;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentSum = arr[i];
                currentCount = 1;
                currentIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    currentIndex = j;
                    currentCount++;

                    if (currentSum == sum)
                    {
                        sumCount = currentCount;
                        sumIndex = currentIndex - currentCount + 1;
                        break;
                    }
                }
            }

            sumArr = new int[sumCount];

            int sumArrIndex = 0;
            for (int i = sumIndex; i < sumIndex + sumCount; i++)
            {
                sumArr[sumArrIndex] = arr[i];
                sumArrIndex++;
            }

            return sumArr;
        }
    }
}
