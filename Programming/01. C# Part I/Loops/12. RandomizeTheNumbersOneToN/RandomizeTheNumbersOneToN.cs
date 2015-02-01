// ### Problem 12.* Randomize the Numbers 1…N
// * Write a program that enters in integer `n` and prints the numbers `1, 2, …, n` in random order.
// 
// _Examples:_
// 
// | n                 | randomized numbers 1…n |
// |-------------------|------------------------|
// | 3                 | 2 1 3                  |
// | 10                | 3 4 8 2 6 7 9 1 10 5   |
// 
// _Note: The above output is just an example. Due to randomness, your program most probably will 
// produce different results. You might need to use arrays._

namespace _12.RandomizeTheNumbersOneToN
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class RandomizeTheNumbersOneToN
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            Random rand = new Random();
            List<int> numbers = new List<int>();
            StringBuilder output = new StringBuilder();

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            var randOrder = numbers.OrderBy(x => rand.Next());

            foreach (var number in randOrder)
            {
                output.AppendFormat("{0} ", number);
            }

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
