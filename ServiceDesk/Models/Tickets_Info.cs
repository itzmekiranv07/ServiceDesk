//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDesk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets_Info
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
    
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Group Group { get; set; }
    }
}
