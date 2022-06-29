using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// In order to include this in a using statement, we had to build the Casino project and then add it as a reference by browsing the computer and finding the .dll file for it.
using Casino;
using Casino.Blackjack;


namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is simply showing off creating a constant in C#
            const string casinoName = "The Grand Hotel and Casino";
            Console.WriteLine("Welcome to {0}. Let's start gy telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcom {0}! How much money did you bring to play with today?", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! Would you like to start a game of blackjack?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yah" || answer == "yep")
            {
                // Calls the Player constructor and fills in the required values (name and balance)
                Player player = new Player(playerName, bank);

                //Creates a Guid and populates the Guid property of the player object we just made
                player.Id = Guid.NewGuid();
                //We are going to use this to log the Guid to our text document.
                using (StreamWriter file = new StreamWriter(@"C:\Users\Ranso\Documents\Programming\CS-Bootcamp-Projects\Blackjack\TextLogging.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                // Creates a new game of Blackjack
                Game game = new BlackJackGame();
                // Uses the overloaded operator + to add the player object we created to the game object we created
                game += player;
                // Sets the activelyPlaying property of player to true
                player.isActivelyPlaying = true;

                //This makes it so that unless the player is out of money or chooses to not play anymore, they continue to play the game
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //When the while loop ends this removes the player form the game and then prints a message to them 
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. bye fo rnow!");



            // This stops the program before it closes the window so that we can read what the program output.
            Console.Read();
        }

    }
}
