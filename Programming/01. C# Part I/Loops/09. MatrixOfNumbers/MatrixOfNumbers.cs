// ### Problem 9. Matrix of Numbers
// * Write a program that reads from the console a positive integer number `n` 
//   (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
// 
// _Examples:_
// 
// n = 2	matrix		n = 3	matrix		n = 4	matrix
// 		    1 2					1 2 3				1 2 3 4
// 		    2 3					2 3 4				2 3 4 5
// 			    				3 4 5				3 4 5 6
//				    								4 5 6 7

namespace _09.MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("{0, 3}", col + row);
                }

                Console.WriteLine();
            }
        }
    }
}
