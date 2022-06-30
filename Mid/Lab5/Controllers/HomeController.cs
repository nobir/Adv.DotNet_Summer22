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
            int affected_row = 0;

            try
            {
                Lab5Entities db = new Lab5Entities();

                db.Users.Add(user);
                affected_row = db.SaveChanges();

                if (affected_row > 0)
                {
                    TempData["successmsg"] = "Successfully created!!";
                }
                else
                {
                    TempData["errormsg"] = "Unuccessfull to create user!!";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            User usr = null;
            try
            {
                var db = new Lab5Entities();
                usr = db.Users.Find(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(usr == null)
            {
                TempData["errormsg"] = "Can't find the user";
                return RedirectToAction("ViewUsers", "Home");
            }

            return View(usr);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            int affected_row = 0;

            try
            {
                Lab5Entities db = new Lab5Entities();
                db.Users.Find(user.Id).Name = user.Name;
                affected_row = db.SaveChanges();

                if (affected_row > 0)
                {
                    TempData["successmsg"] = "Successfully updated!!";
                }
                else
                {
                    TempData["errormsg"] = "Unuccessfull to update user!!";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            int affected_row = 0;
            try
            {
                var db = new Lab5Entities();
                db.Users.Remove(db.Users.Find(id));
                affected_row = db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (affected_row > 0)
            {
                TempData["successmsg"] = "Successfully deleted!!";
            }
            else
            {
                TempData["errormsg"] = "Unuccessfull to delete user!!";
            }

            return RedirectToAction("ViewUsers", "Home");
        }

        public ActionResult ViewUsers()
        {
            Lab5Entities db = new Lab5Entities();
            var users = db.Users.ToList();
            return View(users);
        }
    }
}