using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication_Assignment_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes input from user and multiplies it by 50
            Console.WriteLine("Input a number:");
            string multInput = Console.ReadLine();
            int multNumber = Convert.ToInt32(multInput);
            multNumber = multNumber * 50;
            Console.WriteLine(multNumber);

            //Takes input from user and adds 25
            Console.WriteLine("Input a number:");
            string addInput = Console.ReadLine();
            int addNumber = Convert.ToInt32(addInput);
            addNumber = addNumber + 25;
            Console.WriteLine(addNumber);

            // Takes input from user and divides it by 12.5
            Console.WriteLine("Input andother number");
            string divideInput = Console.ReadLine();
            float divideNumber = float.Parse(divideInput, CultureInfo.InvariantCulture.NumberFormat);
            divideNumber = divideNumber / 12.5f;
            Console.WriteLine(divideNumber);

            // Takes input from user and checks if it is larger than 50
            Console.WriteLine("Input andother number");
            string greaterInput = Console.ReadLine();
            int greaterNumber = Convert.ToInt32(greaterInput);
            Console.WriteLine(greaterNumber > 50);

            // Takes input from user and give is modulo of 7
            Console.WriteLine("Input andother number");
            string modInput = Console.ReadLine();
            int modulusNumber = Convert.ToInt32(modInput);
            modulusNumber = modulusNumber % 7;
            Console.WriteLine(modulusNumber);

            // Allows the user to read the last results of the calculations
            Console.Read();

        }
    }
}
