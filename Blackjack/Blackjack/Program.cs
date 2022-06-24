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
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card Card in deck.Cards)
            {
                Console.WriteLine(Card.Face + " of " + Card.Suit); 
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

    }
}
