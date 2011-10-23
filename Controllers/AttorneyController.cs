using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{ 
    public class AttorneyController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /Attorney/

        public ViewResult Index()
        {
            return View(db.Attorneys.ToList());
        }

        //
        // GET: /Attorney/Details/5

        public ViewResult Details(int id)
        {
            Attorney attorney = db.Attorneys.Find(id);
            return View(attorney);
        }

        //
        // GET: /Attorney/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Attorney/Create

        [HttpPost]
        public ActionResult Create(Attorney attorney)
        {
            if (ModelState.IsValid)
            {
                db.Attorneys.Add(attorney);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(attorney);
        }
        
        //
        // GET: /Attorney/Edit/5
 
        public ActionResult Edit(int id)
        {
            Attorney attorney = db.Attorneys.Find(id);
            return View(attorney);
        }

        //
        // POST: /Attorney/Edit/5

        [HttpPost]
        public ActionResult Edit(Attorney attorney)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attorney).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attorney);
        }

        //
        // GET: /Attorney/Delete/5
 
        public ActionResult Delete(int id)
        {
            Attorney attorney = db.Attorneys.Find(id);
            return View(attorney);
        }

        //
        // POST: /Attorney/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Attorney attorney = db.Attorneys.Find(id);
            db.Attorneys.Remove(attorney);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}