using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // A simple class that determines the properties of a single card
    public struct Card
    {
        //There are only two properties (that we care about) of a playing card. Suit and Face.
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    // Declares an enum, which is a set of possible values for a parameter to have. It is a type of class so we have made the Suit parameter which was simply string a data type of Suit, which has limited options on what the values can actually be.
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
