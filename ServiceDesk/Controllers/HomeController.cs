using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

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

        public ActionResult Index(int empid, string pass_word)
        {
            WebAPIDBO dbo = new WebAPIDBO();

            Employee E=new Employee();
            E = dbo.getProfile(empid);
            if(E.Emp_ID==empid && E.Emp_Pwd == pass_word)
            {
                Session["Employee"] = dbo.getProfile(empid);



                return RedirectToAction("StartRoute", "Role");
            }
            else
            {
                ViewBag.msg = "Enter Valid Details";
                return View();
            }

        }

    }
    }
