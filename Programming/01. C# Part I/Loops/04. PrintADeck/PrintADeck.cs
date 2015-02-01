// ### Problem 4. Print a Deck of 52 Cards
// * Write a program that generates and prints all possible cards from a [standard deck of 52 cards]
//   (http://en.wikipedia.org/wiki/Standard_52-card_deck) (without the jokers).
//   The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// * The card faces should start from 2 to A.
// * Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
// Use 2 nested for-loops and a switch-case statement.
//
// _output_
//
// 2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
// 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
// …  
// K of spades, K of clubs, K of hearts, K of diamonds
// A of spades, A of clubs, A of hearts, A of diamonds
// 
// _Note: You may use the suit symbols instead of text._

namespace _04.PrintADeck
{
    using System;
    using System.Text;

    class PrintADeck
    {
        static void Main(string[] args)
        {
            const int CardSuitCount = 4;
            const int CardValueCount = 13;

            string cardValue = string.Empty;
            string cardSuit = string.Empty;
            StringBuilder output = new StringBuilder();

            for (int value = 0; value < CardValueCount; value++)
            {
                switch (value)
                {
                    case 0: cardValue = "2"; break;
                    case 1: cardValue = "3"; break;
                    case 2: cardValue = "4"; break;
                    case 3: cardValue = "5"; break;
                    case 4: cardValue = "6"; break;
                    case 5: cardValue = "7"; break;
                    case 6: cardValue = "8"; break;
                    case 7: cardValue = "9"; break;
                    case 8: cardValue = "10"; break;
                    case 9: cardValue = "J"; break;
                    case 10: cardValue = "Q"; break;
                    case 11: cardValue = "K"; break;
                    case 12: cardValue = "A"; break;
                }

                for (int suit = 0; suit < CardSuitCount; suit++)
                {
                    switch (suit)
                    {
                        case 0: cardSuit = "spades"; break;
                        case 1: cardSuit = "clubs"; break;
                        case 2: cardSuit = "hearts"; break;
                        case 3: cardSuit = "diamonds"; break;
                    }

                    if (suit == CardSuitCount - 1)
                    {
                        output.AppendFormat("{0, 2} of {1}", cardValue, cardSuit);
                    }
                    else
                    {
                        output.AppendFormat("{0, 2} of {1}, ", cardValue, cardSuit);
                    }
                }

                output.Append("\n");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
