// Problem 11. Adding polynomials
//  * Write a method that adds two polynomials.
//  * Represent them as arrays of their coefficients.
// 
// Example:
// x ^ 2 + 5 = 1 * x ^ 2 + 0 * x + 5 => { 5, 0, 1 }

namespace _11.AddingPolynomials
{
    using System;

    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int[] firstPolynomial;
            int[] secondPolynomial;
            int[] sumOfPolynomials;

            Console.WriteLine("input queficients: ");
            firstPolynomial = ReadArray();
            secondPolynomial = ReadArray();

            sumOfPolynomials = SumPolinomials(firstPolynomial, secondPolynomial);

            PrintArray(sumOfPolynomials);
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
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }

        private static int[] SumPolinomials(int[] first, int[] second)
        {
            int[] sum;
            int length;

            if (first.Length >= second.Length)
            {
                length = first.Length;
                Array.Resize(ref second, length);
            }
            else
            {
                length = second.Length;
                Array.Resize(ref first, length);
            }

            sum = new int[length];

            for (int i = 0; i < length; i++)
            {
                sum[i] = first[i] + second[i];
            }

            return sum;
        }
    }
}
