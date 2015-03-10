

namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtentions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = collection.First();

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            sum -= (dynamic)collection.First();

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T product = collection.First();
            
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            product /= (dynamic)collection.First();

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            T min = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            T max = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            T avg = (dynamic)collection.Sum() / collection.Count();

            return avg;
        }
    }
}
