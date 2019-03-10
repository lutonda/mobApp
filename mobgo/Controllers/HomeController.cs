using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mobgo.Models;

namespace mobgo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var context = new Context();
            var list=context.Currencies.ToList<Currency>();
            return View();
        }
    }
}
