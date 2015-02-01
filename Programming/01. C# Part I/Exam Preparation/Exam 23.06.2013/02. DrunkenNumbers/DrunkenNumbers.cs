
namespace _02.DrunkenNumbers
{
    using System;

    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            string inputStr;
            int totalRounds;
            int firstCompatitorBeers = 0;
            int secondCompatitorBeers = 0;

            inputStr = Console.ReadLine();
            totalRounds = Convert.ToInt32(inputStr);

            for (int round = 0; round < totalRounds; round++)
            {
                inputStr = Console.ReadLine().TrimStart(new char[] { '-', '0' });
                int length;

                if ((inputStr.Length & 1) == 1)
                {
                    length = inputStr.Length / 2 + 1;
                }
                else
                {
                    length = inputStr.Length / 2;
                }

                for (int j = 0, k = inputStr.Length - 1; j < length; j++, k--)
                {
                    firstCompatitorBeers += (inputStr[j] - '0');
                    secondCompatitorBeers += (inputStr[k] - '0');
                }
            }

            if (firstCompatitorBeers > secondCompatitorBeers)
            {
                Console.WriteLine("M {0}", firstCompatitorBeers - secondCompatitorBeers);
            }
            else if (firstCompatitorBeers == secondCompatitorBeers)
            {
                Console.WriteLine("No {0}", firstCompatitorBeers + secondCompatitorBeers);
            }
            else
            {
                Console.WriteLine("V {0}", secondCompatitorBeers - firstCompatitorBeers);
            }
        }
    }
}
