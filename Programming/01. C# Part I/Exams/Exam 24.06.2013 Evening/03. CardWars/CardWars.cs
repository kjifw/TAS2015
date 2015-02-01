
namespace _03.CardWars
{
    using System;
    using System.Numerics;
    using System.Text;

    class CardWars
    {
        static void Main(string[] args)
        {
            const int numberOfCardsPerGame = 3;
            //const int zcardBonus = 2;
            //const int ycardBonus = 200;
            const int xcardBonus = 50;

            string inputStr;

            int numberOfGames;
            int firstPlayerHandStrength = 0;
            int secondPlayerHandStrength = 0;
            int firstPlayerGamesWon = 0;
            int secondPlayerGamesWon = 0;
            BigInteger firstPlayerScore = 0;
            BigInteger secondPlayerScore = 0;
            StringBuilder output = new StringBuilder();
            bool firstPlayerXCard = false;
            bool secondPlayerXCard = false;

            inputStr = Console.ReadLine();
            numberOfGames = Convert.ToInt32(inputStr);

            for (int game = 1; game <= numberOfGames; game++)
            {
                string cardValue;
                int cardPoint;
                //int firstPlayerZCardCount = 0;
                //int secondPlayerZCardCount = 0;
                //int firstPlayerYCardCount = 0;
                //int secondPlayerYCardCount = 0;
                
                for (int currentCardNumber = 1; currentCardNumber <= numberOfCardsPerGame; currentCardNumber++)
                {
                    inputStr = Console.ReadLine();
                    cardValue = inputStr;
                    cardPoint = 0;

                    switch (cardValue)
                    {
                        case "2": cardPoint = 10; break;
                        case "3": cardPoint = 9; break;
                        case "4": cardPoint = 8; break;
                        case "5": cardPoint = 7; break;
                        case "6": cardPoint = 6; break;
                        case "7": cardPoint = 5; break;
                        case "8": cardPoint = 4; break;
                        case "9": cardPoint = 3; break;
                        case "10": cardPoint = 2; break;
                        case "A": cardPoint = 1; break;
                        case "J": cardPoint = 11; break;
                        case "Q": cardPoint = 12; break;
                        case "K": cardPoint = 13; break;
                        case "Z": firstPlayerScore *= 2; break;
                        case "Y": firstPlayerScore -= 200; break;
                        case "X": firstPlayerXCard = true; break;
                    }

                    firstPlayerHandStrength += cardPoint;
                }

                for (int currentCardNumber = 1; currentCardNumber <= numberOfCardsPerGame; currentCardNumber++)
                {
                    inputStr = Console.ReadLine();
                    cardValue = inputStr;
                    cardPoint = 0;

                    switch (cardValue)
                    {
                        case "2": cardPoint = 10; break;
                        case "3": cardPoint = 9; break;
                        case "4": cardPoint = 8; break;
                        case "5": cardPoint = 7; break;
                        case "6": cardPoint = 6; break;
                        case "7": cardPoint = 5; break;
                        case "8": cardPoint = 4; break;
                        case "9": cardPoint = 3; break;
                        case "10": cardPoint = 2; break;
                        case "A": cardPoint = 1; break;
                        case "J": cardPoint = 11; break;
                        case "Q": cardPoint = 12; break;
                        case "K": cardPoint = 13; break;
                        case "Z": secondPlayerScore *= 2; break;
                        case "Y": secondPlayerScore -= 200; break;
                        case "X": secondPlayerXCard = true; break;
                    }

                    secondPlayerHandStrength += cardPoint;
                }

                if (firstPlayerXCard && secondPlayerXCard)
                {
                    firstPlayerScore += xcardBonus;
                    secondPlayerScore += xcardBonus;
                }
                else if (firstPlayerXCard)
                {
                    break;
                }
                else if (secondPlayerXCard)
                {
                    break;
                }

                #region Z and Y Cards loops if counter is used
                //for (int i = 0; i < firstPlayerZCardCount; i++)
                //{
                //    firstPlayerScore *= zcardBonus;
                //}

                //for (int i = 0; i < secondPlayerZCardCount; i++)
                //{
                //    secondPlayerScore *= zcardBonus;
                //}

                //for (int i = 0; i < firstPlayerYCardCount; i++)
                //{
                //    firstPlayerScore -= ycardBonus;
                //}

                //for (int i = 0; i < secondPlayerYCardCount; i++)
                //{
                //    secondPlayerScore -= ycardBonus;
                //}
                #endregion

                if (firstPlayerHandStrength > secondPlayerHandStrength)
                {
                    firstPlayerScore += firstPlayerHandStrength;
                    firstPlayerGamesWon++;
                }
                else if (firstPlayerHandStrength < secondPlayerHandStrength)
                {
                    secondPlayerScore += secondPlayerHandStrength;
                    secondPlayerGamesWon++;
                }

                firstPlayerXCard = false;
                secondPlayerXCard = false;
                firstPlayerHandStrength = 0;
                secondPlayerHandStrength = 0;
            }

            if (firstPlayerXCard == true)
            {
                output.AppendFormat("X card drawn! ");
                output.AppendFormat("Player one wins the match!\n");
            }
            else if (secondPlayerXCard == true)
            {
                output.AppendFormat("X card drawn! ");
                output.AppendFormat("Player two wins the match!\n");
            }
            else if (firstPlayerScore > secondPlayerScore)
            {
                output.AppendLine("First player wins!");
                output.AppendFormat("Score: {0}\n", firstPlayerScore);
                output.AppendFormat("Games won: {0}", firstPlayerGamesWon);
            }
            else if (firstPlayerScore == secondPlayerScore)
            {
                output.AppendLine("It's a tie!");
                output.AppendFormat("Score: {0}", firstPlayerScore);
            }
            else
            {
                output.AppendLine("Second player wins!");
                output.AppendFormat("Score: {0}\n", secondPlayerScore);
                output.AppendFormat("Games won: {0}", secondPlayerGamesWon);
            }

            Console.WriteLine(output.ToString());
        }
    }
}
