using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignment
{
    public abstract class Person
    {
        // Person class properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // A base method that must be included on any child classes
        public abstract void SayName();
    }
}
