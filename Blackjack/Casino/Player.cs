using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // This class creates a player with a variety of properties
    public class Player
    {
        // This is part of a constructor call chain, which basically inherits the information of another constructor and gives someone calling a constructor to use different parameters.
        // In this case the inheriting constructor below takes a single parameter (name) instead of two parameters (name and balance). Instead it sets the name normally, and uses a default value
        // for the balance (100)
        public Player(string name) : this(name, 100)
        {
        }

        // This is a constructor for hte Player class
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }


        // This property is a List<> with the "data type" Card
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if ((Balance - amount) < 0)
            {
                Console.WriteLine("You do not have enough to place a bet of that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
