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
            return RedirectToAction("getAssignedTickets","Role");
        }

        public ActionResult Lead()
        {
            return RedirectToAction("getGroupMembers", "Role");
        }
        public ActionResult Manager()
        {
            return View("getGroupsinDept","Role");
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

        [Route("Role/getGroupMembers")]
        [Route("Role/getGroupMembers/{Group_ID}")]
        public ActionResult getGroupMembers(int? Group_ID)// landing for lead
        {
            if(Group_ID == null)
            {
                Employee e = (Employee)Session["Employee"];
                Group_ID = e.Group_ID;
            }
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["GroupMembers"] = JsonConvert.SerializeObject(dbo.getGroupMembers((int)Group_ID));
            return View();
        }

        [Route("Role/getGroupsinDept")]
        [Route("Role/getGroupsinDept/{Dept_ID}")]
        public ActionResult getGroupsinDept(int? Dept_ID)// landing for manager
        {
            if (Dept_ID == null) Dept_ID = 0;//Dept_ID = dept of logged in manager
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["GroupsinDept"] = JsonConvert.SerializeObject(dbo.getGroups((int)Dept_ID));
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