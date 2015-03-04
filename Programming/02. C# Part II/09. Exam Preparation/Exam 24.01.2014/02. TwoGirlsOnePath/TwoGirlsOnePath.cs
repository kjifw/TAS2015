
namespace _02.TwoGirlsOnePath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    class TwoGirlsOnePath
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            BigInteger[] pathArr = path.Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            StringBuilder result = new StringBuilder();

            result = FindWinner(pathArr);

            Console.WriteLine(result.ToString());
        }

        private static StringBuilder FindWinner(BigInteger[] pathArr)
        {
            BigInteger mollyFlowerCount = 0;
            BigInteger dollyFlowerCount = 0;
            BigInteger mollyStep = 0;
            BigInteger dollyStep = 0;
            StringBuilder result = new StringBuilder();

            for (BigInteger i = 0, j = pathArr.Length - 1; ; i += mollyStep, j -= dollyStep)
            {
                if (i > pathArr.Length - 1)
                {
                    i = i % pathArr.Length;
                }

                j = j % pathArr.Length;
                if (j < 0)
                {
                    j += pathArr.Length;
                }

                if (pathArr[(int)i] == 0 || pathArr[(int)j] == 0)
                {
                    if (pathArr[(int)i] != 0 && pathArr[(int)j] == 0)
                    {
                        result.AppendLine("Molly");
                    }
                    else if (pathArr[(int)i] == 0 && pathArr[(int)j] == 0)
                    {
                        result.AppendLine("Draw");
                    }
                    else
                    {
                        result.AppendLine("Dolly");
                    }

                    mollyFlowerCount += pathArr[(int)i];
                    dollyFlowerCount += pathArr[(int)j];

                    result.AppendFormat("{0} {1}", mollyFlowerCount, dollyFlowerCount);

                    break;
                }

                if (i == j)
                {
                    mollyFlowerCount += pathArr[(int)i] / 2;
                    dollyFlowerCount += pathArr[(int)j] / 2;

                    mollyStep = pathArr[(int)i];
                    dollyStep = pathArr[(int)j];

                    pathArr[(int)i] = pathArr[(int)j] % 2;
                }
                else
                {
                    mollyFlowerCount += pathArr[(int)i];
                    dollyFlowerCount += pathArr[(int)j];

                    mollyStep = pathArr[(int)i];
                    dollyStep = pathArr[(int)j];

                    pathArr[(int)i] = 0;
                    pathArr[(int)j] = 0;
                }
            }

            return result;
        }
    }
}
