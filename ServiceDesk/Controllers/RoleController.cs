using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;
using Newtonsoft.Json;

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

        [Route("Role/getEmployee/{Emp_ID}")]
        public ActionResult getEmployee(int Emp_ID)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Profile"]= JsonConvert.SerializeObject(dbo.getProfile(Emp_ID));
            return View();
        }

        [Route("Role/getGroupMembers/{Group_ID}")]
        public ActionResult getGroupMembers(int Group_ID)// landing for lead
        {
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["GroupMembers"] = JsonConvert.SerializeObject(dbo.getGroupMembers(Group_ID));
            return View();
        }

        [Route("Role/getGroupMembers/{Dept_ID}")]
        public ActionResult getGroupsinDept(int Dept_ID)// landing for manager
        {
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["GroupsinDept"] = JsonConvert.SerializeObject(dbo.getGroups(Dept_ID));
            return View();
        }
        
        //[Route("Role/getDepts")]
        public ActionResult getDepts() // landing for admin
        {
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Depts"] = JsonConvert.SerializeObject(dbo.getDepts());
            return View();
        }

    }
}