using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {


            return View(db.Insurees.ToList());
        }


        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {

            using (InsuranceEntities db = new InsuranceEntities())
            {
                var records = (from c in db.Insurees
                               select c).ToList();

                foreach (var record in records)
                {
                    Console.Write("{0} {1}", record.FirstName, record.LastName);
                }

            }

                // foreach (database item)
                //    if (quote < minimum possible)
                //        <calculate quote with this each's data>
                //        <save data to database>
                //    else
                //        skip






                return View();
        }


        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();

                using (InsuranceEntities db = new InsuranceEntities())
                {
                    List<Insuree> records = (from c in db.Insurees
                                   select c).ToList();

                    Insuree latest = records.Last<Insuree>();

                    // Logic for determining the quote amount based on the given information
                    decimal quote = 50;
                    DateTime current = new DateTime();
                    current = DateTime.Now;

                    //Adds 100, 50, and 25 to the total if the client is less than 18, 19-25, and 26+ resptectively
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

                    //Adds $25 if the client's car's year is older than 2000 or newer than 2015
                    if (latest.CarYear < 2000 || latest.CarYear > 2015)
                    {
                        quote += 25;
                    }

                    //Adds 50 if the client's car is a 911 carrera Porsche and 26 if it is any other type of porsche
                    if (latest.CarMake.ToLower() == "porsche" && latest.CarModel.ToLower() == "911 carrera")
                    {
                        quote += 50;
                    }
                    else if (latest.CarMake.ToLower() == "porsche")
                    {
                        quote += 25;
                    }

                    //Adds $10 for each speeding ticket a client has
                    if (latest.SpeedingTickets > 0)
                    {
                        quote += (latest.SpeedingTickets * 10);
                    }

                    // Adds 25% of total if the user has a DUI
                    if (latest.DUI == true)
                    {
                        quote += quote * 0.25m;
                    }

                    // Adds 50% of total if the coverage is full
                    if (latest.CoverageType == true)
                    {
                        quote += quote * 0.5m;
                    }

                    //Sets the state of a database entry (In this case the entry that created the "latest" Insuree object) The state is set to EntityState. Modified which marks that the record is being tracked and exists in the database
                    // and some or all of its property values have been modified
                    db.Entry(latest).State = EntityState.Modified;
                    //This changes the Quote property for the latest object, which is then translated to the database because of the EntityState
                    latest.Quote = quote;
                    // Saves changes to database
                    db.SaveChanges();

                }

                return RedirectToAction("Index");
            }




            return View(insuree);
        }


        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Admin()
        {

            List<Insuree> issuedQuotes = db.Insurees.ToList();

            List<Insuree> modelQuotes = new List<Insuree>();

            foreach (var quote in issuedQuotes)
            {
                var singleQuote = new Insuree();
                singleQuote.FirstName = quote.FirstName;
                singleQuote.LastName = quote.LastName;
                singleQuote.EmailAddress = quote.EmailAddress;
                singleQuote.Quote = quote.Quote;
                modelQuotes.Add(singleQuote);
            }

            return View(modelQuotes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
