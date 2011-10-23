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
    public class BirthplaceController : Controller
    {
        private LearnYourRightsDb db = new LearnYourRightsDb();

        //
        // GET: /Birthplace/

        public ViewResult Index()
        {
            return View(db.Birthplaces.ToList());
        }

        //
        // GET: /Birthplace/Details/5

        public ViewResult Details(int id)
        {
            Birthplace birthplace = db.Birthplaces.Find(id);
            return View(birthplace);
        }

        //
        // GET: /Birthplace/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Birthplace/Create

        [HttpPost]
        public ActionResult Create(Birthplace birthplace)
        {
            if (ModelState.IsValid)
            {
                db.Birthplaces.Add(birthplace);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(birthplace);
        }
        
        //
        // GET: /Birthplace/Edit/5
 
        public ActionResult Edit(int id)
        {
            Birthplace birthplace = db.Birthplaces.Find(id);
            return View(birthplace);
        }

        //
        // POST: /Birthplace/Edit/5

        [HttpPost]
        public ActionResult Edit(Birthplace birthplace)
        {
            if (ModelState.IsValid)
            {
                db.Entry(birthplace).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(birthplace);
        }

        //
        // GET: /Birthplace/Delete/5
 
        public ActionResult Delete(int id)
        {
            Birthplace birthplace = db.Birthplaces.Find(id);
            return View(birthplace);
        }

        //
        // POST: /Birthplace/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Birthplace birthplace = db.Birthplaces.Find(id);
            db.Birthplaces.Remove(birthplace);
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