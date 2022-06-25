using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            // This line removes the first card from the Deck.Card property
            Deck.Cards.RemoveAt(0);
        }
    }
}
