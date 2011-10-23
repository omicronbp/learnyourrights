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
    public class AdmissionController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /Admission/

        public ViewResult Index()
        {
            return View(db.Admissions.ToList());
        }

        //
        // GET: /Admission/Details/5

        public ViewResult Details(int id)
        {
            Admission admission = db.Admissions.Find(id);
            return View(admission);
        }

        //
        // GET: /Admission/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admission/Create

        [HttpPost]
        public ActionResult Create(Admission admission)
        {
            if (ModelState.IsValid)
            {
                db.Admissions.Add(admission);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(admission);
        }
        
        //
        // GET: /Admission/Edit/5
 
        public ActionResult Edit(int id)
        {
            Admission admission = db.Admissions.Find(id);
            return View(admission);
        }

        //
        // POST: /Admission/Edit/5

        [HttpPost]
        public ActionResult Edit(Admission admission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admission);
        }

        //
        // GET: /Admission/Delete/5
 
        public ActionResult Delete(int id)
        {
            Admission admission = db.Admissions.Find(id);
            return View(admission);
        }

        //
        // POST: /Admission/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Admission admission = db.Admissions.Find(id);
            db.Admissions.Remove(admission);
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