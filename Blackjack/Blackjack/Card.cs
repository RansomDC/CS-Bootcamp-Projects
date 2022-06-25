using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // A simple class that determines the properties of a single card
    public class Card
    {
        //There are only two properties (that we care about) of a playing card. Suit and Face.
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
