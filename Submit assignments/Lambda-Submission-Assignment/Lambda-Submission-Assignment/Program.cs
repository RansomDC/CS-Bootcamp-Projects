using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // instantiating and initializing 10 Employee objects
            Employee em1 = new Employee() { firstName = "John", lastName = "Alabama", ID = 1 };
            Employee em2 = new Employee() { firstName = "David", lastName = "Panda", ID = 2 };
            Employee em3 = new Employee() { firstName = "Bryan", lastName = "Raisin", ID = 3 };
            Employee em4 = new Employee() { firstName = "Joe", lastName = "Rooster", ID = 4 };
            Employee em5 = new Employee() { firstName = "Amy", lastName = "Peppers", ID = 5 };
            Employee em6 = new Employee() { firstName = "Billy", lastName = "Bobbers", ID = 6 };
            Employee em7 = new Employee() { firstName = "Joe", lastName = "Tutt", ID = 7 };
            Employee em8 = new Employee() { firstName = "Daniel", lastName = "Puuuuup", ID = 8 };
            Employee em9 = new Employee() { firstName = "Logan", lastName = "Creature", ID = 9 };
            Employee em10 = new Employee() { firstName = "Emily", lastName = "BayBay", ID = 10 };

            // Sets the created objects from aboce into a new list called emList
            List<Employee> emList = new List<Employee>() { em1, em2, em3, em4, em5, em6, em7, em8, em9, em10 };


            //---------------------------------------//
            // CREAT LIST OF JOES WITH FOREACH LOOP  //
            List<Employee> joeList = new List<Employee>();

            // A comparison to show how many more lines of code it would take to do the same function as with a foreach loop as compared to the one line of lambda code seen in the next example
            foreach( Employee indiv in emList)
            {
                if(indiv.firstName == "Joe")
                {
                    joeList.Add(indiv);
                }
            }

            //Prints results
            foreach(Employee joe in joeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }
            // END CREAT LIST OF JOES WITH FOREACH LOOP  //
            //-------------------------------------------//


            Console.WriteLine("\n====================\n");


            //-------------------------------------------//
            //  CREAT LIST OF JOES WITH LAMBDA fUNCTIONS //

            // Used a lambda function to create a list (ToList) based on whether and Employee's first name is "Joe", then sets that list to the value of the newly created list labmdaJoeList
            List<Employee> lambdaJoeList = emList.Where(x => x.firstName == "Joe").ToList();

            //Prints results
            foreach (Employee joe in lambdaJoeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }
            //  END CREAT LIST OF JOES WITH LAMBDA fUNCTIONS //
            //-----------------------------------------------//


            Console.WriteLine("\n====================\n");


            //------------------------//
            //  CREAT LIST OF ID > 5  //

            //Uses a lambda function to create a list (ToList) based on whether an employee's ID is greater than 5, then sets that to the new List object lambdaIDList
            List<Employee> lambdaIDList = emList.Where(x => x.ID > 5).ToList();

            //Prints results
            foreach (Employee emp in lambdaIDList)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " - ID: " + emp.ID);
            }
            //  END CREAT LIST OF ID > 5 //
            //---------------------------//


            Console.Read();
        }
    }
}
