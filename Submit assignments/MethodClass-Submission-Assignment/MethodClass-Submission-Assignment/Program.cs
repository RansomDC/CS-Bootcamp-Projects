using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            myClass letsGo = new myClass();

            // Calling method with the default pattern
            letsGo.funk(2, 3);

            // Calling method declaring parameters by name
            letsGo.funk(operate: 4, display: 5);

            Console.Read();
        }
    }
}
