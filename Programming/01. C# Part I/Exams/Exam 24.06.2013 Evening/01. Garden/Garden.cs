
namespace _01.Garden
{
    using System;

    class Garden
    {
        static void Main(string[] args)
        {
            decimal[] seedsPrice = { 
                                   0.5m,
                                   0.4m, 
                                   0.25m,
                                   0.6m, 
                                   0.3m, 
                                   0.4m };
            string inputStr;
            decimal totalCost = 0.0m;
            int totalArea = 250;
            int currentVegetable = 0;

            for (int i = 1; i <= 11; i++)
            {
                inputStr = Console.ReadLine();

                if ((i & 1) == 1)
                {
                    int seedsAmount = Convert.ToInt32(inputStr);
                    totalCost += seedsAmount * seedsPrice[currentVegetable];
                    currentVegetable++;
                }
                else
                {
                    int seedsArea = Convert.ToInt32(inputStr);
                    totalArea -= seedsArea;
                }
            }

            Console.WriteLine("Total costs: {0:0.00}", totalCost.ToString().Replace(',', '.'));

            if (totalArea > 0)
            {
                Console.WriteLine("Beans area: {0}", totalArea);
            }
            else if (totalArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
