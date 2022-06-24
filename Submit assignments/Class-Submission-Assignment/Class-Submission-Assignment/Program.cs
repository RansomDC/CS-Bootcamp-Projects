using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Maths newMath = new Maths();

            Console.WriteLine("Enter a whole number:");
            int input = Convert.ToInt32(Console.ReadLine());

            int divided;
            newMath.Multiply(input, out divided);

            Console.WriteLine(divided);
            Console.Read();
        }
    }
}
