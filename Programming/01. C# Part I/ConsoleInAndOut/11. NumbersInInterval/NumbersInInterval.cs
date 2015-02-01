// ### Problem 11.* Numbers in Interval Dividable by Given Number
// * Write a program that reads two positive integer numbers and prints
//   how many numbers `p` exist between them such that the reminder of the division by `5` is `0`.
// 
// _Examples:_
// 
// | start | end |  p |                                         comments                                         |
// |:-----:|:---:|:--:|------------------------------------------------------------------------------------------|
// | 17    | 25  | 2  | 20, 25                                                                                   |
// | 5     | 30  | 6  | 5, 10, 15, 20, 25, 30                                                                    |
// | 3     | 33  | 6  | 5, 10, 15, 20, 25, 30                                                                    |
// | 3     | 4   | 0  | -                                                                                        |
// | 99    | 120 | 5  | 100, 105, 110, 115, 120                                                                  |
// | 107   | 196 | 18 | 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195 |

namespace _11.NumbersInInterval
{
    using System;

    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            int lowBorder;
            int highBorder;
            int first;  // count of numbers divisible by 5 without reminder below lowborder
            int second; // count of numbers divisible by 5 without reminder below highborder 
            string inputStr;
            int count = 0;

            Console.Write("start: ");
            inputStr = Console.ReadLine();
            lowBorder = Convert.ToInt32(inputStr);
            Console.Write("end: ");
            inputStr = Console.ReadLine();
            highBorder = Convert.ToInt32(inputStr);

            if (highBorder < lowBorder)
            {
                highBorder = highBorder + lowBorder;
                lowBorder = highBorder - lowBorder;
                highBorder = highBorder - lowBorder;
            }
            
            first = lowBorder / 5;
            second = highBorder / 5;
            
            if (lowBorder % 5 == 0)
            {
                count = second - first + 1;
            }
            else
            {
                count = second - first;
            }

            Console.WriteLine("p: {0}", count);
        }
    }
}
