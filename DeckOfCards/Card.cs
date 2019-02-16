namespace DeckOfCards
{
    public class Card
    {
        public string FaceValue { get; set; }

        public string Suit { get; set; }

        public string GetFullName()
        {
            // TODO: Return the full name of the card. Ex: 2 of Hearts
            string fullName;


            if (FaceValue == "13")
            {
                fullName = "King";
            }
            else if (FaceValue == "12")
            {
                fullName = "Queen";
            }
            else if (FaceValue == "11")
            {
                fullName = "Jack";
            }
            else if (FaceValue == "1")
            {
                fullName = "Ace";
            }
            else
            {
                fullName = FaceValue;
            }


            if (Suit == "0")
            {
                fullName = fullName + " of Hearts";
            }
            else if (Suit == "1")
            {
                fullName = fullName + " of Diamonds";
            }
            else if (Suit == "2")
            {
                fullName = fullName + " of Clubs";
            }
            else 
            {
                fullName = fullName + " of Spades ";
            }
            
            return fullName;
        }
    }
}