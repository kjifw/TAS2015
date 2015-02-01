// ### Problem 10. Odd and Even Product
// * You are given `n` integers (given in a single line, separated by a space).
// * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// * Elements are counted from `1` to `n`, so the first element is odd, the second is even, etc.
// 
// _Examples:_
// 
// | numbers           | result |
// |-------------------|--------|
// | 2 1 1 6 3         | yes    |
// | product = 6       |        |
// |                   |        |
// | 3 10 4 6 5 1      | yes    |
// | product = 60      |        |
// |                   |        |
// | 4 3 2 5 2         | no     |
// | odd_product = 16  |        |
// | even_product = 15 |        |

namespace _10.OddAndEvenProduct
{
    using System;
    using System.Numerics;

    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string inputStr;
            string[] numbersStr;
            BigInteger oddProduct = 1;
            BigInteger evenProduct = 1;

            inputStr = Console.ReadLine().TrimEnd();
            numbersStr = inputStr.Split(' ');

            for (int i = 0; i < numbersStr.Length; i++)
            {
                if ((i & 1) == 1)
                {
                    oddProduct *= Convert.ToInt32(numbersStr[i]);
                }
                else
                {
                    evenProduct *= Convert.ToInt32(numbersStr[i]);
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
