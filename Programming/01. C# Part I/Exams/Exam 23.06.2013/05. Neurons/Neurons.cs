
namespace _05.Neurons
{
    using System;
    using System.Text;

    class Neurons
    {

        static void Main(string[] args)
        {
            string inputStr;
            StringBuilder output = new StringBuilder();
            long line;

            while (true)
            {
                inputStr = Console.ReadLine();
                line = Convert.ToInt64(inputStr);

                if (line == -1)
                {
                    break;
                }

                int mostLeftBitIndex = -1;
                int mostRightBitIndex = -1;

                for (int i = 0; i < 32; i++)
                {
                    long mask = 1 << i;
                    long lineAndMask = line & mask;
                    long bit = lineAndMask >> i;

                    if (bit == 1)
                    {
                        if (mostRightBitIndex == -1)
                        {
                            mostRightBitIndex = i;
                        }

                        mostLeftBitIndex = i;
                    }                    
                }

                if (mostLeftBitIndex == -1)
                {
                    output.Append("0\n");
                    continue;
                }

                long result = 0;
                for (int i = mostRightBitIndex; i <= mostLeftBitIndex; i++)
                {
                    long mask = 1 << i;
                    long lineAndMask = line & mask;
                    long bit = lineAndMask >> i;
                    
                    if (bit == 0)
                    {
                        result = result | mask;
                    }
                }
                output.Append(result + "\n");
            }

            Console.Write(output.ToString());
        }
    }
}
