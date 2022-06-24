using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Submission_Assignment
{
    // This class contains three overloaded methods, one which takes integers as the argument, one which takes decimals, and one which takes strings.
    public class myClass
    {
        // This is the int method
        public int Math(int number)
        {
            return number + 5;
        }

        // This is the decimal method
        public int Math(decimal number)
        {
            return Convert.ToInt32(number / 2);
        }

        // This is the string method
        public int Math(string number)
        {
            return (Convert.ToInt32(number) * 2);
        }
    }
}
