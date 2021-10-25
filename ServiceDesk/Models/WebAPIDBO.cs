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
            throw new NotImplementedException();
        }

        internal Employee getProfile(int empid)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        internal List<Employee> getGroupMembers(int groupid)
        {
            throw new NotImplementedException();
        }

        internal List<Group> getGroups(int deptid)
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