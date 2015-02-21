// Problem 2. Maximal sum
// * Write a program that reads a rectangular matrix of size N x M 
//   and finds in it the square 3 x 3 that has maximal sum of its elements.

namespace _02.MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int[,] subMatrix;
            int subMatrixSize = 3;

            matrix = ReadMatrix();

            subMatrix = FindMaxSubMatrix(matrix, subMatrixSize);

            PrintMatrix(subMatrix);
        }


        private static int[,] ReadMatrix()
        {
            string inputStr;
            int rows;
            int cols;
            int[,] matrix;

            Console.Write("number of rows: ");
            inputStr = Console.ReadLine();
            rows = Convert.ToInt32(inputStr);
            Console.Write("number of cols: ");
            inputStr = Console.ReadLine();
            cols = Convert.ToInt32(inputStr);

            while (rows < 4 || cols < 4)
            {
                Console.Clear();
                Console.WriteLine("please input rows and cols bigger than 3");
                Console.Write("number of rows: ");
                inputStr = Console.ReadLine();
                rows = Convert.ToInt32(inputStr);
                Console.Write("number of cols: ");
                inputStr = Console.ReadLine();
                cols = Convert.ToInt32(inputStr);
            }

            matrix = new int[rows, cols];

            Console.WriteLine("please input {0} elements of the row of the matrix separated by space", cols);

            for (int i = 0; i < rows; i++)
            {
                inputStr = Console.ReadLine();
                string[] inputArr = inputStr.Split(' ');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(inputArr[j]);
                }
            }

            return matrix;
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

        private static int[,] FindMaxSubMatrix(int[,] matrix, int subMatSize)
        {
            int[,] subMatrix = new int[subMatSize, subMatSize];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    sum = SumOfSubMatrix(matrix, i, j, subMatSize);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumRow = i;
                        maxSumCol = j;
                    }
                }
            }

            subMatrix = FillSubMatrix(matrix, maxSumRow, maxSumCol, 3);

            return subMatrix;
        }

        private static int SumOfSubMatrix(int[,] matrix, int row, int col, int subMatSize)
        {
            int sum = 0;

            for (int i = row - (subMatSize / 2); i <= row + (subMatSize / 2); i++)
            {
                for (int j = col - (subMatSize / 2); j <= col + (subMatSize / 2); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static int[,] FillSubMatrix(int[,] matrix, int maxSumRow, int maxSumCol, int subMatSize)
        {
            int[,] subMatrix = new int[subMatSize, subMatSize];
            int subMatRow = 0;
            int subMatCol = 0;

            for (int i = maxSumRow - (subMatSize / 2); i <= maxSumRow + (subMatSize / 2); i++)
            {
                for (int j = maxSumCol - (subMatSize / 2); j <= maxSumCol + (subMatSize / 2); j++)
                {
                    subMatrix[subMatRow, subMatCol] = matrix[i, j];
                    subMatCol++;
                }

                subMatCol = 0;
                subMatRow++;
            }

            return subMatrix;
        }

    }
}
