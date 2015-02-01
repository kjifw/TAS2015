
namespace _04.Easter_Mister
{
    using System;

    class Easter_Mister
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            //.......*****.......
            //.....*.......*.....
            //...*...........*...
            //.*...............*.
            for (int row = 0; row < n / 2 + 1; row++)
            {
                if (n > 2)
                {

                    for (int i = 0; i < n + 1 - 2 * row; i++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int i = 0; i < n - 3 + 4 * row; i++)
                    {
                        if (row == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                    Console.Write("*");

                    for (int i = 0; i < n + 1 - 2 * row; i++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }

                if (n == 2 && row == 0)
                {
                    Console.WriteLine("...*...");
                }
            }

            //.*...............*.
            for (int row = 0; row < (n - 2) / 2 - 1; row++)
            {
                Console.Write(".");
                Console.Write("*");

                for (int i = 0; i < 3 * n - 3; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");
                Console.Write(".");

                Console.WriteLine();
            }

            //.*.#.#.#.#.#.#.#.*.
            for (int i = 0; i < 3 * n + 1; i++)
            {

                if (i == 3 * n - 1 || i == 1)
                {
                    Console.Write("*");
                }
                else if ((i & 1) == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                }
            }

            Console.WriteLine();

            //.*#.#.#.#.#.#.#.#*.
            Console.Write(".");
            Console.Write("*");

            for (int i = 0; i < 3 * n - 3; i++)
            {
                if ((i & 1) == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.Write("*");
            Console.Write(".");

            Console.WriteLine();

            //.*...............*.
            for (int row = 0; row < (n - 2) / 2 - 1; row++)
            {
                Console.Write(".");
                Console.Write("*");

                for (int i = 0; i < 3 * n - 3; i++)
                {
                    Console.Write(".");
                }

                Console.Write("*");
                Console.Write(".");

                Console.WriteLine();
            }

            //.*...............*. 
            //...*...........*...
            //.....*.......*.....
            //.......*****.......
            for (int row = 0; row < n / 2 + 1; row++)
            {
                if (n > 2)
                {
                    for (int i = 0; i < 2 * row + 1; i++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("*");

                    for (int i = 0; i < 3 * n - 3 - 4 * row; i++)
                    {
                        if (row == n / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                    Console.Write("*");

                    for (int i = 0; i < 2 * row + 1; i++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }

                if (n == 2 && row == n / 2)
                {
                    Console.WriteLine("...*...");
                }
            }
        }
    }
}
