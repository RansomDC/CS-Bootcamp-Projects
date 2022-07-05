using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main()
        {
            //A general try catch block to make sure that the code is not throwing errors
            try
            {
                Console.WriteLine("Please enter your age");
                int ageInput = Convert.ToInt32(Console.ReadLine());

                // Checks if the age input was <= 0 throws an exception if it was
                if (ageInput <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Gets the current datetime and sets it to the variable currentDateTime
                DateTime currentDateTime = new DateTime();
                currentDateTime = DateTime.Now;

                // Creates a new DateTime object named YOB and sets it to the current date time minus the number of years in age input. (Subtracting years is accomplished by using the .AddYears() method with a negative number.
                DateTime YOB = new DateTime();
                YOB = currentDateTime.AddYears(-ageInput);


                // Prints only the year of the the whole YOB DateTime object by accessing the Year property
                Console.Write("You're year of birth was: ");
                Console.WriteLine(YOB.Year);

                Console.Read();
            }
            // This closes the program if the age was <= 0
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Oops, your age cannot be less than or equal to zero. Closing the program.");
                Console.Read();
                return;
            }
            // This closes the program if there was any other type of exception
            catch (Exception)
            {
                Console.WriteLine("An error occured, please restart the program to try again. Closing now...");
                Console.Read();
                return;
            }




        }
    }
}
