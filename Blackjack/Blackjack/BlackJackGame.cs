using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    //This class inherits from the Game clas (which is an abstract class)
    class BlackJackGame : Game
    {
        //
        public override void Play()
        {
            throw new NotImplementedException();
        }

        // This method is inherited from the abstract class Game, and must be implemented here.
        // When a new instance of BlackJackGame is created, it will be populated with players (which go into a list) This property is found in the Game class
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack players: ");
            // This line appears when the method being called has some base functionality in the parent method, and is basically a placeholder for that functionality
            base.ListPlayers();
        }
    }
}
