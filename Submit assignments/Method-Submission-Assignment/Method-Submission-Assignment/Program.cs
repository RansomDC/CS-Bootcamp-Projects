using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Maths mathTest = new Maths();

            // print instruction for user and get input. Convert input to integer
            Console.WriteLine("Please enter a whole number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // print instruction for user and get input as string
            Console.WriteLine("Enter a second number (Optional, press 'Enter' to skip)");
            string input2 = Console.ReadLine();
           
            // if user chose to not enter second input run method with default second parameter
            if (input2 == "")
            {
                // Call and print class method
                Console.WriteLine(mathTest.MathIsFun(num1));
            }
            // if user chose to enter value for second input run method with manual second parameter
            else
            {
                // Convert second input to integer
                int num2 = Convert.ToInt32(input2);
                // Call and print class method
                Console.WriteLine(mathTest.MathIsFun(num1, num2));
            }

            Console.Read();
        }
    }
}
