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
    public class PracticeAreasController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /PracticeAreas/

        public ViewResult Index()
        {
            return View(db.PracticeAreas.ToList());
        }

        //
        // GET: /PracticeAreas/Details/5

        public ViewResult Details(int id)
        {
            PracticeArea practicearea = db.PracticeAreas.Find(id);
            return View(practicearea);
        }

        //
        // GET: /PracticeAreas/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /PracticeAreas/Create

        [HttpPost]
        public ActionResult Create(PracticeArea practicearea)
        {
            if (ModelState.IsValid)
            {
                db.PracticeAreas.Add(practicearea);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(practicearea);
        }
        
        //
        // GET: /PracticeAreas/Edit/5
 
        public ActionResult Edit(int id)
        {
            PracticeArea practicearea = db.PracticeAreas.Find(id);
            return View(practicearea);
        }

        //
        // POST: /PracticeAreas/Edit/5

        [HttpPost]
        public ActionResult Edit(PracticeArea practicearea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(practicearea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(practicearea);
        }

        //
        // GET: /PracticeAreas/Delete/5
 
        public ActionResult Delete(int id)
        {
            PracticeArea practicearea = db.PracticeAreas.Find(id);
            return View(practicearea);
        }

        //
        // POST: /PracticeAreas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            PracticeArea practicearea = db.PracticeAreas.Find(id);
            db.PracticeAreas.Remove(practicearea);
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