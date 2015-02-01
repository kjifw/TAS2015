// ### Problem 11. Random Numbers in Given Range
// * Write a program that enters `3` integers `n`, `min` and `max` (`min = max`) and prints `n` random numbers in the range `[min...max]`.
// 
// _Examples:_
// 
// | n                 | min | max     |         random numbers        |
// |-------------------|-----|---------|-------------------------------|
// | 5                 | 0   | 1       | 1 0 0 1 1                     |
// | 10                | 10  | 15      | 12 14 12 15 10 12 14 13 13 11 |
// 
// _Note: The above output is just an example. Due to randomness, your program most probably will produce different results._

namespace _11.RandomNumbersInRange
{
    using System;
    using System.Text;

    class RandomNumbersInRange
    {
        static void Main(string[] args)
        {
            string inputStr;
            int min;
            int max;
            int numbersCount;
            Random rand = new Random();
            StringBuilder output = new StringBuilder();

            inputStr = Console.ReadLine();
            numbersCount = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            min = Convert.ToInt32(inputStr);
            inputStr = Console.ReadLine();
            max = Convert.ToInt32(inputStr);

            while (min >= max)
            {
                Console.Clear();
                Console.WriteLine("min < max");
                inputStr = Console.ReadLine();
                min = Convert.ToInt32(inputStr);
                inputStr = Console.ReadLine();
                max = Convert.ToInt32(inputStr);
            }

            for (int i = 0; i < numbersCount; i++)
            {
                int randomNumber = rand.Next(min, max + 1);

                output.AppendFormat("{0} ", randomNumber);
            }

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
