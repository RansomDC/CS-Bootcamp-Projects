using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Submission_Assignment
{
    // This class "Employee" inherits from the "Person" class
    class Employee : Person
    {
        // the "override" part of this method declaration fulfills the requirement for from the parent class that the SayName() method must be declared by the child.
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
