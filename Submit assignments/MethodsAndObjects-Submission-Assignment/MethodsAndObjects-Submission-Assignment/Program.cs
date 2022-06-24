using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Employee newStaff = new Employee() { firstName = "Sample", lastName = "Student", ID = 69420};

            newStaff.SayName();

            Console.Read();
        }
    }
}
