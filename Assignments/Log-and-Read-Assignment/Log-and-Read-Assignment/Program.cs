using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log_and_Read_Assignment
{
    class Program
    {
        static void Main()
        {
            // This request's and gets and input from the user
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();

            // This writes the user's input to a file.
            File.WriteAllText(@"C:\Users\Ranso\Documents\Programming\CS-Bootcamp-Projects\Assignments\Log-and-Read-Assignment\testText.txt", input);

            // This retrieves the data from the file and then prints it to the console.
            string retrieval = File.ReadAllText(@"C:\Users\Ranso\Documents\Programming\CS-Bootcamp-Projects\Assignments\Log-and-Read-Assignment\testText.txt");
            Console.WriteLine("Here is your number: {0}",retrieval);

            Console.Read();
        }
    }
}
