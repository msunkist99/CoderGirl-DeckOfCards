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

            // TODO: Load the card deck with a standard deck of 52 cards.  Use loops, do not hard code each one.
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Card card = new Card();
                    card.Suit = i.ToString();
                    card.FaceValue = j.ToString();

                    deckOfCards[cardCount] = card;
                    cardCount++;
                }
            }

            Cards = deckOfCards;
        }

        public Card[] Cards { get; set; }

        public Card Draw()
        {
            // TODO: Return a random card from the deck.
            return null;
        }
    }
}