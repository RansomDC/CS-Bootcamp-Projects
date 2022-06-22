using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the car insurance questionaire\nplease answer the following questions:\n");
            
            
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            bool checkAge = int.TryParse(ageInput, out int n);
            while (!checkAge)
            {
                Console.WriteLine("Please enter numerical values only (1, 3, 6, etc.)");
                Console.WriteLine("What is your age?");
                ageInput = Console.ReadLine();
                // This line updates the while loop to see if it needs to iterate again
                checkAge = int.TryParse(ageInput, out int m);
            }

            // Asks a question of the user and gets the necessary data.
            Console.WriteLine("Have you ever had a DUI? (Y/N)");
            string DUIInput = Console.ReadLine();
            // A loop to continue to request Y or N from the user if the user does not enter one of those values.
            while (DUIInput != "Y" && DUIInput != "N")
            {
                Console.WriteLine("Please enter only Y or N");
                Console.WriteLine("Have you ever had a DUI? (Y/N)");
                DUIInput = Console.ReadLine();
            }

            // Asks a question of the user and gets the necessary data.
            Console.WriteLine("How many speeding tickets have you had? (Use Numbers only please)");
            string ticketsInput = Console.ReadLine();
            bool isNumber = int.TryParse(ticketsInput, out int p);
            // A loop to continue to request numerical values if the user does not enter one.
            while (!isNumber)
            {
                Console.WriteLine("Please enter numerical values only (1, 3, 6, etc.)");
                Console.WriteLine("How many speeding tickets have you had? (Use Numbers only please)");
                ticketsInput = Console.ReadLine();
                // This line updates the while loop to see if it needs to iterate again
                isNumber = int.TryParse(ticketsInput, out int o);
            }

            // Here we convert the inputs into useable values
            // This converts the age to an integer
            int age = Convert.ToInt32(ageInput);

            // This converts the input of the DUI to either a true or false.
            bool DUI;
            if (DUIInput == "Y")
            {
                DUI = true;
            }
            else
            {
                DUI = false;
            }

            // This converts the tickets input to an integer
            int tickets = Convert.ToInt32(ticketsInput);

            // Logical check to see if age is greater than or equal to 18, if the person has ha da DUI, and if the person has had less than 3 speeding tickets
            if (age > 15 && !DUI && tickets <= 3)
            {
                Console.WriteLine("You are elegible for car insurance!");
            }
            else
            {
                Console.WriteLine("Sorry, but you're not elegible for car insurance.");
            }


            Console.Read();

        }
    }
}
