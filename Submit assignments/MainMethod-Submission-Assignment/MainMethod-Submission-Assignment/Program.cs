using System;
using System.Collections.Generic;

namespace MainMethod_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            myClass newMath = new myClass();

            // Calls the int version of the overloaded Math method of class newMath
            Console.WriteLine(newMath.Math(5));

            // Calls the decimal version of the overloaded Math method of class newMath
            Console.WriteLine(newMath.Math(5m));

            // Calls the string version of the overloaded Math method of class newMath
            Console.WriteLine(newMath.Math("6"));

            Console.Read();
        }
    }
}
