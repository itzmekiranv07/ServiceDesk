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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Groups = new HashSet<Group>();
            this.Tickets_Info = new HashSet<Tickets_Info>();
            this.Tickets_Info1 = new HashSet<Tickets_Info>();
        }
    
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public string Emp_Pwd { get; set; }
        public string Emp_Role { get; set; }
        public string Mobile_Num { get; set; }
        public Nullable<int> Dept_ID { get; set; }
        public Nullable<int> Group_ID { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets_Info> Tickets_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets_Info> Tickets_Info1 { get; set; }
    }
}
