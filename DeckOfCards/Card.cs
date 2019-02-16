﻿namespace DeckOfCards
{
    public class Card
    {
        public string FaceValue { get; set; }

        public string Suit { get; set; }

        public string GetFullName()
        {
            // these == values should be Enums

            // TODO: Return the full name of the card. Ex: 2 of Hearts
            string fullName = FaceValue + " of " + Suit;

            return fullName;
        }
    }
}