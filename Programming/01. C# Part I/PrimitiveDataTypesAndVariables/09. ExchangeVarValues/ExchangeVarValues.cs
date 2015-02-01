// ### Problem 9. Exchange Variable Values
// * Declare two integer variables `a` and `b` and assign them with `5` and `10` 
//   and after that exchange their values by using some programming logic.
// * Print the variable values before and after the exchange.

namespace _09.ExchangeVarValues
{
    using System;

    class ExchangeVarValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before exchange: ");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After exchange: ");
            Console.WriteLine("a = {0}", a); 
            Console.WriteLine("b = {0}", b);
        }
    }
}
