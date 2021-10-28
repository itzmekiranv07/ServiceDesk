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
            Employee e = getProfile(username);
            if (e.Emp_Pwd == password) return true;
            else return false;
            //throw new NotImplementedException();
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
            Employee e1 = new Employee(1, "Kiran", "kiran@mail.com", "2234", "User", "79989786898", 1, 2);
            Employee e2 = new Employee(2, "Amit", "amit@mail.com", "abc@123", "Lead", "123456789", 1, 2);
            return e2;
            //throw new NotImplementedException();
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
            Group g1 = new Group(1, "Hardware", 1, 1);
            Group g2 = new Group(2, "Software", 1, 2);
            return new List<Group> { g1, g2 };
            //throw new NotImplementedException();
        }

        internal List<Dept> getDepts()
        {
            Dept d1 = new Dept(1,"IT",2);
            Dept d2 = new Dept(2, "Finance", 3);
            return new List<Dept> { d1, d2 };
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