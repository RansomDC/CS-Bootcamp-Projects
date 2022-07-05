using PracticeMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Instructors(int id=1)
        {
            ViewBag.Id = id;

            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Fred",
                    LastName = "Durst"
                },
                new Instructor
                {
                    Id = 1,
                    FirstName = "Polly",
                    LastName = "Pocket"
                },
                new Instructor
                {
                    Id = 1,
                    FirstName = "Tiny",
                    LastName = "Tim"
                }
            };


            return View(instructors);
        }
    }
}