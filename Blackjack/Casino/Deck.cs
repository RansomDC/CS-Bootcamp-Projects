using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
     public class Deck
    {
        // This is constructor for the Deck class. So that whenever it is called it automatically creates a full deck of 52 cards.
        public Deck()
        {
            // This sets the Cards property to being a list that can contain Card objects
            Cards = new List<Card>();
            
            for(int i= 0 ; i < 13; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)c;
                    Cards.Add(card);
                }
            }


            //// This simply declares a list of all of the different suits of cards that are possible
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            //// This simple declares a list of all of the different values (faces) of cards that are possible
            //List<string> Faces = new List<string>() { "Two", "three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            //// This loop moves through the different values (faces) of the cards
            //foreach (string face in Faces)
            //{
            //    // This loop moves through the different suits of the cards
            //    // e.g. to start out this will create 4 "Twos" one of each suit. Then it will make 4 "Threes" one of each suit, etc.
            //    foreach (string suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);
            //    }
            //}
        }

        // This is the property of the Deck class
        public List<Card> Cards { get; set; }


        // In this method declaration we can see an optional parameter (int times = 1) which will fill in the default value (1) if no parameter is used when the method is called
        // This method is used to randomize the order of the cards
        public void Shuffle(int times = 1)
        {
            // This for loop determines how many times the cards will be shuffled (default = 1)
            for (int i = 0; i < times; i++)
            {
                // This line creates a temporary list to hold the cards in
                List<Card> TempList = new List<Card>();
                // This creates a variable that produces a random number
                Random random = new Random();

                //A while loop that will stop the cards from being moved from the Cards property when there are none left
                while (Cards.Count > 0)
                {
                    // This creates a number between 0 and the number of cards left in the Cards property List and saves it to the randomIndex variable
                    int randomIndex = random.Next(0, Cards.Count);
                    //This uses the randomIndex variable to a copy of that card to the TempList List
                    TempList.Add(Cards[randomIndex]);
                    //This removes the card that was copied to the TempList List from the Cards property List
                    Cards.RemoveAt(randomIndex);
                    // Effectively we are randomly picking one card at a time and copying it to the tempList and then deleting that card from the Cards Property List until there are no cards left in the Cards Property List
                }

                // Once the previous loop is done (which means that there are no cards left in the Cards Property List) we make the Cards Property List equal to the tempList which re-populates it in the random order.
                this.Cards = TempList;
            }
        }
    }
}
