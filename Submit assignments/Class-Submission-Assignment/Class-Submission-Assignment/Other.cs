using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    public static class Other
    {
        // First method named test
        static public int test(int number)
        {
            return number * 2;
        }

        // Second method overloading test
        static public string test(string str)
        {
            return str + " " + str;
        }
    }
}
