
namespace _02.TheSecretsOfNumbers
{
    using System;
    using System.Text;

    class TheSecretsOfNumbers
    {
        static void Main(string[] args)
        {
            const int lettersInEnglish = 26;

            string inputStr;
            long specialSum = 0;
            char[] digits;
            int currentPositionInInput = 1;
            
            StringBuilder output = new StringBuilder();
            string numberInString;

            inputStr = Console.ReadLine();
            digits = inputStr.ToCharArray();
            numberInString = inputStr;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == '-')
                {
                    continue;
                }

                if ((currentPositionInInput & 1) == 1)
                {
                    specialSum += ((digits[i] - '0') * currentPositionInInput * currentPositionInInput);
                }
                else
                {
                    specialSum += ((digits[i] - '0') * (digits[i] - '0') * currentPositionInInput);
                }

                currentPositionInInput++;
            }

            int reminder = Convert.ToInt32(specialSum % lettersInEnglish);
            int alphaSeqLen = Convert.ToInt32(specialSum % 10);

            for (int i = 0; i < alphaSeqLen; i++)
            {
                reminder += 1;
                switch (reminder)
                {
                    //case 1: output.Append("A"); break;
                    case 2: output.Append("B"); break;
                    case 3: output.Append("C"); break;
                    case 4: output.Append("D"); break;
                    case 5: output.Append("E"); break;
                    case 6: output.Append("F"); break;
                    case 7: output.Append("G"); break;
                    case 8: output.Append("H"); break;
                    case 9: output.Append("I"); break;
                    case 10: output.Append("J"); break;
                    case 11: output.Append("K"); break;
                    case 12: output.Append("L"); break;
                    case 13: output.Append("M"); break;
                    case 14: output.Append("N"); break;
                    case 15: output.Append("O"); break;
                    case 16: output.Append("P"); break;
                    case 17: output.Append("Q"); break;
                    case 18: output.Append("R"); break;
                    case 19: output.Append("S"); break;
                    case 20: output.Append("T"); break;
                    case 21: output.Append("U"); break;
                    case 22: output.Append("V"); break;
                    case 23: output.Append("W"); break;
                    case 24: output.Append("X"); break;
                    case 25: output.Append("Y"); break;
                    case 26: output.Append("Z"); break;
                    default:
                        reminder = 1;
                        output.Append("A");
                        break;
                }
            }

            if (output.Length == 0)
            {
                output.AppendFormat("{0} has no secret alpha-sequence", numberInString);
            }

            Console.WriteLine(specialSum);
            Console.WriteLine(output.ToString());
        }
    }
}
