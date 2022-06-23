using System;
using System.Collections.Generic;



namespace StringsAndIntegers_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Declare a list of integers
                List<int> numbers = new List<int>() { 20, 26, 12, 18, 13, 70 };
                //Write instuctions for the user to the console
                Console.WriteLine("Please enter a whole integerto divide a series of other numbers by.");
                // Gets the number from the user (as a string) and converts it to an integer
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                // 
                foreach (int number in numbers)
                {
                    Console.WriteLine("The index value divided by " + inputNumber + " is: " + (number / inputNumber));
                }
            }
            // Exception for entering a non-number string
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Exception for diving by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please don't do that.");
            }
            Console.WriteLine("The program is now closing");
            Console.Read();
        }
    }
}
