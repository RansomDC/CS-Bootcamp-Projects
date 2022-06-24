using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck{ get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            // The method passes in a Hand object. This line is accessing the "Cards" property of "Deck" (Deck.Cards) and calling the list method First() to retrieve the first card of the deck
            // The .Add() adds that that card it to the Hand property
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            // This line removes the first card from the Deck.Card property
            Deck.Cards.RemoveAt(0);
        }
    }
}
