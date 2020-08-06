using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game
{
    class Deck
    {
        private List<Card> cardsList;

        public Deck()
        {
            cardsList = new List<Card>();
            SheffleNewDeck();
        }

        public List<Card> Cards
        {
            get
            {
                return this.cardsList;
            }
            set
            {
                this.cardsList = value;
            }
        }

        public void SheffleNewDeck()
        {
            Random Ran = new Random();

            cardsList.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Card card = new Card
                    {
                        Value = (CardValue)j,
                        Suit = (CardSuit)i
                    };
                    cardsList.Add(card);
                }
            }

            cardsList = cardsList.OrderBy(x => Ran.Next()).ToList();
        }

        public Card DrawCard(Hand hand)
        {
            Card drawn = cardsList[Cards.Count - 1];
            cardsList.Remove(drawn);
            hand.Cards.Add(drawn);
            return drawn;
        }
    }

    [Serializable]
    internal class DeckException : Exception
    {
        public DeckException()
        {

        }

        public DeckException(string message) : base(message)
        {

        } 

        public DeckException(string message, Exception innerException) : base(message, innerException)
        {

        } 

        public DeckException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}