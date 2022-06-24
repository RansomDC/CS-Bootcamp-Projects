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

            Console.WriteLine("Please enter a whole number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number (Optional, press 'Enter' to skip)");
            string input2 = Console.ReadLine();
           

            if (input2 == "")
            {
                Console.WriteLine(mathTest.MathIsFun(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(input2);
                Console.WriteLine(mathTest.MathIsFun(num1, num2));
            }

            Console.Read();
        }
    }
}
