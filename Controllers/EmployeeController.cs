using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course4_1_ye_yang.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("SearchEmployee");
        }

        public ActionResult SearchEmployee()
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            return View();
        }

        [HttpPost]
        public ActionResult SearchEmployee(Models.EmployeeSearchArg arg)
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            List<Models.EmployeeSearchResult> employeeSearchResult = employeeService.GetSearchResultByArg(arg);
            ViewBag.EmployeeSearchResult = employeeSearchResult;            
            return View(arg);
        }        

        public ActionResult InsertEmployee()
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            ViewBag.Country = employeeService.GetCountry();
            ViewBag.City = employeeService.GetCity();
            ViewBag.Gender = employeeService.GetGender();
            ViewBag.ManagerID = employeeService.GetManagerID();
            return View(new Models.Employee());
        }

        [HttpPost]
        public ActionResult InsertEmployee(Models.Employee arg)
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            ViewBag.Country = employeeService.GetCountry();
            ViewBag.City = employeeService.GetCity();
            ViewBag.Gender = employeeService.GetGender();
            ViewBag.ManagerID = employeeService.GetManagerID();
            if (ModelState.IsValid)
            {
                ViewBag.Successful = employeeService.InsertEmployee(arg);                
            }
            return View(new Models.Employee());
        }

        [HttpGet]
        public ActionResult UpdateEmployee(string id)
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            ViewBag.ViewCountry = employeeService.GetCountry();
            ViewBag.ViewCity = employeeService.GetCity();
            ViewBag.ViewGender = employeeService.GetGender();
            ViewBag.ViewManagerID = employeeService.GetManagerID();
            if (id != null)
            {               
                Models.Employee arg = employeeService.GetEmployeeByID(id);
                arg.EmployeeID = Convert.ToInt32(id);     
                ViewBag.ID = Convert.ToInt32(id);                
                return View(arg);
            }

            return RedirectToAction("SearchEmployee");
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Models.Employee arg)
        {
            Models.EmployeeService employeeService = new Models.EmployeeService();
            ViewBag.Type = employeeService.GetTitle();
            ViewBag.ViewCountry = employeeService.GetCountry();
            ViewBag.ViewCity = employeeService.GetCity();
            ViewBag.ViewGender = employeeService.GetGender();
            ViewBag.ViewManagerID = employeeService.GetManagerID();
            if (ModelState.IsValid)
            {
                employeeService.UpdateEmployee(arg);
            }

            return View(arg);
        }

        [HttpPost()]
        public JsonResult DeleteEmployee(string EmployeeID)
        {
            try
            {
                Models.EmployeeService employeeService = new Models.EmployeeService();
                employeeService.DeleteEmployee(EmployeeID);
                return this.Json(true);
            }

            catch (Exception)
            {
                return this.Json(false);
            }
        }

    }
}
