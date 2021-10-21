using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int username, string password)
        {
            WebAPIDBO a = new WebAPIDBO();
            bool validlogin = a.validateLogin(username,password);

            if(validlogin == false)
            {
                ViewBag.msg = ("Wrong Credentials");
                return View("Index");
            }

            else
            {
                Session["empid"] = username;
                Session["role"] = a.getRole(username);
            }

            string user_role = Session["role"].ToString();
            if (user_role == "user") return RedirectToAction("Users", "Role");
            else if (user_role == "lead") return RedirectToAction("Lead", "Role");
            else if (user_role == "manager") return RedirectToAction("Manager", "Role");
            return RedirectToAction("Admin", "Role");
        }
    }
}