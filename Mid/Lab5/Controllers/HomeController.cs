using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab5.EF;

namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            return View(user);
        }

        public ActionResult ViewUsers()
        {
            Lab5Entities db = new Lab5Entities();
            var users = db.Users.ToList();
            return View(users);
        }
    }
}