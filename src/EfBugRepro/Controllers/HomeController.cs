using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfBugRepro.Models;
using Microsoft.AspNet.Mvc;

namespace EfBugRepro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public IActionResult Test()
        {
            db.People.Add(new Person { Name = "Josh" });

            //var peep = db.People.First();
            //peep.Birthdate = DateTime.Now;

            db.SaveChanges();

            ViewBag.Message = "Your test finished.";
            return View();
        }
    }
}
