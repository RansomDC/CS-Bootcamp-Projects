using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // provides instructions to the user then requests an string input which is converted into an integer.
            Console.WriteLine("Please Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calls the Maths.Add method
            Console.WriteLine(Maths.Add(number));

            // Calls the Maths.Multiply method
            Console.WriteLine(Maths.Multiply(number));

            // Calls the Maths.Divide method
            Console.WriteLine(Maths.Divide(number));

            Console.Read();
        }
    }
}
