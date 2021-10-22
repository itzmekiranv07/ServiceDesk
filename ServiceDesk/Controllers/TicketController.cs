using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceDesk.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Ticket(int ticketid = -1)
        {
            ViewBag.Ticketid = ticketid;

            return View();
        }


    }
}