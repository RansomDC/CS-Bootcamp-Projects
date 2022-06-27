using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    // This class creates a player with a variety of properties
    public class Player
    {
        // This property is a List<> with the "data type" Card
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //This is an operator overload. It tells the program that, when the "+" operator is used with this method that it means something different than the normal add or concatenate
        //In this case the plus operator takes a Game object and a Player object and it adds the Player object to the Game object's Players property (which is a list of player objects.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        // This is another operator overload. This one removes a player from a Game property similar to the method above.
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
