namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        private static readonly IHand ValidFourOfAKind = new Hand(
            new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });

        private static readonly IHand ValidFlush = new Hand(
            new List<ICard>()
            {
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
            });

        private static readonly IHand InvalidCardNumberHand = new Hand(
            new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
            });

        private static readonly IHand DuplicateCardsHand = new Hand(
            new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
            });

        [TestMethod]
        public void PokerHandsChecker_IsValidHand_ShoudReturnTrue()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(ValidFourOfAKind);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PokerHandsChecker_IsFlushWithInvalidFlushHand_ShoudReturnFalse()
        {            
            PokerHandsChecker checker = new PokerHandsChecker();
            var actual = checker.IsFlush(ValidFourOfAKind);
            var expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PokerHandsChecker_IsFlushWithValidFlushHand_ShoudReturnTrue()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            var actual = checker.IsFlush(ValidFlush);
            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PokerHandsChecker_IsFourOfAKindWithInvalidFourOfAKindHand_ShoudReturnFalse()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            var actual = checker.IsFourOfAKind(ValidFlush);
            var expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PokerHandsChecker_IsFourOfAKindWithValidFourOfAKindHand_ShoudReturnTrue()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            var actual = checker.IsFourOfAKind(ValidFourOfAKind);
            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PokerHandsChecker_IsValidHandNull_ShoudThrow()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            checker.IsValidHand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsChecker_IsValidHandInvalidCardNumber_ShoudТhrow()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            checker.IsValidHand(InvalidCardNumberHand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PokerHandsChecker_IsValidHandDuplicateCards_ShoudТhrow()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            checker.IsValidHand(DuplicateCardsHand);
        }
    }
}
