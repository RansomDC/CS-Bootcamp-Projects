using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main()
        {
            // Creates an object called number of type Number(a struct)
            Number number;

            // Sets the Amount property of the struct object number to 30 (decimal type).
            number.Amount = 30m;

            // Prints the value of the number object's property to the console
            Console.WriteLine(number.Amount);

            Console.Read();
        }
    }
}
