
namespace _08.To10.MatrixAndMatrixOperations
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException("Rows and Cols in matrix must be positive");
            }

            this.rows = rows;
            this.cols = cols;

            this.matrix = new T[rows, cols];
        }

        public T this[int indexRow, int indexCol]
        {
            get
            {
                if (indexRow < 0 || indexRow > this.GetLength(0))
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}", indexRow));
                }
                if (indexCol < 0 || indexCol > this.GetLength(1))
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}", indexCol));
                }

                T element = this.matrix[indexRow, indexCol];
                return element;
            }
            set
            {
                if (indexRow < 0 || indexRow > this.GetLength(0))
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}", indexRow));
                }
                if (indexCol < 0 || indexCol > this.GetLength(1))
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}", indexCol));
                }

                this.matrix[indexRow, indexCol] = value;
            }
        }

        public int GetLength(int dimension)
        {
            if (dimension != 0 && dimension != 1)
            {
                throw new ArgumentOutOfRangeException("dimensions in matrix are 2");
            }

            if (dimension == 0)
            {
                return this.rows;
            }
            else
            {
                return this.cols;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool nonZeroElement = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        nonZeroElement = true;
                        break;
                    }
                }

                if (nonZeroElement)
                {
                    break;
                }
            }

            return nonZeroElement;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            bool zeroElement = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        zeroElement = false;
                        break;
                    }
                }

                if (!zeroElement)
                {
                    break;
                }
            }

            return zeroElement;
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
            {
                throw new FormatException(string.Format("Matrices must be of the same size for addition"));
            }

            Matrix<T> sum = new Matrix<T>(first.GetLength(0), second.GetLength(1));

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }

            return sum;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
            {
                throw new FormatException(string.Format("Matrices must be of the same size for subtraction"));
            }

            Matrix<T> sub = new Matrix<T>(first.GetLength(0), second.GetLength(1));

            for (int i = 0; i < sub.GetLength(0); i++)
            {
                for (int j = 0; j < sub.GetLength(1); j++)
                {
                    sub[i, j] = (dynamic)first[i, j] - second[i, j];
                }
            }

            return sub;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.GetLength(1) != second.GetLength(0))
            {
                throw new FormatException(string.Format("Matrices must be of the same size for addition"));
            }

            Matrix<T> mult = new Matrix<T>(first.GetLength(0), second.GetLength(1));

            for (int i = 0; i < mult.GetLength(0); i++)
            {
                for (int j = 0; j < mult.GetLength(1); j++)
                {
                    for (int k = 0; k < first.GetLength(1); k++)
                    {
                        mult[i, j] += (dynamic)first[i, k] * second[k, j];
                    }                
                }
            }

            return mult;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            int rows = this.GetLength(0);
            int cols = this.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.AppendFormat("{0} ", this.matrix[i, j]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
