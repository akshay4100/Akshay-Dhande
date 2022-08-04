using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly] //if we want to partial view should not be called directly then give [ChildActionOnly] attribute
        public ActionResult PartialView1()
        {
            return View();
        }
    }
}