using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceDesk.Models
{
    public class WebAPIDBO
    {
        internal bool validateLogin(int username, string password)
        {
            throw new NotImplementedException();
        }


        internal string getRole(int username)
        {
            throw new NotImplementedException();
        }

        //Get

        internal Ticket_Info getTicket(int ticketid)
        {
            Ticket_Info t1 = new Ticket_Info(1, 2, 3, 2, "keyboard not working", "Not Assigned", "Medium", null, null, "A at 18:00 -> help pls");
            return t1;
            //throw new NotImplementedException();
        }

        internal Employee getProfile(int empid)
        {
            Employee e = new Employee(1, "Kiran", "kiran@mail.com", "2234", "xvy", "79989786898", 1, 2);
            return e;
            //throw new NotImplementedException();
        }

        internal List<Ticket_Info> getCreatedTickets(int username)
        {
            throw new NotImplementedException();
        }


        internal List<Ticket_Info> getTicketsGroup(int groupid)
        {
            throw new NotImplementedException();
        }


        internal List<Ticket_Info> getTicketsDept(int deptid)
        {
            throw new NotImplementedException();
        }

        internal List<Ticket_Info> getAssignedTickets(int username)
        {
            Ticket_Info t1 = new Ticket_Info(1, 2, 3, 2, "keyboard not working", "Not Assigned", "Medium",null,null,"A at 18:00 -> help pls");
            Ticket_Info t2 = new Ticket_Info(2, 3, 3, 2, "keyboard not working", "Not Assigned", "Medium", null, null, "");
            List<Ticket_Info> t = new List<Ticket_Info>{ t1, t2 };
            return t;
            //throw new NotImplementedException();
        }

        internal List<Employee> getGroupMembers(int groupid)
        {
            throw new NotImplementedException();
        }

        internal List<Group> getGroups(int deptid)
        {
            throw new NotImplementedException();
        }

        internal List<Dept> getDepts()
        {
            throw new NotImplementedException();
        }

        internal List<Employee> getProfiles(string role)
        {
            throw new NotImplementedException();
        }


        //Put
        internal string newTicket(Ticket_Info ticket)
        {
            throw new NotImplementedException();
        }

        internal string newEmployee()
        {
            throw new NotImplementedException();
        }
    }
}