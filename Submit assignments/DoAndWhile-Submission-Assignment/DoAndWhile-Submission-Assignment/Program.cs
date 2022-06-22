using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAndWhile_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            int c = 0;
            bool test = true;
            // This determines the testing parameters, in this case whether the test for the last iteration is true or false. Once it it false the loop will end.
            while (test)
            {
                // This if statement checks if the value of c is below a certain threshold and returns a boolean based off of the result.
                if(c < 6)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }
                // This prints the counter variable to the console so that you can see the progress.
                Console.WriteLine(c);
                // This iterates up the variable c.
                c++;
            }


            // Set a new variable that we will use in the loop
            string input;
            // Starts a loop which will ask the user to enter a word.
            do
            {
                Console.WriteLine("Please input the word 'farmer'");
                input = Console.ReadLine();
                // If the word is "farmer" the terminal message will be printed to console. 
                if (input == "farmer")
                {
                    Console.WriteLine("Great, thanks.");
                }
            }
            // Provides the terminal requirement for the loop
            while (input != "farmer");

            Console.Read();

        }
    }
}
