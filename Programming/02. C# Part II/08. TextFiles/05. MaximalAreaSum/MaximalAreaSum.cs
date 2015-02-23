// Problem 5. Maximal area sum
// * Write a program that reads a text file containing a square matrix of numbers.
// * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//   * The first line in the input file contains the size of matrix N.
//   *  Each of the next N lines contain N numbers separated by space.
//   *  The output should be a single number in a separate text file.
// 
// Example:
// input 	output
// 4        17
// 2 3 3 4
// 0 2 3 4
// 3 7 1 2
// 4 3 3 2

namespace _05.MaximalAreaSum
{
    using System;
    using System.IO;
    using System.Linq;

    class MaximalAreaSum
    {
        static void Main(string[] args)
        {
            string matrixFilePath = "..//..//input.txt";
            string resultFilePath = "..//..//output.txt";
            
            int[,] matrix;
            int subMatSize = 2;
            int maxAreaSum;

            matrix = ReadMatrixFromFile(matrixFilePath);
            Console.WriteLine("Matrix successfully read from file.");

            maxAreaSum = FindMaxAreaSum(matrix, subMatSize);
            Console.WriteLine("Maximum area sum successfully calculated.");

            PrintResultToFile(resultFilePath, maxAreaSum);
            Console.WriteLine("Result saved to new file.");
            Console.WriteLine("Please check project directory for the new file.");
        }

        private static int[,] ReadMatrixFromFile(string filePath)
        {
            StreamReader fileReader = new StreamReader(filePath);
            int[,] matrix;
            string line = string.Empty;
            int matrixSize;

            using (fileReader)
            {
                line = fileReader.ReadLine();
                matrixSize = Convert.ToInt32(line);
                matrix = new int[matrixSize, matrixSize];
                int matrixRow = 0;
                
                while (line != null)
                {
                    line = fileReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    int[] numbers = line.Split(
                        new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[matrixRow, col] = numbers[col];
                    }

                    matrixRow++;
                }
            }

            return matrix;
        }

        private static void PrintResultToFile (string filePath, int result)
        {
            StreamWriter fileWriter = new StreamWriter(filePath);

            using (fileWriter)
            {
                fileWriter.WriteLine(result);
            }
        }

        private static int FindMaxAreaSum(int[,] matrix, int subMatSize)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < rows - subMatSize / 2; i++)
            {
                for (int j = 0; j < cols - subMatSize / 2; j++)
                {
                    sum = SumOfSubMatrix(matrix, i, j, subMatSize);

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            return maxSum;
        }

        private static int SumOfSubMatrix(int[,] matrix, int row, int col, int subMatSize)
        {
            int sum = 0;

            for (int i = row; i <= row + subMatSize / 2; i++)
            {
                for (int j = col; j <= col + subMatSize / 2; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}
