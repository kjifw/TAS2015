
namespace _08.To10.MatrixAndMatrixOperations
{
    using System;

    class MatrixAndMatrixOperationsTest
    {
        static void Main(string[] args)
        { 
            // for tasks conditions refer to Tasks.txt in the current project
            Matrix<int> first = new Matrix<int>(3, 3);
            Matrix<int> second = new Matrix<int>(3, 3);

            int temp = 0;
            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < first.GetLength(1); j++)
                {
                    first[i, j] = i + j + temp;
                    temp++;
                }
            } 
            
            for (int i = 0; i < second.GetLength(0); i++)
            {
                for (int j = 0; j < second.GetLength(1); j++)
                {
                    second[i, j] = i + j;
                }
            }

            Matrix<int> sum = first + second;
            Matrix<int> sub = first - second;
            Matrix<int> mult = first * second;

            Console.WriteLine(first);
            Console.WriteLine(second);

            Console.WriteLine("sum of matrices: ");
            Console.WriteLine(sum);

            Console.WriteLine("subtraction of matrices");
            Console.WriteLine(sub);

            Console.WriteLine("multiplication of matrices: ");
            Console.WriteLine(mult);
        }
    }
}
