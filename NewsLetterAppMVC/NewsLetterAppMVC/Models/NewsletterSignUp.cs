//This model is no longer used in this application, but is kept here as an example of a model one might create if they weren't using Entity Framework

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsLetterAppMVC.Models
{
    public class NewsletterSignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}