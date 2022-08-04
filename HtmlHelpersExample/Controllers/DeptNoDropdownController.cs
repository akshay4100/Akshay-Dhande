using HtmlHelpersExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersExample.Controllers
{
    public class DeptNoDropdownController : Controller
    {
        // GET: DeptNoDropdown
        public ActionResult Index()
        {
            List<Employee> emps = Employee.GetAllEmployees();
            return View(emps);
        }



        // GET: DeptNoDropdown/DepartmentFilter
        public ActionResult DepartmentFilter()
        {
            var list = Department.GetAllDepartment();
            ViewBag.list = list;
            return View();
        }

        // POST: DeptNoDropdown/DepartmentFilter
        [HttpPost]
        public ActionResult DepartmentFilter(Department obj)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Details",new { id = obj.DeptName});
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Details(int id= 0)
        {
            List<Employee> lstemp = Employee.GetEmployeesbyId(id); 
            return View(lstemp);
        }

    }
}
