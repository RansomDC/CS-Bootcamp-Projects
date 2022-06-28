using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main()
        {
            // This takes a generic class (Employee) and instantiates a object using the string data type. Then the following 4 lines are to populate the list with those strings
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.things.Add("raven");
            stringEmployee.things.Add("crow");
            stringEmployee.things.Add("magpie");
            stringEmployee.things.Add("jay");


            Employee<int> intEmployee = new Employee<int>();
            intEmployee.things.Add(1);
            intEmployee.things.Add(2);
            intEmployee.things.Add(3);
            intEmployee.things.Add(4);

            // This prints all of the data from the things property of the string Employee
            foreach(string bird in stringEmployee.things)
            {
                Console.WriteLine(bird);
            }

            foreach(int number in intEmployee.things)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
