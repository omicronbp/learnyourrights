using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class SitePropertyController : Controller
    {
        //
        // GET: /SiteProperty/

        LearnYourRightsDb _db = new LearnYourRightsDb();

        public ActionResult Index()
        {
            var model = _db.SiteProperties;
            return View(model);
        }

        //
        // GET: /SiteProperty/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SiteProperty/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SiteProperty/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /SiteProperty/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SiteProperty/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SiteProperty/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SiteProperty/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
