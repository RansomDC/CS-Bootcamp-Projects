using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Blackjack
{
    public class Dealer
    {
        // These are the properties of the Dealer class
        // Each dealer has a name
        public string Name { get; set; }
        // Each dealer has a deck of cards
        public Deck Deck{ get; set; }
        // Each dealer has a number of chips (which is their balance)
        public int Balance { get; set; }

        // This method is passed a specific hand object (normally one that has been shuffled)
        public void Deal(List<Card> Hand)
        {
            //This line is accessing the "Cards" property of the "Deck" property in the Dealer class (Deck.Cards or this.Deck.Cards) and is calling the list method First() to retrieve the first card of the deck
            // The .Add() adds that that card it to the Hand property
            Hand.Add(Deck.Cards.First());
            //This sets the card to a string
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            // This creates a new StreamWriter object provides the path where we want the string to go and then says "true" which is the parameter that asks if you want to append
            using (StreamWriter file = new StreamWriter(@"C:\Users\Ranso\Documents\Programming\CS-Bootcamp-Projects\Blackjack\TextLogging.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
                // Once the closing bracket below is hit everything aboce is cleaned up by the memory manager. This is what the "using" statement does
            }
            // This line removes the first card from the Deck.Card property
            Deck.Cards.RemoveAt(0);
        }
    }
}
