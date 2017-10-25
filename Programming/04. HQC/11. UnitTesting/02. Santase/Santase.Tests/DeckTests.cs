namespace Santase.Tests
{
    using System;
    using NUnit.Framework;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Deck_ChangeTrumpCardWithValidNew_ShouldReturnCorrectInfo()
        {
            Deck currentDeck = new Deck();
            Card trump = new Card(CardSuit.Spade, CardType.Queen);

            currentDeck.ChangeTrumpCard(trump);

            Assert.AreSame(trump, currentDeck.GetTrumpCard);
        }

        [TestCase(4)]
        [TestCase(7)]
        [TestCase(13)]
        [TestCase(21)]
        public void Deck_CardsLeft_ShouldReturnCorrectInfo(int cardsDrawn)
        {
            Deck currentDeck = new Deck();
            int allCards = 24;
            int cardsLeft = allCards - cardsDrawn;

            for (int i = 0; i < cardsDrawn; i++)
            {
                currentDeck.GetNextCard();
            }

            Assert.AreEqual(cardsLeft, currentDeck.CardsLeft);
        }

        [Test]
        [ExpectedException]
        public void Deck_DrawCardOnEmptyDeck_ShouldThrow()
        {
            Deck currentDeck = new Deck();
            int numberOfCards = 24;

            for (int i = 0; i < numberOfCards + 1; i++)
            {
                currentDeck.GetNextCard();
            }
        }
    }
}
