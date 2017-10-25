namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void Hand_InitWithValidCards_ShouldReturnCorrectInfo()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Jack, CardSuit.Spades));

            Hand currentHand = new Hand(cards);

            Assert.AreEqual(cards, currentHand.Cards);
        }

        [TestMethod]
        public void Hand_ToString_ShouldReturnCorrectInfo()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Jack, CardSuit.Spades));
            string expected = "Four of Diamonds, Jack of Spades";

            Hand currentHand = new Hand(cards);

            Assert.AreEqual(expected, currentHand.ToString());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Hand_InitWithNullHand_ShouldThrow()
        {
            Hand currentHand = new Hand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Hand_InitWithNullCardInHand_ShouldThrow()
        {
            IList<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(null);

            Hand currentHand = new Hand(cards);
        }
    }
}
