using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game
{
    class Hand
    {
        private List<Card> cards;

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
        }

        public Hand(int startingHand, Deck deck)
        {
            if (deck == null)
            {
                throw new DeckException("No decks available to draw from!");
            }
            else if (deck.Cards.Count == 0)
            {
                throw new DeckException("No more cards to draw!");
            }
            else
            {
                cards = new List<Card>();
                for (int i = 0; i < startingHand; i++)
                {
                    deck.DrawCard(this);
                }
            }
        }

        public void AddValue(Card drawn, ref int currntSum)
        {
            if (drawn.Value == CardValue.Ace)
            {
                if (currntSum <= 10)
                {
                    currntSum += 11;
                }
                else
                {
                    currntSum += 1;
                }
            }
            else if (drawn.Value == CardValue.Jack || drawn.Value == CardValue.Queen || drawn.Value == CardValue.King)
            {
                currntSum += 10;
            }
            else
            {
                currntSum += (int)drawn.Value;
            }
        }
    }    
}