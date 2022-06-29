using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.Write("It is currently: ");
            //Creates a new DateTime object at NOW and prints that time to the console
            Console.WriteLine(DateTime.Now);

            //Asks the user for a number and converts it to an int
            Console.WriteLine("Please input a number and I'll tell you what time it will be in that many hours.");
            int input = Convert.ToInt32(Console.ReadLine());

            // Creates a new DateTime object and sets it to a number of hours equal to the integer the user input.
            Console.WriteLine("It will be {0} in {1} hours", DateTime.Now.AddHours(input), input);

            Console.Read();
        }
    }
}
