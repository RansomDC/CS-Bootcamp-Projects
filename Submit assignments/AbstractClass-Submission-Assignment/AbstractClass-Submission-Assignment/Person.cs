using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Submission_Assignment
{
    public abstract class Person
    {
        // Person class properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // method to pring the properties of the class. It is given the "virtual" keyword which allows it to be altered by classes than inherit from this class.
        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
