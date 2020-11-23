using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.StaticFiles.Models;

namespace _001.StaticFiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PlainModel model = new PlainModel()
            {
                Company = "Microsoft",
                Employees = 100000,
                Salary = 10000
            };

            ViewData["totalSalary"] = model.Employees * model.Salary;
            ViewData["company"] = model.Company;
            ViewData["employees"] = model.Employees;
            return View();
        }
    }
}
