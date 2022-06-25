using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class Game
    {
        //These are the class properties
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //This declares that any child class of Game must implement a Play() method.
        public abstract void Play();

        //This is a virtual method, which means that it contains functionality but can be altered in the inheriting class. This method MUST be implemented within the inheriting class
        public virtual void ListPlayers()
        {
            //a for each loop that lists all of the players
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
