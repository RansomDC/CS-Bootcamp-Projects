using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //To use Entity Framework to get data from the data base we do the following:
            // First we instantiate our Newsletter Entities class. It is considered best practice to wrap instantiated entity object in using statements so that the database connection is closed when we're all done
            ///////////////////////////////////////////////////////////////////
            ///
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                //// The following two lines are one way to filter
                ////We create a variable called signups which is equal to db.SignUps which represents all of records in that database that do not have a datetime value in the Removed property (i.e. the property is null).
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();


                ////This is another way to filter the same data as aboce but using linq syntax instead
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();

                //////////////////////////////////////////////////////////////////
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                // This returns the Model (signups) that we can use on the Admin page
                return View(signupVms);




                //=======================================================================
                //THIS IS THE ORIGINAL ADO.NET METHOD OF GETTING DATA FROM THE DATABASE
                //=======================================================================
                // The code between the line above and the equals line below is equivalent to the same code between the slashes above (thanks to the entity framework)
                //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";
                //// Create a list that can hold only objects that are from the NewsLetterSignUp Model data type
                //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

                //// Open a connection with the connection string
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    // Create the ability to execute a command with a query string and the connection we just made
                //    SqlCommand command = new SqlCommand(queryString, connection);

                //    // Open the connection
                //    connection.Open();

                //    // Create a variable called a SQL data reader that can be called to get data from the database
                //    SqlDataReader reader = command.ExecuteReader();

                //    // A loop which read data from the database until in no longer can. Doing a loop for each row of data.
                //    while (reader.Read())
                //    {
                //        // Creates a new newsletterSignUp() object to be populated by the next few lines after this one
                //        var signup = new NewsletterSignUp();
                //        // assignes the signup object an ID based on the information in the database (which is converted from a SQL data type to a C# data type)
                //        signup.Id = Convert.ToInt32(reader["Id"]);
                //        // Accessing the reader object like a library allows us to return the value that is stored in the database.
                //        signup.FirstName = reader["FirstName"].ToString();
                //        signup.LastName = reader["LastName"].ToString();
                //        signup.EmailAddress = reader["EmailAddress"].ToString();
                //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                //        // This adds the one signup object that we just populated to the singups list that we created earlier
                //        signups.Add(signup);
                //    }

                //}
                //======================================================================

                //// We use the same code here as we do for the Entity Framework method of getting data
                //    var signupVms = new List<SignupVm>();
                //foreach (var signup in signups)
                //{
                //    var signupVm = new SignupVm();
                //    signupVm.FirstName = signup.FirstName;
                //    signupVm.LastName = signup.LastName;
                //    signupVm.EmailAddress = signup.EmailAddress;
                //    signupVms.Add(signupVm);
                //}
                //    // This returns the Model (signups) that we can use on the Admin page
                //    return View(signupVms);
            }
        }

        // This creates the method that will be used in Admin/Index on the Unsubscribe button
        public ActionResult Unsubscribe(int Id)
        {
            //first thing we do is start a using statement so that any connection to the db is closed after these actions are done, we also create a new db object from the NewsletterEntities1 class
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                // We create the signup variable and make fill it by searching the database.SignUps table using Find() and including the Id value
                var signup = db.SignUps.Find(Id);
                //We take that object that we just accessed and stored in a variable and alter one of the properties (in this case adding a datetime value)
                signup.Removed = DateTime.Now;
                //We save the changes made to the database
                db.SaveChanges();
            }
            // We now redirect back to out index page
            return RedirectToAction("Index");
        }
    }
}