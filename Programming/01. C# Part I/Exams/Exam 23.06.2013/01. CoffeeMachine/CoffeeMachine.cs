
namespace _01.CoffeeMachine
{
    using System;

    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            const decimal n1 = 0.05m;
            const decimal n2 = 0.10m;
            const decimal n3 = 0.20m;
            const decimal n4 = 0.50m;
            const decimal n5 = 1.00m;

            string inputStr;
            decimal n1Amount;
            decimal n2Amount;
            decimal n3Amount;
            decimal n4Amount;
            decimal n5Amount;
            decimal devMoneyAmount;
            decimal drinkPrice;
            decimal change;
            decimal totalAmount;

            inputStr = Console.ReadLine();
            n1Amount = n1 * Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            n2Amount = n2 * Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            n3Amount = n3 * Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            n4Amount = n4 * Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            n5Amount = n5 * Convert.ToInt32(inputStr);

            inputStr = Console.ReadLine();
            devMoneyAmount = Convert.ToDecimal(inputStr);

            inputStr = Console.ReadLine();
            drinkPrice = Convert.ToDecimal(inputStr);


            if (devMoneyAmount < drinkPrice)
            {
                Console.WriteLine("More {0}", (drinkPrice - devMoneyAmount).ToString().Replace(',', '.'));
            }

            totalAmount = n1Amount + n2Amount + n3Amount + n4Amount + n5Amount;

            if (devMoneyAmount >= drinkPrice)
            {
                change = devMoneyAmount - drinkPrice;

                if (change > totalAmount)
                {
                    Console.WriteLine("No {0}", (change - totalAmount).ToString().Replace(',','.'));
                }
                else
                {
                    Console.WriteLine("Yes {0}", (totalAmount - change).ToString().Replace(',', '.'));
                }

            }

        }
    }
}
