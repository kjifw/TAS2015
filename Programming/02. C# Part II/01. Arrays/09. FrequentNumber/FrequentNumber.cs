// ### Problem 9. Frequent number
// * Write a program that finds the most frequent number in an array.
// 
// _Example:_
// 
// |                  input                |    result   |
// |---------------------------------------|-------------|
// | 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 | 4 (5 times) |

namespace _09.FrequentNumber
{
    using System;
    using System.Collections.Generic;

    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers;
            KeyValuePair<int, int> mostFrequentNumber = new KeyValuePair<int,int>();
            
            arrOfIntegers = ReadArray();

            mostFrequentNumber = FindMostFrequentNumber(arrOfIntegers);

            Console.WriteLine("{0} ({1} times)", mostFrequentNumber.Key, mostFrequentNumber.Value);
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

        private static KeyValuePair<int, int> FindMostFrequentNumber(int[] arr)
        {
            KeyValuePair<int, int> mostFreqNum;
            int currentNumber = 0;
            int currentNumberCount = 0;
            int mostFrequentNumber = 0;
            int mostFrequentNumberCount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentNumber = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentNumberCount++;
                    }
                }

                if (currentNumberCount > mostFrequentNumberCount)
                {
                    mostFrequentNumber = currentNumber;
                    mostFrequentNumberCount = currentNumberCount;
                }

                currentNumberCount = 0;
            }

            mostFreqNum = new KeyValuePair<int, int>(mostFrequentNumber, mostFrequentNumberCount);

            return mostFreqNum;
        }
    }
}
