using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignment
{
    //Creates an interface that can be inherited by other classes
    interface IQuittable
    {
        //Creates a simple method that must be implemented in any class that inherits this interface
        void Quit();
    }
}
