using System;

namespace DeckOfCards
{
    public static class Program
    {
        public static void Main()
        {
            // Create a deck cards.
            Deck deck = new Deck();

            /*
             * for (int i = 0; i < deck.Cards.Length; i++)
            {
                Console.WriteLine(deck.Cards[i].GetFullName());
            }
            */

            // Draw a card.
            Card card = deck.Draw();

            // Show the value.
            Console.WriteLine(card.GetFullName());

            Console.ReadLine();
        }
    }
}