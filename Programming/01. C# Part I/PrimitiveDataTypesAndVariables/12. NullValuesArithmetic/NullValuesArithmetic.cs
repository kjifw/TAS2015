// ### Problem 12. Null Values Arithmetic
// * Create a program that assigns null values to an integer and to a double variable. 
// * Try to print these variables at the console. 
// * Try to add some number or the null literal to these variables and print the result.

namespace _12.NullValuesArithmetic
{
    using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstInt = null;
            double? firstDouble = null;

            // marker is used to see how exactly null values are
            // printed on the console
            string mark = "marker";

            Console.WriteLine(mark + firstInt + mark);
            Console.WriteLine(mark + firstDouble + mark);

            firstInt += 4;
            firstDouble += 4.2;

            Console.WriteLine("After addition: ");

            Console.WriteLine(mark + firstInt + mark);
            Console.WriteLine(mark + firstDouble + mark);
        }
    }
}
