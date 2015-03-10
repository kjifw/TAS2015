// Problem 2. IEnumerable extensions
// * Implement a set of extension methods for IEnumerable<T> that implement 
//   the following group functions: sum, product, min, max, average.

namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtensionsTest
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>(new int[] { -2, 17, 7, 1, -6, -12, 8, 11, 3, 4});
            PrintSequence(collection);

            Console.WriteLine("sum = {0}", collection.Sum());
            Console.WriteLine("product = {0}", collection.Product());
            Console.WriteLine("min = {0}", collection.Min());
            Console.WriteLine("max = {0}", collection.Max());
            Console.WriteLine("average = {0}", collection.Average());
        }

        private static void PrintSequence<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
