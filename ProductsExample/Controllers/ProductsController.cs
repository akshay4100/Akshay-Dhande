using ProductsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductsExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> prods = Product.GetProducts();
            return View(prods);
        }

        

        

        // GET: Products/Edit/5
        public ActionResult Edit(int id = 0)
        {
            var list = Category.GetCategoryNames();
            ViewBag.list = list;
            Product obj = Product.GetSingleProduct(id);
            return View(obj);
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product obj = null)
        {
            try
            {
                Product.UpdateProduct(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
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

        public ActionResult PartialDisplay()
        {
            return View();
        }
    }
}
