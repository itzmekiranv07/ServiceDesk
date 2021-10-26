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
        [Route("Ticket/getTicket/{ticketid}")]
        public ActionResult getTicket(string ticketid)
        { 
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Tickets"] = JsonConvert.SerializeObject(dbo.getTicket(int.Parse(ticketid)));
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
            ViewData["CreatedTickets"]  = JsonConvert.SerializeObject(dbo.getCreatedTickets(e.Emp_ID)); 
            return View();
        }

        public ActionResult getAssignedTickets()
        {
            Employee e = (Employee)Session["Employee"];
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["AssignedTickets"] = JsonConvert.SerializeObject(dbo.getAssignedTickets(0));
            return View();
        }

        

    }
}