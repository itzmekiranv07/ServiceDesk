using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace ServiceDesk.Controllers
{

    public class TicketController : Controller
    {
        [Route("Ticket/getTicket")]
        [Route("Ticket/getTicket/{ticketid}")]
        public ActionResult getTicket(int? ticketid) 
        {
            if (ticketid == null) ticketid = -1;
            WebAPIDBO dbo = new WebAPIDBO();
            Ticket_Info t = dbo.getTicket((int)ticketid);
            //ViewData["UserNow"] = JsonConvert.SerializeObject((Employee)Session["Employee"]);
            ViewData["UserNow"] = JsonConvert.SerializeObject(dbo.getProfile(0));
            ViewData["Tickets"] = JsonConvert.SerializeObject(t);
            ViewData["TicketNames"] = JsonConvert.SerializeObject(dbo.getTicketNames((int)ticketid));
            ViewData["Depts"] = JsonConvert.SerializeObject(dbo.getDepts());
            
            if(t.Dept_ID != null) ViewData["Groups"] = JsonConvert.SerializeObject(dbo.getGroups((int)t.Dept_ID));
            if (true) ViewData["Emps"] = JsonConvert.SerializeObject(dbo.getGroupMembers((int)t.Group_ID));//check for manager

            return View();
        }

        public ActionResult getnewTicket(int i)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            return View();
        }

        public ActionResult getCreatedTickets()
        {
            WebAPIDBO dbo = new WebAPIDBO();
            Employee e = (Employee)Session["Employee"];
            ViewData["CreatedTickets"]  = JsonConvert.SerializeObject(dbo.getCreatedTickets(0)); 
            return View();
        }

        [Route("Ticket/getAssignedTickets")]
        [Route("Ticket/getAssignedTickets/{empid}")]
        public ActionResult getAssignedTickets(int? empid)
        {
            if (empid == null) empid = 0;// empid = id of logged in employee
            Employee e = (Employee)Session["Employee"];
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["AssignedTickets"] = JsonConvert.SerializeObject(dbo.getAssignedTickets(0));
            return View();
        }

        

    }
}