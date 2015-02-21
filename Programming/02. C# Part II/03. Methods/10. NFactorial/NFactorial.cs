// Problem 10. N Factorial
// * Write a program to calculate n! for each n in the range [1..100].
// 
// Hint: Implement first a method that multiplies a number represented 
// as array of digits by given integer number.

namespace _10.NFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class NFactorial
    {

        // works for n = 10000, works very slow for n = 15000
        static void Main(string[] args)
        {
            string inputStr;
            int n; 

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            string result = Factorial(n);

            Console.WriteLine(result);
        }

        private static string Factorial(int n)
        {
            int[] fact = new int[] { 1 };

            for (int i = 2; i <= n; i++)
            {
                fact = Multiply(fact, i);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = fact.Length - 1; i >= 0; i--)
            {
                sb.Append(fact[i]);
            }

            string str = sb.ToString().TrimStart('0');

            return str;
        }

        private static int[] Multiply(int[] arr, int number)
        {
            int[] result = new int[arr.Length + number % 10];
            int carry = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int mult = arr[i] * number + carry;

                if (mult > 9)
                {
                    result[i] = mult % 10;
                    carry = mult / 10;
                }
                else
                {
                    result[i] = mult;
                    carry = 0;
                }
            }

            return result;
        }
    }
}
