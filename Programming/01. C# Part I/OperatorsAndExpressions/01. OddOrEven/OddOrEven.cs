﻿// ### Problem 1. Odd or Even Integers
// * Write an expression that checks if given integer is odd or even.
// 
// _Examples:_
// 
// |  n |  Odd? |
// |:--:|:-----:|
// | 3  | true  |
// | 2  | false |
// | -2 | false |
// | -1 | true  |
// | 0  | false |

namespace _01.OddOrEven
{
    using System;

    class OddOrEven
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;

            Console.Write("Input number: ");
            inputStr = Console.ReadLine();
            number = Convert.ToInt32(inputStr);

            Console.Write("Odd ? ");
            if ((number & 1) == 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
