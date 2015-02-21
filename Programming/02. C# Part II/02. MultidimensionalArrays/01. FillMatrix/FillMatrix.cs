// ### Problem 1. Fill the matrix
// * Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:
// a)  	                b) 	                c)                  d)*
// 1 	5 	9 	13      1 	8 	9 	16      7 	11 	14 	16      1 	12 	11 	10
// 2 	6 	10 	14      2 	7 	10 	15      4 	8 	12 	15      2 	13 	16 	9
// 3 	7 	11 	15      3 	6 	11 	14      2 	5 	9 	13      3 	14 	15 	8
// 4 	8 	12 	16      4 	5 	12 	13      1 	3 	6 	10      4 	5 	6 	7

namespace _01.FillMatrix
{
    using System;

    class FillMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int n;
            string inputStr;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            Console.Write("choose matrix type - a or b: ");
            inputStr = Console.ReadLine();

            switch (inputStr)
            {
                case "a": matrix = FillMatrixTypeA(n);
                    break;
                case "b": matrix = FillMatrixTypeB(n);
                    break;
                default: matrix = new int[n, n];
                    break;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(2, ' ') + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[,] FillMatrixTypeA(int n)
        {
            int[,] matrix = new int[n, n];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int currentElementValue = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[j, i] = currentElementValue;
                    currentElementValue++;
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixTypeB(int n)
        {
            int[,] matrix = new int[n, n];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int currentElementValue = 1;
            int currentRow = 0;
            int step = 1;

            for (int i = 0; i < rows; i++)
            {
                if ((i & 1) == 1)
                {
                    step = -1;
                }
                else
                {
                    step = 1;
                }

                for (int j = 0; j < cols; j++)
                {
                    matrix[currentRow, i] = currentElementValue;
                    currentElementValue++;
                    currentRow += step;

                    if (currentRow == rows)
                    {
                        currentRow = rows - 1;
                    }

                    if (currentRow < 0)
                    {
                        currentRow = 0;
                    }
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixTypeC(int n)
        {
            int[,] matrix = new int[n, n];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int currentElementValue = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentElementValue;
                    currentElementValue++;
                }
            }

            return matrix;
        }
    }
}
