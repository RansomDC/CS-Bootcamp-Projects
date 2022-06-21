using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProgram.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageInput = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageInput);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string helpInput = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpInput);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positives = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursInput = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursInput);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
