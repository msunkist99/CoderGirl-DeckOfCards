using System;

namespace DeckOfCards
{
    public class Deck
    {
        private Random _random;

        public Deck()
        {
            Card[] deckOfCards = new Card[52];
            int cardCount = 0;
            _random = new Random();

            string suit;

            // TODO: Load the card deck with a standard deck of 52 cards.  Use loops, do not hard code each one.
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    suit = "Hearts";
                }
                else if (i == 1)
                {
                    suit = "Diamonds";
                }
                else if (i == 2)
                {
                    suit = "Clubs";
                }
                else
                {
                    suit = "Spades";
                }


                for (int j = 1; j < 14; j++)
                {
                    Card card = new Card();
                    card.Suit = suit;

                    if (j == 1)
                    {
                        card.FaceValue = "Ace";
                    }
                    else if (j == 11)
                    {
                        card.FaceValue = "Jack";
                    }
                    else if (j == 12)
                    {
                        card.FaceValue = "Queen";
                    }
                    else if (j == 13)
                    {
                        card.FaceValue = "King";
                    }
                    else
                    {
                        card.FaceValue = j.ToString();
                    }

                    deckOfCards[cardCount] = card;
                    cardCount++;
                }
            }

            Cards = deckOfCards;
        }

        public Card[] Cards { get; set; }

        public Card Draw()
        {
            int random = _random.Next(0, 53);
                        
            // TODO: Return a random card from the deck.
            return Cards[random];
        }
    }
}