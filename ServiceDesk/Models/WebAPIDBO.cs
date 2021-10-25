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

        internal Ticket getTicket(int ticketid)
        {
            throw new NotImplementedException();
        }

        internal Profile getProfile(int empid)
        {
            throw new NotImplementedException();
        }

        internal List<Ticket> getCreatedTickets(int username)
        {
            throw new NotImplementedException();
        }


        internal List<Ticket> getTicketsGroup(int groupid)
        {
            throw new NotImplementedException();
        }


        internal List<Ticket> getTicketsDept(int deptid)
        {
            throw new NotImplementedException();
        }

        internal List<Ticket> getAssignedTickets(int username)
        {
            throw new NotImplementedException();
        }

        internal List<Profile> getGroupMembers(int groupid)
        {
            throw new NotImplementedException();
        }

        internal List<Group> getGroups(int deptid)
        {
            throw new NotImplementedException();
        }

        internal List<Profile> getProfiles(string role)
        {
            throw new NotImplementedException();
        }


        //Put
        internal string newTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        internal string newEmployee()
        {

        }
    }
}