using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // Declaring a cont variable
            const string mostCommonName = "John Smith";

            // Implicitly declaring a data type for a new variable
            var newEmployee = new Employee(42069);

            Console.WriteLine("The most commong name is {0}. So it is easy to create a new employee who's first name is {1}, who's last name is {2}, and has a unique ID number of {3}.", mostCommonName,newEmployee.firstName, newEmployee.lastName, newEmployee.ID);


            Console.Read();
        }
    }
}
