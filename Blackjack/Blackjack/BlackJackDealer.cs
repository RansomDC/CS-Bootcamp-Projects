using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // This is a class with some basic properties
    public class BlackJackDealer : Dealer
    {
        // These two properties work with each other. This was the original way to write out properties in the .NET framework. The private List portion creates a list so that it will always be available if someone tries to add data to it.
        // The  public list portion is what gives other parts of the program access to that list. The get { return _hand} set { _hand = value;} is the long form of the more familiar { get; set;}
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
