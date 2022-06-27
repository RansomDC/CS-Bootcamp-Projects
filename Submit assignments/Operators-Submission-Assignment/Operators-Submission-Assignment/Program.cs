using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            Employee RCadorette = new Employee();
            RCadorette.ID = 80085;

            Employee RansomCadorette = new Employee();
            RansomCadorette.ID = 80085;

            Employee BranstonBadorette = new Employee();
            BranstonBadorette.ID = 42069;

            Console.WriteLine(RCadorette == RansomCadorette);

            Console.WriteLine(RCadorette == BranstonBadorette);

            Console.Read();
        }
    }
}
