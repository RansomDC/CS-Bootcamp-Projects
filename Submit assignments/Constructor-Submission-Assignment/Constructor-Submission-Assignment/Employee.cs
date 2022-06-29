using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    public class Employee
    {
        // Many people have the name Jogn Smith, so we can use this chained constructor to quickly create an employee with the name John Smith and simply add a differern ID
        public Employee(int number) : this("John", "Smith", number)
        {
        }

        // This is our regular constructor for all three properties. For those few people who have unique names.
        public Employee(string fName, string lName, int number)
        {
            firstName = fName;
            lastName = lName;
            ID = number;
        }

        //Properties 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }




    }
}
