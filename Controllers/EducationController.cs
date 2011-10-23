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
    public class EducationController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /Education/

        public ViewResult Index()
        {
            return View(db.Educations.ToList());
        }

        //
        // GET: /Education/Details/5

        public ViewResult Details(int id)
        {
            Education education = db.Educations.Find(id);
            return View(education);
        }

        //
        // GET: /Education/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Education/Create

        [HttpPost]
        public ActionResult Create(Education education)
        {
            if (ModelState.IsValid)
            {
                db.Educations.Add(education);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(education);
        }
        
        //
        // GET: /Education/Edit/5
 
        public ActionResult Edit(int id)
        {
            Education education = db.Educations.Find(id);
            return View(education);
        }

        //
        // POST: /Education/Edit/5

        [HttpPost]
        public ActionResult Edit(Education education)
        {
            if (ModelState.IsValid)
            {
                db.Entry(education).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(education);
        }

        //
        // GET: /Education/Delete/5
 
        public ActionResult Delete(int id)
        {
            Education education = db.Educations.Find(id);
            return View(education);
        }

        //
        // POST: /Education/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Education education = db.Educations.Find(id);
            db.Educations.Remove(education);
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