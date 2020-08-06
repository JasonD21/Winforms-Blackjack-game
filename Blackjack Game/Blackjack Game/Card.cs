using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Blackjack_Game.Properties;

namespace Blackjack_Game
{
    class Card
    {
        Image image;
        CardValue cardValue;
        CardSuit cardSuit;

        public Card()
        {
            cardValue = 0;
            cardSuit = 0;
            image = null;
        }

        public Image Image
        {
            get
            {
                return this.image;
            }
        }

        public CardValue Value
        {
            get
            {
                return this.cardValue;
            }
            set
            {
                this.cardValue = value;
                getImage();
            }
        }

        public CardSuit Suit
        {
            get
            {
                return this.cardSuit;
            }
            set
            {
                this.cardSuit = value;
                getImage();
            }
        }

        private void getImage()
        {
            if (this.cardSuit != 0 && this.cardValue != 0)
            {
                int x = 0, y = 0, height = 97, width = 73;

                switch (this.cardSuit)
                {
                    case CardSuit.Hearts:
                        y = 196;
                        break;
                    case CardSuit.Spades:
                        y = 98;
                        break;
                    case CardSuit.Clubs:
                        y = 0;
                        break;
                    case CardSuit.Diamonds:
                        y = 294;
                        break;
                    default:
                        break;
                }

                x = width * ((int)this.Value - 1);

                Bitmap source = Resources.Cards;
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                g.Dispose();

                this.image = img;
            }
        }

        public override string ToString()
        {
            string realValue = "";

            switch (cardValue)
            {
                case CardValue.Two:
                case CardValue.Three:
                case CardValue.Four:
                case CardValue.Five:
                case CardValue.Six:
                case CardValue.Seven:
                case CardValue.Eight:
                case CardValue.Nine:
                case CardValue.Ten:
                    realValue = ((int)cardValue).ToString();
                    break;
                case CardValue.Jack:
                case CardValue.Queen:
                case CardValue.King:
                case CardValue.Ace:
                    realValue = cardValue.ToString();
                    break;
                default:
                    break;
            }

            return realValue + " of " + Suit.ToString();
        }
    }

    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum CardSuit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }
}