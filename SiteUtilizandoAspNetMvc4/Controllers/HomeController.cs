using SiteUtilizandoAspNetMvc4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteUtilizandoAspNetMvc4.Controllers
{
    public class HomeController : Controller
    {
        private IDBSource _db;
        public HomeController(IDBSource db):base()
        {
            _db = db;
        }

        public ActionResult Index()
        {

            ViewBag.AuthorName = _db.Author.FirstOrDefault()?.Name;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}