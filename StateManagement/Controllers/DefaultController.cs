using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewData["key1"] = "abc";
            ViewData["key2"] = 10;
            ViewBag.key3 = true;

            TempData["key4"] = "abc";
            Session["Name"] = "Akshay";
            Session["id"] = 10;
            return View();
        }

        public ActionResult Index2()
        {
            string s;
            s = Session["Name"].ToString();
            int i;
            i = (int)Session["id"] ;
            return View();
        }
    }
}