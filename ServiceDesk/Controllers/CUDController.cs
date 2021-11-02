using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class CUDController : Controller
    {
        // GET: CUD
        [Route("CUD/delDept/{Dep_ID}")]
        public ActionResult delDept(int Dep_ID)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            string s=dbo.Del_Dept(Dep_ID);
            ViewBag.msg = s;
            return View();
        }

        [Route("CUD/delGrp/{Grp_ID}")]
        public ActionResult delGrp(int Grp_ID)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.Del_Group(Grp_ID);
            ViewBag.msg = s;
            return View();
        }

        [Route("CUD/delEmp/{Emp_ID}")]
        public ActionResult delEmp(int Emp_ID)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.Del_Profile(Emp_ID);
            ViewBag.msg = s;
            return View();
        }

        [Route("CUD/delTic/{Tic_ID}")]
        public ActionResult delTic(int Tic_ID)
        {
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.Del_Ticket(Tic_ID);
            ViewBag.msg = s;
            return Redirect(Request.UrlReferrer.ToString());
        }

        //Update

        [Route("CUD/updateDept")]

        public ActionResult updateDept( int Dept_ID, string Dept_Name, int Managerid)
        {
            Dept D = new Dept();
            D.Dept_ID = Dept_ID;
            D.Dept_Name = Dept_Name;
            D.Manager_ID = Managerid;
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.PutDept(D);
            if (s.Contains("1 row updated"))
            {
                int deptid = D.Dept_ID;
                ViewData["Dept"] = JsonConvert.SerializeObject(dbo.GetDeptbygrpid(deptid));
                return RedirectToAction("getDeptforupdate", "Role", new { @deptid = D.Dept_ID });
            }
            else
            {
                ViewBag.msg = "Not updated";
                return RedirectToAction("getDeptforupdate", "Role");
            }
        }

        [Route("CUD/updateGrp")]

        public ActionResult updateGrp(int Grp_ID, string Grp_Name, int deptid,int teamleadid)
        {
            Group G = new Group();
            G.Group_ID = Grp_ID;
            G.Group_Name = Grp_Name;
            G.Dept_ID = deptid;
            G.Team_Lead_ID = teamleadid;
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.PutGroup(G);
            if (s.Contains("1 row updated"))
            {
                int grpid = G.Group_ID;
                ViewData["Group"] = JsonConvert.SerializeObject(dbo.GetGroupbygrpid(G.Group_ID));
                return RedirectToAction("getGroupforupdate", "Role", new { @grpid = G.Group_ID });
            }
            else
            {
                ViewBag.msg = "Not updated";
                return RedirectToAction("getGroupforupdate", "Role");
            }
        }


        //create emp
        [Route("CUD/createEmp")]
        [HttpGet]
        public ActionResult createEmp()
        {
            return View();
        }
        [Route("CUD/createEmp")]
        [HttpPost]
        public ActionResult createEmp(int empid,string empname,string email,string password,string role,string mobile,int deptid,int grpid)
        {
            Employee E = new Employee();
            E.Emp_ID = empid;
            E.Emp_Name = empname;
            E.Emp_Email = email;
            E.Emp_Pwd = password;
            E.Emp_Role = role;
            E.Mobile_Num = mobile;
            E.Dept_ID = deptid;
            E.Group_ID = grpid;
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.newEmployee(E);
            ViewBag.msg = s;
            return View();
        }

        //create Dept
        [Route("CUD/createDept")]
        [HttpGet]
        public ActionResult createDept()
        {
            return View();
        }
        [Route("CUD/createDept")]
        [HttpPost]
        public ActionResult createDept(int Dept_ID, string Dept_Name, int? Managerid)
        {
            Dept D = new Dept();
            D.Dept_ID = Dept_ID;
            D.Dept_Name = Dept_Name;
            D.Manager_ID = Managerid;
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.newDept(D);
            ViewBag.msg = s;
            return View();
        }

        //create grp
        [Route("CUD/createGrp")]
        [HttpGet]
        public ActionResult createGrp()
        {
            return View();
        }
        [Route("CUD/createGrp")]
        [HttpPost]
        public ActionResult createGrp(int Grp_ID, string Grp_Name, int deptid, int teamleadid)
        {
            Group G = new Group();
            G.Group_ID = Grp_ID;
            G.Group_Name = Grp_Name;
            G.Dept_ID = deptid;
            G.Team_Lead_ID = teamleadid;
            WebAPIDBO dbo = new WebAPIDBO();
            string s = dbo.newGroup(G);
            ViewBag.msg = s;
            return View();
        }

    }


}