using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;
using Newtonsoft.Json;
using System.Web.Security;

namespace ServiceDesk.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        //asdasdasdasasdasdasd

        static WebAPIDBO dbo = new WebAPIDBO();
        //static Employee e = (Employee)Session["Employee"];
        public ActionResult StartRoute()
        {
            //WebAPIDBO dbo = new WebAPIDBO();
            Employee e = (Employee)Session["Employee"];

            if (e.Emp_Role == "User") return RedirectToAction("Users", "Role");
            else if (e.Emp_Role == "Manager") return RedirectToAction("Manager", "Role");
            else if (e.Emp_Role == "Lead") return RedirectToAction("Lead", "Role");
            else return RedirectToAction("Admin", "Role");
        }


        public ActionResult Users()
        {
            return RedirectToAction("getAssignedTickets", "Ticket");
        }

        public ActionResult Lead()
        {
            return RedirectToAction("getGroupMembers", "Role");
        }
        public ActionResult Manager()
        {
            return RedirectToAction("getGroupsinDept", "Role");
        }
        public ActionResult Admin()
        {
            return RedirectToAction("getDepts", "Role");
        }

        [Route("Role/getEmployee")]
        [Route("Role/getEmployee/{Emp_ID}")]
        public ActionResult getEmployee(int? Emp_ID)
        {
            if (Emp_ID == null)
            {
                Employee e = (Employee)Session["Employee"];
                Emp_ID = e.Emp_ID; 
            }

            //WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Profile"] = JsonConvert.SerializeObject(dbo.getProfile((int)Emp_ID));
            return View();
        }

        [Route("Role/updateEmployee")]
        
        public ActionResult updateEmployee(string Name,string Email,string Mobile)
        {
            
           
            Employee e = (Employee)Session["Employee"];
            Employee E1 = new Employee();
            E1.Emp_ID = e.Emp_ID;
            E1.Emp_Name = Name;
            E1.Emp_Email = Email;
            E1.Emp_Pwd = e.Emp_Pwd;
            E1.Emp_Role = e.Emp_Role;
            E1.Group_ID = e.Group_ID;
            E1.Dept_ID = e.Dept_ID;
            E1.Mobile_Num = Mobile;
            
            

            //WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.PutProfile(E1);
            if(s== "1 row updated")
            {
                int empid = E1.Emp_ID;
                ViewData["Profile"] = JsonConvert.SerializeObject(dbo.getProfile(empid));
                return View();
            }
            else
            {
                ViewBag.msg = "Not updated";
                return RedirectToAction("getEmployee", "Role");
            }
           
            
        }

        [Route("Role/getGroupMembers")]
        [Route("Role/getGroupMembers/{Group_ID}")]
        public ActionResult getGroupMembers(int? Group_ID)// landing for lead
        {
            if (Group_ID == null)
            {
                Employee e = (Employee)Session["Employee"];
                Group_ID = e.Group_ID;
            }
            //WebAPIDBO dbo = new WebAPIDBO();
            ViewBag.groupid = Group_ID;
            ViewData["Group"] = JsonConvert.SerializeObject(dbo.GetGroupbygrpid((int)Group_ID));
            ViewData["GroupMembers"] = JsonConvert.SerializeObject(dbo.getGroupMembers((int)Group_ID));
            return View();
        }

        [Route("Role/getGroupsinDept")]
        [Route("Role/getGroupsinDept/{Dept_ID}")]
        public ActionResult getGroupsinDept(int? Dept_ID)// landing for manager
        {
            if (Dept_ID == null){
                Employee e = (Employee)Session["Employee"];
                Dept_ID = e.Dept_ID;//Dept_ID = dept of logged in manager
                           
            }
            //WebAPIDBO dbo = new WebAPIDBO();
            ViewBag.Dept_Name = dbo.GetDeptbygrpid((int)Dept_ID).Dept_Name;
            ViewBag.deptid = Dept_ID;
            ViewData["Dept"] = JsonConvert.SerializeObject(dbo.GetDeptbygrpid((int)Dept_ID));
            ViewData["Emps"] = JsonConvert.SerializeObject((Emp)Session["Emp"]);
            ViewData["GroupsinDept"] = JsonConvert.SerializeObject(dbo.GetGroupsinDept((int)Dept_ID));
            return View();
        }

        [Route("Role/unassignedgrp/{id}")]
        public ActionResult getunassignedGroup(int id)
        {
            //WebAPIDBO dbo = new WebAPIDBO
            List<Ticket_Info> alltickets = dbo.getTicketsGroup(id);
            List<Ticket_Info> unassigned = new List<Ticket_Info> { };
            if(alltickets != null) 
            {
                foreach (Ticket_Info ticket in alltickets)
                {
                    if (ticket.Assigned_To == null) unassigned.Add(ticket);
                }
            }
            ViewData["Group"] = JsonConvert.SerializeObject(dbo.GetGroupbygrpid(id));
            ViewData["UnassignedGroup"] = JsonConvert.SerializeObject(unassigned);
            return View();
        }

        [Route("Role/unassigneddept/{id}")]
        public ActionResult getunassignedDept(int id)
        {
            //WebAPIDBO dbo = new WebAPIDBO
            List<Ticket_Info> alltickets = dbo.getTicketsDept(id);
            List<Ticket_Info> unassigned = new List<Ticket_Info> { };
            if (alltickets != null)
            {
                foreach (Ticket_Info ticket in alltickets)
                {
                    if (ticket.Group_ID == null) unassigned.Add(ticket);
                }
            }
            
            ViewData["Dept"] = JsonConvert.SerializeObject(dbo.GetDeptbygrpid(id));
            ViewData["UnassignedDept"] = JsonConvert.SerializeObject(unassigned);
            return View();
        }

        [Authorize(Roles = "Admin")]
        [Route("Role/getDepts")]
        public ActionResult getDepts() // landing for admin
        {
            //WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Depts"] = JsonConvert.SerializeObject(dbo.getDepts());
            return View();
        }

        [Route("Role/getDeptforupdate")]
        [Route("Role/getDeptforupdate/{deptid}")]
        public ActionResult getDeptforupdate(int? deptid)
        {
            if(deptid==null)
            {
                ViewBag.msg = "The Department not updated , the values may be already assigned to others.";
                return View();
            }
            else
            {
                ViewData["Dept"] = JsonConvert.SerializeObject(dbo.GetDeptbygrpid((int)deptid));
                return View();
            }
           
        }


        [Route("Role/getGroupforupdate")]
        [Route("Role/getGroupforupdate/{grpid}")]
        public ActionResult getGroupforupdate(int? grpid)
        {
            if (grpid == null)
            {
                ViewBag.msg = "The Group not updated , the values may be already assigned to others.";
                            return View();
            }
            else
            {
                ViewData["Group"] = JsonConvert.SerializeObject(dbo.GetGroupbygrpid((int)grpid));
                return View();
            }
        }

        


        //Admin controls




        //

    }
}