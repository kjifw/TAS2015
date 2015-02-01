// ### Problem 6. Four-Digit Number
// * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// * Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
// * Prints on the console the number in reversed order: `dcba` (in our example `1102`).
// * Puts the last digit in the first position: `dabc` (in our example `1201`).
// * Exchanges the second and the third digits: `acbd` (in our example `2101`).
//
// The number has always exactly 4 digits and cannot start with 0.
// 
// _Examples:_
// 
// |    n    | sum of digits | reversed | last digit in front | second and third digits exchanged |
// |:-------:|:-------------:|:--------:|:-------------------:|:---------------------------------:|
// | 2011    | 4             | 1102     | 1201                | 2101                              |
// | 3333    | 12            | 3333     | 3333                | 3333                              |
// | 9876    | 30            | 6789     | 6987                | 9786                              |

namespace _06.FourDigitNumber
{
    using System;

    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            string inputStr;
            int number;
            int sumOfDigits;
            int reversed;
            int lastToFirst;
            int middleDigitSwap;
            int firstDigit;
            int secondDitit;
            int thirdDigit;
            int fourthDigit;

            Console.Write("input four digit number: ");
            inputStr = Console.ReadLine();
            
            while (inputStr.Length != 4)
            {
                Console.Clear();
                Console.Write("input four digit number: ");
                inputStr = Console.ReadLine();
            }
            
            number = Convert.ToInt32(inputStr);
            fourthDigit = number % 10;
            number /= 10;
            thirdDigit = number % 10;
            number /= 10;
            secondDitit = number % 10;
            number /= 10;
            firstDigit = number;

            sumOfDigits = firstDigit + secondDitit + thirdDigit + fourthDigit;

            reversed = Convert.ToInt32(String.Empty + fourthDigit + thirdDigit + secondDitit + firstDigit);

            lastToFirst = Convert.ToInt32(String.Empty + fourthDigit + firstDigit + secondDitit + thirdDigit);

            middleDigitSwap = Convert.ToInt32(String.Empty + firstDigit + thirdDigit + secondDitit + fourthDigit);

            Console.WriteLine("sum of digits: {0}", sumOfDigits);
            Console.WriteLine("reversed: {0}", reversed);
            Console.WriteLine("last digit in front: {0}", lastToFirst);
            Console.WriteLine("second and third digit exchanged: {0}", middleDigitSwap);
        }
    }
}
