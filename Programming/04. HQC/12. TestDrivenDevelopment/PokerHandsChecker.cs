namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int validNumberOfCards = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null.");
            }

            if (hand.Cards.Count != validNumberOfCards)
            {
                throw new ArgumentException("Incorrect number of cards in hand.");
            }

            bool areDuplicatesInHand = hand.Cards
                .GroupBy(x => new { x.Face, x.Suit})
                .Where(x => x.Skip(1).Any())
                .ToList().Count >= 1;

            if (areDuplicatesInHand)
            {
                throw new ArgumentException("Hand cannot contain duplicate values");
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            IsValidHand(hand);

            bool fourOfAKind = false;
            var first = hand.Cards.First();

            fourOfAKind = hand.Cards.GroupBy(x => x.Face).Any(x => x.Count() == 4);

            return fourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            IsValidHand(hand);

            bool flush = false;
            ICard first = hand.Cards.First();

            flush = hand.Cards.GroupBy(x => x.Suit).Count() == 1;

            return flush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
