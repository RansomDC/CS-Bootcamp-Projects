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
        // This line makes a private list so that we will always have a place to input data when data are added to the list
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        //This line makes it so that we can activate the private _players list
        public List<Player> Players { get { return _players; } set { _players = value; } }


        public string Name { get; set; }
        // This property is the dictionary that will contain the placed bets
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        

        //This declares that any child class of Game must implement a Play() method.
        public abstract void Play();

        //This is a virtual method, which means that it contains functionality but can be altered in the inheriting class. This method MUST be implemented within the inheriting class
        public virtual void ListPlayers()
        {
            //a for each loop that lists all of the players
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
