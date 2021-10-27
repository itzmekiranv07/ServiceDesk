using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Lead()
        {
            return View();
        }
        public ActionResult Manager()
        {
            return View();
        }
        public ActionResult Admin()
        {

            return View();
        }




    }
}