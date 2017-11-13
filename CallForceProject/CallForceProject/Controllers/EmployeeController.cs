using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallForceProject.Controllers
{
    public class EmployeeController : Controller
    {
        string empName;
        string empImg;
        int empYrs;
        string empDep;
        int empSales;
        int empGoal;

        // GET: Employee
        public ActionResult Index()
        {
            List<SelectListItem> emp = new List<SelectListItem>();
            emp.Add(new SelectListItem { Text = "Conner Ludlow", Value = "0", Selected = true });
            emp.Add(new SelectListItem { Text = "Nathan Walton", Value = "1" });
            emp.Add(new SelectListItem { Text = "Michael Scott", Value = "2" });
            ViewBag.employee = emp;
            return View();
        }

        public ViewResult EmpChosen(string employee)
        {
            if (employee.Equals("0"))
            {
                ViewBag.name = "Conner Ludlow";
                ViewBag.img = "~/Content/img/conner.jpg";
                ViewBag.yrswrked = "2";
                ViewBag.dep = "Management";
                ViewBag.sales = "8";
                ViewBag.goal = "10";
            }
            else if (employee.Equals("1"))
            {
                ViewBag.name = "Nathan Walton";
                ViewBag.img = "~/Content/img/Walton.jpg";
                ViewBag.yrswrked = "1";
                ViewBag.dep = "Sales";
                ViewBag.sales = "11";
                ViewBag.goal = "8";
            }

            else if (employee.Equals("2"))
            {
                ViewBag.name = "Michael Scott";
                ViewBag.img = "~/Content/img/MichaelScott.png";
                ViewBag.yrswrked = "10";
                ViewBag.dep = "Sales";
                ViewBag.sales = "4";
                ViewBag.goal = "12";
            }



            return View("Goals");
        }

        public ActionResult Goals()
        {
            return View();
        }
        public ActionResult TeamMessage()
        {
            return View();
        }
    }
}