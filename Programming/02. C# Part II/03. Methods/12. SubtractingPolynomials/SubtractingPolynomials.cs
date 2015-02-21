// Problem 12. Subtracting polynomials
// * Extend the previous program to support also subtraction and multiplication of polynomials.

namespace _12.SubtractingPolynomials
{
    using System;

    class SubtractingPolynomials
    {
        static void Main(string[] args)
        {
            int[] firstPolynomial;
            int[] secondPolynomial;
            int[] differeceOfPolynomials;
            int[] multiplicationOfPolynomials;

            Console.WriteLine("input queficients: ");
            firstPolynomial = ReadArray();
            secondPolynomial = ReadArray();

            differeceOfPolynomials = SubtractPolinomials(firstPolynomial, secondPolynomial);
            multiplicationOfPolynomials = MultiplyPolinomials(firstPolynomial, secondPolynomial);

            PrintArray(differeceOfPolynomials);
            PrintArray(multiplicationOfPolynomials);
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

        private static int[] SubtractPolinomials(int[] first, int[] second)
        {
            int[] sub;
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

            sub = new int[length];

            for (int i = 0; i < length; i++)
            {
                sub[i] = first[i] - second[i];
            }

            return sub;
        }

        private static int[] MultiplyPolinomials(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length - 1];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    result[i + j] += first[i] * second[j];
                }
            }

            return result;
        }
    }
}
