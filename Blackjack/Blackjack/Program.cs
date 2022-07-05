using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// In order to include this in a using statement, we had to build the Casino project and then add it as a reference by browsing the computer and finding the .dll file for it.
using Casino;
using Casino.Blackjack;
// This is necessary to perform CRUD on our database
using System.Data.SqlClient;
using System.Data;

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

            // This is a check to see if the user is an admin, and if they are it will run a function that prints the recent errors to the console.
            if(playerName.ToLower() == "admin")
            {
                //This is going to create a list of all of the exceptions that will be returned by the ReadExceptions() function
                List<ExceptionEntity> Exceptions = ReadExceptions();
                //This is going to loop through the Exceptions List object
                foreach (var exception in Exceptions)
                {
                    //These lines will print out a single Exception's data to the console
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            // This loop asks for an input from the user. and uses the int.TryParse() method to BOTH see if the input can be converted to an integer and if it can return that value via an out parameter
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring to play with today?");
                // validAnswer remains false until a valid integer is input, and until it becomes true the while loop will continue to repeat itself
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Use digits only, and no decimals please!");
            }

            Console.WriteLine("Great! Well {0}, would you like to start a game of blackjack?", playerName);
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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.Read();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your Sytem Administrator.");
                        UpdateDbWithException(ex);
                        Console.Read();
                        return; 
                    }
                    
                
                }
                //When the while loop ends this removes the player form the game and then prints a message to them 
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. bye fo rnow!");



            // This stops the program before it closes the window so that we can read what the program output.
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            // This connection string was found by going to the SQL Server Object Explorer in VS and right clicking the table and selecting properties. There is a list of data displayed and it is one of the values.
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BlackJackGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            //Using the @ symbol below we create placeholder that will contain the data that we actually want to input
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            // "using" is a way of controlling un-managed or resources. When you are in a program and you go outside of it to access the file system or a database, anywhere that is outside of the Common Language Runtime (CLR) that is
            // risky because you are opening up resources that could use up memory or other resources. THE CLR is worried about this so to make these kinds of connections you need to open them and then close them too. The shorthand for this is "using"
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Here SqlCommand is a specific data type and we are creating a variable fo that type called "command". We will pass two things to this: Our queryString that says what specific DB table to use and the connection object we created above
                SqlCommand command = new SqlCommand(queryString, connection);
                //The line above will allow us to add the values to the queryString
                // With the next three statements we add the data types of the values we want to input into our table. By naming a parameter's datatype like this you are protecting from SQL injection
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                // command.Parameters is a list (As we can see from the .Add() method aboce) so once we have those added to the list we can access them by calling that list item and then declaring what the value is like so:
                // This whole method is being passed an exception type (called ex) so that is what we are going to use for the data here. And specifically we are going to get the data type of the ex variable and then convert it to a string
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                // Now that we have our parameters established and our query string written we can add to the database:
                connection.Open();
                // A query would be something like a SELECT statement, this is an INSERT statement so we use "ExecuteNonQuery()
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BlackJackGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // reader.Read() loops through each record that you ar getting back
                while (reader.Read())
                {
                    //For each record that comes in we create a new object for it
                    ExceptionEntity exception = new ExceptionEntity();
                    // Then we add the data from each column to each appropriate property, first though we must convert it to the data type we want. (Normally it comes back as SQL)
                    //e.g. with this line we are setting the property exception.Id to a the Id field of the reader object (after we convert that value to an int)
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close(); 
            }

            return Exceptions;
        }

    }
}
