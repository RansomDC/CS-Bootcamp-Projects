using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    // This creates the Employee class that we will be comparing
    public class Employee
    {
        // This is the ID parameter that we will be comparing with the overloaded operator
        public int ID { get; set; }

        // This overloads the == operator so that it compares the IDs of the two Employee objects
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID ? true : false;
        }

        // When overloading the == operator you need to overload the != operator as well, so although we will not use this for the test, it is necessary for this overload to be present.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID ? true : false;

        }
    }
}
