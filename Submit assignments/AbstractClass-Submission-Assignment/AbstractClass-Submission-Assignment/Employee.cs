using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Submission_Assignment
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee's name is:");
            base.SayName();
        }
    }
}
