// ### Problem 2. Bonus Score
// * Write a program that applies bonus score to given score in the range `[1…9]` by the following rules:
// * If the score is between `1` and `3`, the program multiplies it by `10`.
// * If the score is between `4` and `6`, the program multiplies it by `100`.
// * If the score is between `7` and `9`, the program multiplies it by `1000`.
// * If the score is `0` or more than `9`, the program prints `“invalid score”`.
// 
// _Examples:_
// 
// | score | result        |
// |-------|---------------|
// | 2     | 20            |
// | 4     | 400           |
// | 9     | 9000          |
// | -1    | invalid score |
// | 10    | invalid score |

namespace _02.BonusScore
{
    using System;

    class BonusScore
    {
        static void Main(string[] args)
        {
            const string InvalidScore = "invalid score";

            string inputStr;
            int score;
            int bonus;
            string result;

            inputStr = Console.ReadLine();
            score = Convert.ToInt32(inputStr);

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    bonus = score * 10;
                    result = bonus.ToString();
                    break;
                case 4:
                case 5:
                case 6:
                    bonus = score * 100;
                    result = bonus.ToString();
                    break;
                case 7:
                case 8:
                case 9:
                    bonus = score * 1000;
                    result = bonus.ToString();
                    break;
                default:
                    result = InvalidScore;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
