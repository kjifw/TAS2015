using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        private IList<ICard> cards;

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards 
        {
            get 
            {
                return this.cards;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Hand cannot be null.");
                }

                foreach (var item in value)
                {
                    if (item == null)
                    {
                        throw new ArgumentNullException("Card cannot be null.");
                    }
                }

                this.cards = value;
            }
        }

        public override string ToString()
        {
            string handInfo = string.Join(", ", this.Cards);

            return handInfo;
        }
    }
}
