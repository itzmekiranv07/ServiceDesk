using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceDesk.Models
{
    public class Employee
    {
        public int Empid{ get; set; }
        public string Password{ get; set; }
        public string Role_assigned{ get; set; }
        public string des { get; set; } 
    }

    public class Ticket
    {
        public int ticketId { get; set; }
        public int title { get; set; }
    }

    public class Group
    {

    }

    public class Dept
    {

    }

    public class Profile
    {

    }
}