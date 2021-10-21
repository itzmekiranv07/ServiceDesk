using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceDesk.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int username, string password)
        {
            string user_role = "sdfasd";
            if (user_role == "user") return RedirectToAction("Users", "Role");
            else if (user_role == "lead") return RedirectToAction("Lead", "Role");
            else if (user_role == "manager") return RedirectToAction("Manager", "Role");
            return RedirectToAction("Admin", "Role");
        }
    }
}