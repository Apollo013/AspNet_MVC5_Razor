using AspNet_MVC5_Razor.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNet_MVC5_Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Conditions()
        {
            return View();
        }
        public ActionResult HelperComponent()
        {
            return View();
        }

        public ActionResult Iterating()
        {
            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Mary" },
                new Customer() { Id = 2, Name = "John" },
                new Customer() { Id = 2, Name = "Phillip" },
                new Customer() { Id = 2, Name = "Jane" }
            };

            return View(customers);
        }

    }
}