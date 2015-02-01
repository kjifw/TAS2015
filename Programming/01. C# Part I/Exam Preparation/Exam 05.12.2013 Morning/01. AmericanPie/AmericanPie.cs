
namespace _01.AmericanPie
{
    using System;

    class AmericanPie
    {
        static void Main(string[] args)
        {
            string inputStr;
            long a;
            long b;
            long c;
            long d;
            long nominator;
            long denominator;
            decimal fullPie;

            inputStr = Console.ReadLine();
            a = Convert.ToInt64(inputStr);
            inputStr = Console.ReadLine();
            b = Convert.ToInt64(inputStr);
            inputStr = Console.ReadLine();
            c = Convert.ToInt64(inputStr);
            inputStr = Console.ReadLine();
            d = Convert.ToInt64(inputStr);

            nominator = (a * d) + (b * c);
            denominator = b * d;

            fullPie = (decimal)nominator / denominator;

            if (fullPie < 1)
            {
                Console.WriteLine("{0:F20}", fullPie);
            }
            else
            {
                Console.WriteLine("{0}", (long)fullPie);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
