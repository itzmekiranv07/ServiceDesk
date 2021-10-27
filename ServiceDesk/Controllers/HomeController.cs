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
            //WebAPIDBO dbo = new WebAPIDBO();
            //bool check = dbo.validateLogin(empid, pass_word);
            //if (check == true)
            //{
            //    Session["Employee"] = dbo.getProfile(empid);
            //    return RedirectToAction("StartRoute", "Role");
            //}
            //else
            //{
            //    return View();
            //}
            WebAPIDBO dbo = new WebAPIDBO();
            Employee E=new Employee();
            E = dbo.getProfile(empid);

            if (E.Emp_ID==empid && E.Emp_Pwd==pass_word)
            {
                Session["Employee"] = E;
                Session["role"] = "User";

                if (E.Emp_Role== "Users") return RedirectToAction("Users", "Role");
                    else if (E.Emp_Role== "Lead") return RedirectToAction("Lead", "Role");
                 else if (E.Emp_Role == "Manager") return RedirectToAction("Manager", "Role");
                else return RedirectToAction("Admin", "Role");
            }
            else
            {
                ViewBag.msg = "Wrong Credentials";
                return View();
            }
            
        }


        }
    }
