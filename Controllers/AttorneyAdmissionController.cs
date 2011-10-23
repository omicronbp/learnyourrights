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
    public class AttorneyAdmissionController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /AttorneyAdmission/

        public ViewResult Index()
        {
            return View(db.AttorneyAdmissions.ToList());
        }

        //
        // GET: /AttorneyAdmission/Details/5

        public ViewResult Details(int id)
        {
            AttorneyAdmission attorneyadmission = db.AttorneyAdmissions.Find(id);
            return View(attorneyadmission);
        }

        //
        // GET: /AttorneyAdmission/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AttorneyAdmission/Create

        [HttpPost]
        public ActionResult Create(AttorneyAdmission attorneyadmission)
        {
            if (ModelState.IsValid)
            {
                db.AttorneyAdmissions.Add(attorneyadmission);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(attorneyadmission);
        }
        
        //
        // GET: /AttorneyAdmission/Edit/5
 
        public ActionResult Edit(int id)
        {
            AttorneyAdmission attorneyadmission = db.AttorneyAdmissions.Find(id);
            return View(attorneyadmission);
        }

        //
        // POST: /AttorneyAdmission/Edit/5

        [HttpPost]
        public ActionResult Edit(AttorneyAdmission attorneyadmission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attorneyadmission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attorneyadmission);
        }

        //
        // GET: /AttorneyAdmission/Delete/5
 
        public ActionResult Delete(int id)
        {
            AttorneyAdmission attorneyadmission = db.AttorneyAdmissions.Find(id);
            return View(attorneyadmission);
        }

        //
        // POST: /AttorneyAdmission/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AttorneyAdmission attorneyadmission = db.AttorneyAdmissions.Find(id);
            db.AttorneyAdmissions.Remove(attorneyadmission);
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