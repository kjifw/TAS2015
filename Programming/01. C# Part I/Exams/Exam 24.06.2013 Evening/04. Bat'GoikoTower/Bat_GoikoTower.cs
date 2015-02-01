
namespace _04.Bat_GoikoTower
{
    using System;

    class Bat_GoikoTower
    {
        static void Main(string[] args)
        {
            string inputStr;
            int rowsCount;
            int algoStep = 1;
            int dashRow = 0;
            bool hitOnDashRow = false;

            inputStr = Console.ReadLine();
            rowsCount = Convert.ToInt32(inputStr);

            for (int currentRow = 0; currentRow < rowsCount; currentRow++)
            {
                int n = rowsCount;

                for (int i = 0; i < n - currentRow - 1; i++)
                {
                    Console.Write(".");
                }

                Console.Write("/");

                for (int i = 0; i < 2 * currentRow; i++)
                {
                    if (currentRow == 1 || currentRow == dashRow + algoStep)
                    {
                        Console.Write("-");
                        if (hitOnDashRow == false)
                        {
                            hitOnDashRow = true;
                        }
                    }
                    else
                    {
                        Console.Write(".");
                        if (hitOnDashRow)
                        {
                            hitOnDashRow = false;
                        }
                    }
                }

                if (hitOnDashRow)
                {
                    dashRow = currentRow;
                    algoStep++;
                }


                Console.Write("\\");

                for (int i = 0; i < n - currentRow - 1; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }
        }
    }
}
