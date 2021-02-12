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
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //Adding calculated baseQuote fromm getQuote()
                //Only updates after being saved.  
                //Any user input value for quote will  be calculated and updated after saved entry.
                //Note: Try to get to auto-fill Quote field input if possible 
                insuree.Quote = getQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal getQuote(Insuree insuree)
        {
            // Base quote value $50.00
            decimal baseQuote = 50m;

            //Determine age and add cost to baseQuote in respect to parameters provided by CarInsurance
            DateTime DateOfBirth = insuree.DateOfBirth;
            var today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (age <= 18)
            {
                baseQuote += 100;
            }
            else if (age >= 19 && age <= 25)
            {
                baseQuote += 50;

            }
            else
            {
                baseQuote += 25;
            }
            //Checking car year and adding to monthly total 
            if (insuree.CarYear < 2000)
            {
                baseQuote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                baseQuote += 25;
            }
            //checking if car make is Porsche
            if (insuree.CarMake.ToLower() == "porsche")
            {
                baseQuote += 25; 
            }
            //checking if car make is Porsche and if model is a 911 Carerra

            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
            {
                baseQuote += 25;
            }

            //checking number of speeding tickets and adding $10 per ticket to  monthly coverage quote
            baseQuote += (insuree.SpeedingTickets * 10);
            //checking for DUI and adding 25% to  the total
            if (insuree.DUI == true)
            {
                baseQuote *= 1.25m;
            }
            //checking for full coverage and adding 50% to the total
            if (insuree.CoverageType == true)
            {
                baseQuote *= 1.5m;
            }

            return baseQuote;
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
