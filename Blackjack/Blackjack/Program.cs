using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new Deck object named "deck" 
            Deck deck = new Deck();

            // Calls the Deck class's Shuffle() method while referencing the "deck" object we created
            deck.Shuffle();

            // This prints each card in our deck object in the order they appear in the list that is the deck object's property
            foreach (Card Card in deck.Cards)
            {
                Console.WriteLine(Card.Face + " of " + Card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            // This stops the program before it closes the window so that we can read what the program output.
            Console.Read();
        }

    }
}
