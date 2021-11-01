using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceDesk.Models
{
    public class Emp
    {
        public Emp(int emp_ID, string emp_Name, string emp_Role)
        {
            Emp_ID = emp_ID;
            Emp_Name = emp_Name;
            Emp_Role = emp_Role;
        }

        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }

        public string Emp_Role { get; set; }
    }
    public class Employee
    {
        //public Employee(int emp_ID, string emp_Name, string emp_Email, string emp_Pwd, string emp_Role, string mobile_Num, int? dept_ID, int? group_ID)
        //{
        //    Emp_ID = emp_ID;
        //    Emp_Name = emp_Name;
        //    Emp_Email = emp_Email;
        //    Emp_Pwd = emp_Pwd;
        //    Emp_Role = emp_Role;
        //    Mobile_Num = mobile_Num;
        //    Dept_ID = dept_ID;
        //    Group_ID = group_ID;
        //}

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

        //public Ticket_Info(int ticket_ID, int emp_ID, int? dept_ID, int? group_ID, string title, string status_Info,
        //    string priority_Info, int? assigned_To, int? progress, string messagess)
        //{
        //    Ticket_ID = ticket_ID;
        //    Emp_ID = emp_ID;
        //    Dept_ID = dept_ID;
        //    Group_ID = group_ID;
        //    Title = title;
        //    Status_Info = status_Info;
        //    Priority_Info = priority_Info;
        //    Assigned_To = assigned_To;
        //    Progress = progress;
        //    Messagess = messagess;
        //}

    }

    public class Ticket_Names
    {
        public Ticket_Names(int ticket_ID, string group_Name, string dept_Name, string assigned_To_Name)
        {
            Ticket_ID = ticket_ID;
            Group_Name = group_Name;
            Dept_Name = dept_Name;
            Assigned_To_Name = assigned_To_Name;
        }

        public int Ticket_ID { get; set; }
        public string Group_Name { get; set; }
        public string Dept_Name { get; set; }
        public string Assigned_To_Name { get; set; }
    }

    public class Group
    {
        //public Group(int group_ID, string group_Name, int dept_ID, int? team_Lead_ID)
        //{
        //    Group_ID = group_ID;
        //    Group_Name = group_Name;
        //    Dept_ID = dept_ID;
        //    Team_Lead_ID = team_Lead_ID;
        //}

        public int Group_ID; 
        public string Group_Name { get; set; }
        public int Dept_ID { get; set; }
        public Nullable<int> Team_Lead_ID { get; set; }
    }

    public class Dept
    {
        //public Dept(int dept_ID, string dept_Name, int? manager_ID)
        //{
        //    Dept_ID = dept_ID;
        //    Dept_Name = dept_Name;
        //    Manager_ID = manager_ID;
        //}

        public int Dept_ID { get; set; }
        public string Dept_Name { get; set; }
        public Nullable<int> Manager_ID { get; set; }
    }

}