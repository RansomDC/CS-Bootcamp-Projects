using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // instantiates a new Employee object and initializes it's properties
            Employee newGuy = new Employee() { firstName = "Sample", lastName = "Student" };

            // Calls the SayName() method inherited from the Person class as altered by the employee class
            newGuy.SayName();

            //Stops the console from closing after printing the program so that we can read it.
            Console.Read();
        }
    }
}
