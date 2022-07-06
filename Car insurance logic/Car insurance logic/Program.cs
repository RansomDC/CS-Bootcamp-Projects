using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_insurance_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Insuree latest = new Insuree();
            latest.FirstName = "Jeff";
            latest.LastName = "Jordon";
            latest.EmailAddress = "Jeff@email.com";
            latest.DateOfBirth = DateTime.Now.AddYears(-30); //30
            latest.CarYear = DateTime.Now.AddYears(-22).Year; //2000
            latest.CarMake = "Ford";
            latest.CarModel = "Windstar";
            latest.DUI = false;
            latest.SpeedingTickets = 0;
            latest.CoverageType = false;

            decimal quote = 50;
            string testQuote = "Start ";
            DateTime current = new DateTime();
            current = DateTime.Now;


            if (latest.DateOfBirth > current.AddYears(-18))
            {
                quote += 100;
            }
            else if (latest.DateOfBirth > current.AddYears(-25) && latest.DateOfBirth < current.AddYears(-19))
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }


            if (latest.CarYear < 2000 || latest.CarYear > 2015)
            {
                quote += 25;
            }


            if (latest.CarMake.ToLower() == "porsche" && latest.CarModel.ToLower() == "911 carrera")
            {
                quote += 50;
            }
            else if (latest.CarMake.ToLower() == "porsche")
            {
                quote += 25;
            }


            if (latest.SpeedingTickets > 0)
            {
                quote += (latest.SpeedingTickets * 10);
            }


            if (latest.DUI == true)
            {
                quote += quote * 0.25m;
            }

            if (latest.CoverageType == true)
            {
                quote += quote * 0.5m;
            }


            Console.WriteLine(quote);


            Console.Read();
        }
    }
}
