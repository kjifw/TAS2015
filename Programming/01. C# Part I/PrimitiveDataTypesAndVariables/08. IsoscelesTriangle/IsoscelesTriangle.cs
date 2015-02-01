// ### Problem 8. Isosceles Triangle
// * Write a program that prints an isosceles triangle of 9 copyright symbols `©`, something like this:
// ```
//    ©
//
//   © © 
//
//  ©   ©
//
// © © © ©
// ```
// _Note: The `©` symbol may be displayed incorrectly at the console so you may need to change 
// the console character encoding to `UTF-8` and assign a Unicode-friendly font in the console._
// _Note: Under old versions of Windows the `©` symbol may still be displayed incorrectly, 
// regardless of how much effort you put to fix it._

namespace _08.IsoscelesTriangle
{
    using System;
    using System.Text;

    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           
            StringBuilder output = new StringBuilder();
            char symbol = '\u00A9';
            
            int size = 7;
            string beforeAfterSymbol;
            string betweenSymbols;

            for (int i = 0, j = size / 2; i < size / 2; i++, j--)
            {
                beforeAfterSymbol = new string(' ', j);

                if (i == 0)
                {
                    output.AppendLine(beforeAfterSymbol + symbol + beforeAfterSymbol);
                }
                else
                {
                    betweenSymbols = new string(' ', (i * 2) - 1);

                    output.AppendLine(beforeAfterSymbol + symbol + betweenSymbols + symbol + beforeAfterSymbol);
                }

                output.AppendLine();
            }

            for (int i = 0; i < size; i++)
            {
                if ((i & 1) == 1)
                {
                    output.Append(' ');
                }
                else
                {
                    output.Append(symbol);
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
