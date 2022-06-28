using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a day of the week (e.g. Wednesday)");
            string dayInput = Console.ReadLine();

            // The try catch block tells us if the Parse() method did not work. This could also be accomplished without throwing errors by using the TryPrase() method, which returns a boolean value based off its success.
            try
            {
                //This line takes a string (dayInput) and checks if the string is a match to any of the Enumerators of the DaysEnum Enum. If it is a match, the "DaysEnum conversion" variable has it's value set to that enumerator
                DaysEnum conversion = (DaysEnum)Enum.Parse(typeof(DaysEnum), dayInput);
                Console.WriteLine("Here is the integer value of your chosen day");
                //This converts the enumerator to it's integer value to show that it is correctly being processed
                Console.WriteLine(Convert.ToInt32(conversion));
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            

            Console.Read();
        }
    }
}
