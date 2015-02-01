
namespace _04.KapichaniaBoats
{
    using System;

    class KapichaniaBoats
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            //.....*.....
            //....***....            
            for (int i = 0; i < 2 * n + 1; i++)
            {
                if (i == (2 * n + 1) / 2)
                {
                    Console.Write("*");
                    continue;
                }
                Console.Write(".");
            }

            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine();

            //...*.*.*...
            //..*..*..*..
            //.*...*...*.
            for (int row = 0; row < n - 2; row++)
            {
                //int t = n;
                //if ((n & 1) == 1)
                //{
                //    t = n;
                //}
                //else
                //{
                //    t = n - 1;
                //    if (row == 0)
                //    {
                //        continue;
                //    }
                //}
                for (int i = 0; i < n - 2 - row; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");
                for (int i = 0; i < n - 2 - row; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }

            //***********
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            //.*...*...*.
            //..*..*..*..
            for (int row = 0; row < n / 2; row++)
            {
                if ((n & 1) == 0)
                {
                    if (row == n / 2 - 1)
                    {
                        continue;
                    }
                }

                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");
                for (int i = 0; i < (n - 2) - row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < (n - 2) - row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");

                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }

            //...*****...
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(".");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine();
        }
    }
}
