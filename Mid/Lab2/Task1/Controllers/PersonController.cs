using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Task1.Models;

namespace Task1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        new public ActionResult Profile()
        {
            Person person = new Person() {
                Id = 123,
                Name = "Nobir Hossain",
                Dob = "29-06-2000"
            };

            return View(person);
        }
    }
}