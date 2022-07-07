using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBaseFirst_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            // Here we will get data about the student from the user
            Console.WriteLine("Please enter the student's first name: ");
            string fNameInput = Console.ReadLine();

            Console.WriteLine("Please enter the student's last name: ");
            string lNameInput = Console.ReadLine();

            Console.WriteLine("Please enter the student's favorite class: ");
            string classInput = Console.ReadLine();

            using (var db = new StudentContext())
            {
                // This creates a new student and initializes the data received from the user into the appropriate sections
                Student newStudent = new Student() { FirstName = fNameInput, LastName = lNameInput, FavoriteClass = classInput };
                // This adds the new student to the database
                db.Students.Add(newStudent);
                // This saves the changes made to the database in the above line.
                db.SaveChanges();

                // These lines will display the students in the database
                var query = from each in db.Students
                            orderby each.FirstName
                            select each;

                Console.WriteLine("Here are the current students: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName);
                }
            }

            Console.Read();

        }
    }
}
