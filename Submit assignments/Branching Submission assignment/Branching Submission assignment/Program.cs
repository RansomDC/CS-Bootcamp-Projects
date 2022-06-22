using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Branching_Submission_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below\n\nPlease enter the package's weight:");
            string weightInput = Console.ReadLine();
            int weight = Convert.ToInt32(weightInput);

            if (weight > 50)
            {
                Console.WriteLine("Sorry, this package it too heavy to be shipped by Package Express. Have a nice day!");
            }
            else
            {
                Console.WriteLine("Please enter the package's length");
                string lengthInput = Console.ReadLine();
                decimal length = System.Convert.ToDecimal(lengthInput);

                Console.WriteLine("Please enter the package's width");
                string widthInput = Console.ReadLine();
                decimal width = System.Convert.ToDecimal(widthInput);
                //float width = float.Parse(widthInput, CultureInfo.InvariantCulture.NumberFormat);

                Console.WriteLine("Please enter the package's height");
                string heightInput = Console.ReadLine();
                decimal height = System.Convert.ToDecimal(heightInput);
                //float height = float.Parse(heightInput, CultureInfo.InvariantCulture.NumberFormat);

                if ((length + width + height) > 50m)
                {
                    Console.WriteLine("Sorry, this package is too large to be shipped by Package Express. Have a nice day!");
                }
                else
                {
                    decimal quote = (((length * width * height)*weight)/100);
                    
                    Console.WriteLine("Your estimated shipping cost is: $" + quote.ToString("0.00") + "\nThank you!");
                }
            }
            Console.Read();


        }
    }
}
