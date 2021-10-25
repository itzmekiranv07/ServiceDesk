﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceDesk.Models
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public string Emp_Pwd { get; set; }
        public string Emp_Role { get; set; }
        public string Mobile_Num { get; set; }
        public Nullable<int> Dept_ID { get; set; }
        public Nullable<int> Group_ID { get; set; }
    }

    public class Ticket_Info
    {
        public int Ticket_ID { get; set; }
        public int Emp_ID { get; set; }
        public Nullable<int> Dept_ID { get; set; }
        public Nullable<int> Group_ID { get; set; }
        public string Title { get; set; }
        public string Status_Info { get; set; }
        public string Priority_Info { get; set; }
        public Nullable<int> Assigned_To { get; set; }
        public Nullable<int> Progress { get; set; }
        public string Messagess { get; set; }
    }

    public class Group
    {
        public int Group_ID { get; set; }
        public string Group_Name { get; set; }
        public int Dept_ID { get; set; }
        public Nullable<int> Team_Lead_ID { get; set; }
    }

    public class Dept
    {
        public int Dept_ID { get; set; }
        public string Dept_Name { get; set; }
        public Nullable<int> Manager_ID { get; set; }
    }

}