using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Script.Serialization;

namespace ServiceDesk.Models
{
    public class WebAPIDBO
    {
        //internal bool validateLogin(int username, string password)
        //{

        //    Employee e = getProfile(username);
        //    if (e.Emp_Pwd == password) return true;
        //    else return false;
        //    //throw new NotImplementedException();
        //}


        //Get

        internal Ticket_Info getTicket(int ticketid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Ticket");
                    var s = client.BaseAddress + "/" + ticketid;
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        Ticket_Info T;
                        T = JsonConvert.DeserializeObject<Ticket_Info>(EmpResponse);
                        return T;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal Employee getProfile(int empid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Profile");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + empid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        Employee E;
                        E = JsonConvert.DeserializeObject<Employee>(EmpResponse);
                        return E;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }


        


        internal List<Group> getGroups()
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Groups");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(client.BaseAddress);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Group>  G=new List<Group>();
                        G = JsonConvert.DeserializeObject<List<Group>>(EmpResponse);
                        return G;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal List<Dept> getDepts()
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Depts");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(client.BaseAddress);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Dept> G = new List<Dept>();
                        G = JsonConvert.DeserializeObject<List<Dept>>(EmpResponse);
                        return G;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }



        internal List<Ticket_Info> getCreatedTickets(int empid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Createdby");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + empid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Ticket_Info> TE=new List<Ticket_Info>();
                        TE = JsonConvert.DeserializeObject<List<Ticket_Info>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal List<Ticket_Info> getTicketsGroup(int groupid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/TicketsGroup");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + groupid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Ticket_Info> TE = new List<Ticket_Info>();
                        TE = JsonConvert.DeserializeObject<List<Ticket_Info>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal List<Ticket_Info> getTicketsDept(int deptid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/TicketsDept");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + deptid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Ticket_Info> TE = new List<Ticket_Info>();
                        TE = JsonConvert.DeserializeObject<List<Ticket_Info>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        internal List<Ticket_Info> getAssignedTickets(int username)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Assignedto");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + username;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Ticket_Info> TE = new List<Ticket_Info>();
                        TE = JsonConvert.DeserializeObject<List<Ticket_Info>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        internal List<Employee> getGroupMembers(int groupid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/GroupMembers");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + groupid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Employee> TE = new List<Employee>();
                        TE = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal List<Group> GetGroupsinDept(int dept_id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/GroupsinDept");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + dept_id;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Group> TE = new List<Group>();
                        TE = JsonConvert.DeserializeObject<List<Group>>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }



        internal List<Employee> GetProfilesbyRole(string role)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/ProfilesbyRole");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + role;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        List<Employee> E = new List<Employee>();
                        E = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
                        return E;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }



        internal Group GetGroupbygrpid(int grp_id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Groupbygrpid");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + grp_id;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        Group TE = new Group();
                        TE = JsonConvert.DeserializeObject<Group>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }


        internal Dept GetDeptbygrpid(int grp_id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Deptbyid");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + grp_id;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        Dept TE = new Dept();
                        TE = JsonConvert.DeserializeObject<Dept>(EmpResponse);
                        return TE;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }




















        //Post
        internal string newTicket(Ticket_Info ticket)
        {
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/P_Ticket";
                string inputJson = (new JavaScriptSerializer()).Serialize(ticket);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if(json.Contains("Added"))
                {
                    return "Added";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch(Exception E)
            {
                return E.ToString();
            }
            
        }

        internal string newEmployee(Employee Emp)
        {
            
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/P_Profile";
                string inputJson = (new JavaScriptSerializer()).Serialize(Emp);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("Added"))
                {
                    return "Added";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }

        internal string newDept(Dept Dpt)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/P_Dept";
                string inputJson = (new JavaScriptSerializer()).Serialize(Dpt);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("Added"))
                {
                    return "Added";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }


        internal string newGroup(Group Grp)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/P_Grp";
                string inputJson = (new JavaScriptSerializer()).Serialize(Grp);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("Added"))
                {
                    return "Added";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }

        internal string PutTicket(Ticket_Info Tic)
        {
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Up_Ticket";
                string inputJson = (new JavaScriptSerializer()).Serialize(Tic);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("1 row updated"))
                {
                    return "1 row updated";
                }
                else
                {
                    return "Not Updated";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }

        internal string PutProfile(Employee Emp)
        {
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Up_Profile";
                string inputJson = (new JavaScriptSerializer()).Serialize(Emp);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("1 row updated"))
                {
                    return "1 row updated";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }

        internal string PutGroup(Group Grp)
        {
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/UP_Group";
                string inputJson = (new JavaScriptSerializer()).Serialize(Grp);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("1 row updated"))
                {
                    return "1 row updated";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }



        internal string PutDept(Dept Dpt)
        {
            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/UP_Dept";
                string inputJson = (new JavaScriptSerializer()).Serialize(Dpt);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, inputJson);
                if (json.Contains("1 row updated"))
                {
                    return "1 row updated";
                }
                else
                {
                    return "Not Added";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }




























        //Delete
        internal string Del_Ticket(int ticketid)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Del_Ticket";
                string s = ticketid.ToString();
                //string api = apiUrl + "/" + s;
                //string inputJson = (new JavaScriptSerializer()).Serialize(ticketid);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, s);
                if (json.Contains("Removed"))
                {
                    return "Removed";
                }
                else
                {
                    return "Not Record Found";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }
        internal string Del_Profile(int emp_id)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Del_Profile";
                string s = emp_id.ToString();
                //string api = apiUrl + "/" + s;
                //string inputJson = (new JavaScriptSerializer()).Serialize(ticketid);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, s);
                if (json.Contains("Removed"))
                {
                    return "Removed";
                }
                else
                {
                    return "Not Record Found";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }

        }
        internal string Del_Dept(int deptid)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Del_Dept";
                string s = deptid.ToString();
                //string api = apiUrl + "/" + s;
                //string inputJson = (new JavaScriptSerializer()).Serialize(ticketid);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, s);
                if (json.Contains("Removed"))
                {
                    return "Removed";
                }
                else
                {
                    return "Not Record Found";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }

        internal string Del_Group(int grp_id)
        {

            try
            {
                string apiUrl = "http://teamewebapi.azurewebsites.net/api/Values/Del_Grp";
                string s = grp_id.ToString();
                //string api = apiUrl + "/" + s;
                //string inputJson = (new JavaScriptSerializer()).Serialize(ticketid);
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiUrl, s);
                if (json.Contains("Removed"))
                {
                    return "Removed";
                }
                else
                {
                    return "Not Record Found";
                }
            }
            catch (Exception E)
            {
                return E.ToString();
            }
        }
        /*
        internal Dept GetDeptbyDeptID(int deptid)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://teamewebapi.azurewebsites.net/api/Values/Profile");
                    client.DefaultRequestHeaders.Clear();
                    var s = client.BaseAddress + "/" + deptid;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var Res = client.GetAsync(s);
                    Res.Wait();
                    var result = Res.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var EmpResponse = result.Content.ReadAsStringAsync().Result;
                        //EmpResponse.Wait();
                        Dept dept;
                        dept = JsonConvert.DeserializeObject<Dept>(EmpResponse);
                        return dept;
                        // = EmpResponse.Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        */
        internal Ticket_Names getTicket_Names(int ticketid, int? grpid, int? deptid, int? assign)
        {
            string groupname, deptname, assigned;
            if (grpid == null) groupname = "Unassigned";
            else groupname = GetGroupbygrpid((int)grpid).Group_Name;
            if (deptid == null) deptname = "Unassigned";
            else deptname = GetDeptbygrpid((int)deptid).Dept_Name; 
            if (assign == null) assigned = "Unassigned";
            else assigned = getProfile((int)grpid).Emp_Name;  
            Ticket_Names t = new Ticket_Names(ticketid,groupname,deptname,assigned);
            return t;
        }
    }
}