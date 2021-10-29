using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

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
            Ticket_Info t1 = new Ticket_Info(1, 2, 3, 2, "keyboard not working", "Not Assigned", "Medium", 1, null, "A at 18:00 -> help pls");
            return t1;
            //throw new NotImplementedException();
        }

        internal object getTicketNames(int ticketid)
        {
            Ticket_Names t1 = new Ticket_Names(1, "Software", "IT", "Amit");
            return t1;
            // throw new NotImplementedException();
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
            Ticket_Info t1 = new Ticket_Info(1, 2, 3, 2, "keyboard not working", "Not Assigned", "Medium", null, null, "A at 18:00 -> help pls");
            Ticket_Info t2 = new Ticket_Info(2, 3, 3, 2, "keyboard not working", "Not Assigned", "Medium", null, null, "");
            List<Ticket_Info> t = new List<Ticket_Info> { t1, t2 };
            return t;
            //throw new NotImplementedException();
        }

        internal List<Employee> getGroupMembers(int groupid)
        {
            Employee e1 = new Employee(1, "Ashok", "ashok@gnail.com", "asdasd1232", "User", "12312312", 1, 2);
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
            Dept d1 = new Dept(1, "IT", 2);
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
        //internal Dept GetDeptbyid(int grp_id)
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("https://localhost:44397/api/Values/Deptbyid");
        //            client.DefaultRequestHeaders.Clear();
        //            var s = client.BaseAddress + "/" + grp_id;
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var Res = client.GetAsync(s);
        //            Res.Wait();
        //            var result = Res.Result;
        //            if (result.IsSuccessStatusCode)
        //            {
        //                var EmpResponse = result.Content.ReadAsStringAsync().Result;
        //                //EmpResponse.Wait();
        //                Dept TE = new Dept();
        //                TE = JsonConvert.DeserializeObject<Dept>(EmpResponse);
        //                return TE;
        //                // = EmpResponse.Result;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        throw E;
        //    }
        //}
        //internal Group GetGroupbyid(int grp_id)
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("https://localhost:44397/api/Values/Groupbygrpid");
        //            client.DefaultRequestHeaders.Clear();
        //            var s = client.BaseAddress + "/" + grp_id;
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var Res = client.GetAsync(s);
        //            Res.Wait();
        //            var result = Res.Result;
        //            if (result.IsSuccessStatusCode)
        //            {
        //                var EmpResponse = result.Content.ReadAsStringAsync().Result;
        //                //EmpResponse.Wait();
        //                Group TE = new Group();
        //                TE = JsonConvert.DeserializeObject<Group>(EmpResponse);
        //                return TE;
        //                // = EmpResponse.Result;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        throw E;
        //    }

        //}
        //internal List<Employee> GetProfilesbyRole(string role)
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("https://localhost:44397/api/Values/ProfilesbyRole");
        //            client.DefaultRequestHeaders.Clear();
        //            var s = client.BaseAddress + "/" + role;
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var Res = client.GetAsync(s);
        //            Res.Wait();
        //            var result = Res.Result;
        //            if (result.IsSuccessStatusCode)
        //            {
        //                var EmpResponse = result.Content.ReadAsStringAsync().Result;
        //                //EmpResponse.Wait();
        //                List<Employee> E = new List<Employee>();
        //                E = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
        //                return E;
        //                // = EmpResponse.Result;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        throw E;
        //    }
        //}
        //internal List<Group> GetGroupsinDept(int dept_id)
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("https://localhost:44397/api/Values/GroupsinDept");
        //            client.DefaultRequestHeaders.Clear();
        //            var s = client.BaseAddress + "/" + dept_id;
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var Res = client.GetAsync(s);
        //            Res.Wait();
        //            var result = Res.Result;
        //            if (result.IsSuccessStatusCode)
        //            {
        //                var EmpResponse = result.Content.ReadAsStringAsync().Result;
        //                //EmpResponse.Wait();
        //                List<Group> TE = new List<Group>();
        //                TE = JsonConvert.DeserializeObject<List<Group>>(EmpResponse);
        //                return TE;
        //                // = EmpResponse.Result;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        throw E;
        //    }
        //}

        ////Post
        //internal string PutTicket(Ticket_Info Tic)
        //{
        //    try
        //    {
        //        string apiUrl = "https://localhost:44397/api/Values/Up_Ticket";
        //        string inputJson = (new JavaScriptSerializer()).Serialize(Tic);
        //        WebClient client = new WebClient();
        //        client.Headers["Content-type"] = "application/json";
        //        client.Encoding = Encoding.UTF8;
        //        string json = client.UploadString(apiUrl, inputJson);
        //        if (json == "Added")
        //        {
        //            return "Added";
        //        }
        //        else
        //        {
        //            return "Not Added";
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        return E.ToString();
        //    }

        //}
        //internal string PutProfile(Employee Emp)
        //{
        //    try
        //    {
        //        string apiUrl = "https://localhost:44397/api/Values/Up_Profile";
        //        string inputJson = (new JavaScriptSerializer()).Serialize(Emp);
        //        WebClient client = new WebClient();
        //        client.Headers["Content-type"] = "application/json";
        //        client.Encoding = Encoding.UTF8;
        //        string json = client.UploadString(apiUrl, inputJson);
        //        if (json == "Added")
        //        {
        //            return "Added";
        //        }
        //        else
        //        {
        //            return "Not Added";
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        return E.ToString();
        //    }

        //}
        //internal string PutGroup(Group Grp)
        //{
        //    try
        //    {
        //        string apiUrl = "https://localhost:44397/api/Values/UP_Group";
        //        string inputJson = (new JavaScriptSerializer()).Serialize(Grp);
        //        WebClient client = new WebClient();
        //        client.Headers["Content-type"] = "application/json";
        //        client.Encoding = Encoding.UTF8;
        //        string json = client.UploadString(apiUrl, inputJson);
        //        if (json == "Added")
        //        {
        //            return "Added";
        //        }
        //        else
        //        {
        //            return "Not Added";
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        return E.ToString();
        //    }

        //}

        //internal string PutDept(Dept Dpt)
        //{
        //    try
        //    {
        //        string apiUrl = "https://localhost:44397/api/Values/UP_Dept";
        //        string inputJson = (new JavaScriptSerializer()).Serialize(Dpt);
        //        WebClient client = new WebClient();
        //        client.Headers["Content-type"] = "application/json";
        //        client.Encoding = Encoding.UTF8;
        //        string json = client.UploadString(apiUrl, inputJson);
        //        if (json == "Added")
        //        {
        //            return "Added";
        //        }
        //        else
        //        {
        //            return "Not Added";
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        return E.ToString();
        //    }

        //}

        //Delete


    }
}