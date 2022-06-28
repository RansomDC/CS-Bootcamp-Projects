using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    // This simpily creates the Employee class which has a single property of things which is a generic list that can be filled out by any data type.
    class Employee<T>
    {
        // This is a constructor for the employee class so that each time it is called a new list is made
        public Employee() 
            {
            things = new List<T>();
            }

    public List<T> things { get; set; }
    }
}
