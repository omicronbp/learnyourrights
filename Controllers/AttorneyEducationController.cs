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
    public class AttorneyEducationController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /AttorneyEducation/

        public ViewResult Index()
        {
            return View(db.AttorneyEducations.ToList());
        }

        //
        // GET: /AttorneyEducation/Details/5

        public ViewResult Details(int id)
        {
            AttorneyEducation attorneyeducation = db.AttorneyEducations.Find(id);
            return View(attorneyeducation);
        }

        //
        // GET: /AttorneyEducation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AttorneyEducation/Create

        [HttpPost]
        public ActionResult Create(AttorneyEducation attorneyeducation)
        {
            if (ModelState.IsValid)
            {
                db.AttorneyEducations.Add(attorneyeducation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(attorneyeducation);
        }
        
        //
        // GET: /AttorneyEducation/Edit/5
 
        public ActionResult Edit(int id)
        {
            AttorneyEducation attorneyeducation = db.AttorneyEducations.Find(id);
            return View(attorneyeducation);
        }

        //
        // POST: /AttorneyEducation/Edit/5

        [HttpPost]
        public ActionResult Edit(AttorneyEducation attorneyeducation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attorneyeducation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attorneyeducation);
        }

        //
        // GET: /AttorneyEducation/Delete/5
 
        public ActionResult Delete(int id)
        {
            AttorneyEducation attorneyeducation = db.AttorneyEducations.Find(id);
            return View(attorneyeducation);
        }

        //
        // POST: /AttorneyEducation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AttorneyEducation attorneyeducation = db.AttorneyEducations.Find(id);
            db.AttorneyEducations.Remove(attorneyeducation);
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