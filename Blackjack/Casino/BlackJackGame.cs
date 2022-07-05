using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Blackjack
{
    //This class inherits from the Game clas (which is an abstract class)
    public class BlackJackGame : Game
    {
        //One of the properties of the BlackJackGame is a BlackJackDealer
        public BlackJackDealer Dealer { get; set; }

        // This is the overarching method to play the game
        public override void Play()
        {
            
            Dealer = new BlackJackDealer();

            // This references the Players object that is found in the parent class Game. gives each player a list and sets it to empty, and sets their stay property to false (in case there was a previous game played)
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }

            // These lines reset the dealer, giving them an empty hand setting stay to false, giveing them a new deck and shuffling it
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            // This goes through the list of players and asks each for a bet (which is an int value).
            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    // validAnswer remains false until a valid integer is input, and until it becomes true the while loop will continue to repeat itself
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Use digits only, and no decimals please!");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Show them what we do to dirty cheaters!");
                }

                // This runs the player.Bet() method which returns a bool of whether they have enough money to bet the amount they want to
                bool successfullyBet = player.Bet(bet);
                // This if statement says if they don't successfully bet the method ends
                if(!successfullyBet)
                {
                    // because we are not returning anything with this method, the return statement here simply ends the method
                    return;
                }
                // This adds a key value pair to the Bets dictionary in the Game class. In the line below Bets references the dictionary, it creates a new key with [player] and sets the value of the key with = bet
                Bets[player] = bet; 
            }
            // Start the dealing process (in blackjack you only deal a hand of 2 to start with hence "i < 2"
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                // This moves through a list of players
                foreach(Player player in Players)
                {
                    // This writes the players name. (ReadLine()) is not used here because we want the next thing to be written to the conosle (which will be a card in the Dealer.Deal() method) to be on the same line.
                    Console.Write("{0}: ", player.Name);
                    // This function adds the first card from the Dealer's decklist to the current iteration of player's handlist
                    Dealer.Deal(player.Hand);
                    // i == 1 is used here to know whether the normal (for a game of blackjack) two cards have been dealt. On a game that dealt 7 cards instead this would read i == 6
                    if (i == 1)
                    {
                        // Here wer are going to call our business logic class which contains method useful for a game of blackjack
                        // This simply sees if the the combination of cards and the multiple variations that aces can have adds up to 21
                        bool blackJack = BlackJackRules.CheckForBlackJack(player.Hand);
                        // If it does return a true for blackjack the player wins
                        if (blackJack)
                        {
                            // this accesses the player's name with player.Name and the bet that player placed before with Bets(the name of the dictionary)[player](the key of key value pair that was "player name = <bet amount>"
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Console.WriteLine("Play again?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah")
                            {
                                player.isActivelyPlaying = true;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackJackRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        // This loop goes through each entry in the dictionary and adds that amount to the dealer's balance
                        foreach  (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }

                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "hit me")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackJackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = BlackJackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackJackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                //The "bool?" part of this line, makes it so that the boolean in this case can be assigned a null value (otherwise impossible because a bool is a struct and therefore a value data type)
                bool? playerWon = BlackJackRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }

        // This method is inherited from the abstract class Game, and must be implemented here.
        // When a new instance of BlackJackGame is created, it will be populated with players (which go into a list) This property is found in the Game class
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack players: ");
            // This line appears when the method being called has some base functionality in the parent method, and is basically a placeholder for that functionality
            base.ListPlayers();
        }
        //public void WalkAway(Player player)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
