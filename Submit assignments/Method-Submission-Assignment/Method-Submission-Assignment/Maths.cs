﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    class Maths
    {
        // Method with second parameter being optional (default is 1)
        public int MathIsFun(int num1, int num2 = 1)
        {
            return (num1 * 2) * num2;
        }
    }
}
