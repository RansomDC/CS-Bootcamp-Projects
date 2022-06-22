using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Math_and_Comparison_Submisssion_Assignment
{
    class Program
    {
        static void Main()
        {
            //This block prints several lines of code to the console giving the user instructions on use of the program. It then takes the inputs from the user for pay and hours work for Person1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Remember, even though this program in anonymous, the right to freely discuss your pay\nwith you coworkers in the workplace is protected under federal law. Any policies put\nin place by an employer to punish or prevent the free discussion of employee wages\nare unlawful and should be reported to your state department of labor.\n");
            Console.WriteLine("Person1:");
            Console.WriteLine("Please input your hourly rate:");
            string rateInputOne = Console.ReadLine();
            Console.WriteLine("Please input your average hours worked per week:");
            string hoursInputOne = Console.ReadLine();

            // This block requests the user input for the pay and hours worked for Person2
            Console.WriteLine("Person2:");
            Console.WriteLine("Please input your hourly rate:");
            string rateInputTwo = Console.ReadLine();
            Console.WriteLine("Please input your average hours worked per week:");
            string hoursInputTwo = Console.ReadLine();

            // The first two lines here convert the strings received in the previous sections to integers, then it calculates the annual salary of person 1 and prints that datum
            float personOneRate = float.Parse(rateInputOne, CultureInfo.InvariantCulture.NumberFormat);
            float personOneHours = float.Parse(hoursInputOne, CultureInfo.InvariantCulture.NumberFormat);
            float personOneAnnual = ((personOneRate * personOneHours) * 52);
            Console.WriteLine("Annual salary of person1 $" + personOneAnnual);

            // The first two lines in this block also convert the strings received to integers, and again calculates the annulal salary, but this time for person 2, printing the result
            float personTwoRate = float.Parse(rateInputTwo, CultureInfo.InvariantCulture.NumberFormat);
            float personTwoHours = float.Parse(hoursInputTwo, CultureInfo.InvariantCulture.NumberFormat);
            float personTwoAnnual = ((personTwoRate * personTwoHours) * 52);
            Console.WriteLine("Annual salary of person2 $" + personTwoAnnual);

            //This performs a comparison of the two salaries and prints a true of false of whether person1 makes more than person2
            Console.WriteLine("Does Person1 make more money than Person2?");
            Console.WriteLine(personOneAnnual > personTwoAnnual);
            Console.Read();


        }
    }
}
