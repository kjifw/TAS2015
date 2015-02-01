
namespace _02.ApplesOrOranges
{
    using System;

    class ApplesOrOranges
    {
        static void Main(string[] args)
        {
            string inputStr;
            long number;
            long evenSum = 0;
            long oddSum = 0;
            string result;
            long currentDigit;

            inputStr = Console.ReadLine();
            number = Math.Abs(Convert.ToInt64(inputStr));

            while (number > 0)
            {
                currentDigit = number % 10;
                
                if ((currentDigit & 1) == 1)
                {
                    oddSum += currentDigit;
                }
                else
                {
                    evenSum += currentDigit;
                }

                number /= 10;
            }

            if (oddSum > evenSum)
            {
                result = "oranges " + oddSum.ToString();
            }
            else if (oddSum < evenSum)
            {
                result = "apples " + evenSum.ToString();
            }
            else
            {
                result = "both " + evenSum;
            }

            Console.WriteLine(result);
        }
    }
}
