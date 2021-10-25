using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult getTicket(int ticketid = -1)
        {
            ViewBag.Ticketid = ticketid;
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["Tickets"] = dbo.getTicket(ticketid);
            return View();
        }

        public ActionResult getnewTicket()
        {
            return View();
        }

        public ActionResult getCreatedTickets()
        {
            WebAPIDBO dbo = new WebAPIDBO();
            Employee e = (Employee)Session["Employee"];
            ViewData["CreatedTickets"]  = dbo.getCreatedTickets(e.Empid); 
            return View();
        }

        public ActionResult getAssignedTickets(int emp_id)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["AssignedTickets"] = dbo.getAssignedTickets(emp_id);
            return View();
        }

        public ActionResult getProfile(int emp_id)
        {
            return View();
        }

    }
}