using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        LearnYourRightsDb _db = new LearnYourRightsDb();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var model = _db.SiteProperties.FirstOrDefault();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
