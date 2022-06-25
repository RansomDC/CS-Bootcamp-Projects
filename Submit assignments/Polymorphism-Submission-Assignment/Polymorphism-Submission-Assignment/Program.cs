using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // instantiates a new Employee object and initializes it's properties
            Employee newGuy = new Employee() { firstName = "Sample", lastName = "Student" };

            // Calls the SayName() method inherited from the Person class as altered by the employee class
            newGuy.SayName();

            // Calls the Quit() method inherited from the IQuittable interface
            newGuy.Quit();

            // Creates an IQuittable object using polymorphism to turn the Employee class into it's parent.
            IQuittable didntLastLong = new Employee() { firstName = "Short", lastName = "Timer" };

            // Calls the Iquittable object's method of Quit()
            didntLastLong.Quit();

            //Stops the console from closing after printing the program so that we can read it.
            Console.Read();
        }
    }
}
