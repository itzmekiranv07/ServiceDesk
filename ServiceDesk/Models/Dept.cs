using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceDesk.Models
{
    public class Dept
    {

        public int Dept_ID { get; set; }    
        public string Dept_Name { get; set; }
        public Nullable<int> Manager_ID { get; set;}
    }

    }
}