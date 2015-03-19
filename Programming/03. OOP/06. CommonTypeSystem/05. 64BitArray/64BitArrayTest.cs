
namespace _05._64BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class _64BitArrayTest
    {
        static void Main(string[] args)
        {
            BitArray first = new BitArray(5);
            first[0] = 35468664546;
            first[1] = 11235454;
            first[2] = 37;
            first[3] = 55;
            first[4] = 11;
            BitArray second = new BitArray(5);
            second[0] = 35468664546;
            second[1] = 11235454;
            second[2] = 37;
            second[3] = 55;
            second[4] = 11;
            
            Console.WriteLine("first.Equals(second): {0}", first.Equals(second));
            Console.WriteLine("first == second: {0}", first == second);
            Console.WriteLine("first != second: {0}", first != second);
            Console.WriteLine("first array hash code: {0}", first.GetHashCode());
            Console.WriteLine("second array hash code: {0}", second.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("items in array: ");
            foreach (var item in first)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
