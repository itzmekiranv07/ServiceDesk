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
            throw new NotImplementedException();
        }

        internal List<Ticket_Info> getCreatedTickets(int username)
        {
            Ticket_Info t1 = new Ticket_Info(1, 2, 3, 2, "keyboard not working", "Not Assigned", "Medium", null, null, "A at 18:00 -> help pls");
            Ticket_Info t2 = new Ticket_Info(2, 3, 3, 2, "not working", "Not Assigned", "Medium", null, null, "");
            Ticket_Info t3 = new Ticket_Info(1, 2, 3, 2, "mouse not working", "Not Assigned", "Medium", null, null, "A at 18:00 -> help pls");
            Ticket_Info t4 = new Ticket_Info(2, 3, 3, 2, "screen not working", "Not Assigned", "Medium", null, null, "");
            List<Ticket_Info> t = new List<Ticket_Info> { t1, t2, t3, t4 };
            return t;
            //throw new NotImplementedException();
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
            Employee e1 = new Employee(1,"Ashok","ashok@gnail.com", "asdasd1232" ,"User", "12312312", 1, 2);
            Employee e2 = new Employee(2, "Alok", "alok@gnail.com", "wrsd1232", "User", "12312312", 1, 2);

            return new List<Employee> { e1, e2 };

            //throw new NotImplementedException();
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