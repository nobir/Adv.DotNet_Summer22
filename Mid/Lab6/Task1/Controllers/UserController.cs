using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.EF;

namespace Task1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var db = new Lab6Entities();
            var users = db.users.ToList();

            return View(users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(user user)
        {
            if(!ModelState.IsValid)
            {
                return View("Create", user);
            }

            var db = new Lab6Entities();
            db.users.Add(user);
            db.SaveChanges();

            TempData["message"] = "Successfully Created";

            return View("Create");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new Lab6Entities();
            var user = db.users.Find(Id);
            return View(user);
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}