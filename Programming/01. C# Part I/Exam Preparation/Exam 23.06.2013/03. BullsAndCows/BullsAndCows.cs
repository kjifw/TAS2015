
namespace _03.BullsAndCows
{
    using System;
    using System.Collections.Generic;

    class BullsAndCows
    {
        static void Main(string[] args)
        {
            string inputStr;
            List<int> secretNumber = new List<int>();
            //List<int> guessNumber = new List<int>();
            int bulls;
            int cows;

            inputStr = Console.ReadLine();
            for (int i = 0; i < inputStr.Length; i++)
            {
                secretNumber.Add(inputStr[i]);
            }

            inputStr = Console.ReadLine();
            bulls = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            cows = Convert.ToInt32(inputStr);



        }
    }
}
