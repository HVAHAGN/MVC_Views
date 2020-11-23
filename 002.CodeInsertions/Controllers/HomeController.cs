using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _002.CodeInsertions.Models;

namespace _002.CodeInsertions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PlainModel> models = new List<PlainModel>()
            {
                new PlainModel() {Company = "Microsoft", Employees = 100000, Salary = 10000},
                new PlainModel() {Company = "Intel", Employees = 55000, Salary = 7000},
                new PlainModel() {Company = "Google", Employees = 10000, Salary = 8000}
            };

            return View(models);
        }
    }
}
