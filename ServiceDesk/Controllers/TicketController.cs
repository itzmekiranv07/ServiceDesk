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
            WebAPIDBO dbo = new WebAPIDBO();
            Employee e = (Employee)Session["Employee"];
            ViewData["Emp"] = JsonConvert.SerializeObject((Employee)Session["Employee"]);
            ViewData["Groups"] = "null";
            ViewData["EmpsinGroup"] = "null";
            ViewData["Depts"] = "null";
            

            if (ticketid == null)//new ticket
            {
                Ticket_Info newticket = new Ticket_Info();
                newticket.Ticket_ID = -1; newticket.Progress = 0; newticket.Priority_Info = "Low";newticket.Messagess = "";
                newticket.Group_ID = null; newticket.Dept_ID = null; newticket.Emp_ID = e.Emp_ID;newticket.Title = "";
                newticket.Status_Info = ""; newticket.Assigned_To = null;
                ViewData["Tickets"] = JsonConvert.SerializeObject(newticket);
                ViewData["TicketNames"] = JsonConvert.SerializeObject(dbo.getTicket_Names(-1,null,null,null));
                ViewData["Depts"] = JsonConvert.SerializeObject(dbo.getDepts());
            }
            else
            {
                Ticket_Info t = dbo.getTicket((int)ticketid);
                //Ticket_Names tn = dbo.getTicket_Names(t.Ticket_ID, t.Group_ID, t.Dept_ID, t.Assigned_To);
                ViewData["Tickets"] = JsonConvert.SerializeObject(t);
                ViewData["TicketNames"] = JsonConvert.SerializeObject(dbo.getTicket_Names(t.Ticket_ID, t.Group_ID, t.Dept_ID, t.Assigned_To));
            }

            if (e.Emp_Role == "Manager")
            {
                ViewData["Groups"] = JsonConvert.SerializeObject(dbo.GetGroupsinDept((int)e.Dept_ID));
            }
            if (e.Emp_Role == "Lead")
            {
                ViewData["EmpsinGroup"] = JsonConvert.SerializeObject(dbo.getGroupMembers((int)e.Group_ID));
            }


            
            return View();
        }



        public string putTicket(Ticket_Info ticket)
        {
            string s;
            //Ticket_Info ticket = JsonConvert.DeserializeObject<Ticket_Info>(t);
            WebAPIDBO dbo = new WebAPIDBO();
            if (ticket.Ticket_ID == -1)
            {
                s = dbo.newTicket(ticket);
            }
            else s = dbo.PutTicket(ticket);
            
            return s;
        }

        [Route("Ticket/getCreatedTickets")]
        public ActionResult getCreatedTickets()
        {
            WebAPIDBO dbo = new WebAPIDBO();
            Employee e = (Employee)Session["Employee"];
            ViewData["CreatedTickets"]  = JsonConvert.SerializeObject(dbo.getCreatedTickets(e.Emp_ID)); 
            return View();
        }

        [Route("Ticket/getAssignedTickets")]
        [Route("Ticket/getAssignedTickets/{empid}")]
        public ActionResult getAssignedTickets(int? empid)
        {
            
            Employee e = (Employee)Session["Employee"];
            if (empid == null) empid = e.Emp_ID;// empid = id of logged in employee
            
            WebAPIDBO dbo = new WebAPIDBO();
            ViewData["AssignedTickets"] = JsonConvert.SerializeObject(dbo.getAssignedTickets((int)empid));
            return View();
        }

        

    }
}