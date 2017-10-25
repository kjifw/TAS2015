namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_InitWithValidData_ShourdReturnCorrectInfo()
        {
            CardFace face = CardFace.Four;
            CardSuit suit = CardSuit.Diamonds;

            Card currentCard = new Card(face, suit);

            Assert.AreEqual(face, currentCard.Face);
            Assert.AreEqual(suit, currentCard.Suit);
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectInfo()
        {
            CardFace face = CardFace.Four;
            CardSuit suit = CardSuit.Diamonds;
            string expected = "Four of Diamonds";

            Card currentCard = new Card(face, suit);

            Assert.AreEqual(expected, currentCard.ToString());
        }
    }
}
