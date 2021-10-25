﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class HomeController : Controller
    {

        Employee E = new Employee();
        [AllowAnonymous]
        [HttpGet]

        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]

        public ActionResult Index (int empid, string pass_word)
        {
            /*
            Employee E = new Employee();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44336/api/");
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string s= "values/" + empid;
                var Res = client.GetAsync(s);
                Res.Wait();
                var result = Res.Result;
                if (result.IsSuccessStatusCode)
                {

                    var EmpResponse = result.Content.ReadAsStringAsync().Result;
                    //EmpResponse.Wait();
                    E = JsonConvert.DeserializeObject<Employee>(EmpResponse);
                    // = EmpResponse.Result;
                }
                else
                {


                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }

            }

            if (E.Empid==empid && E.Password==pass_word)
            {
                Session["Employee"] = E;
                Session["role"] = "User";

                if (E.Role_assigned == "Users") return RedirectToAction("Users", "Role");
                    else if (E.Role_assigned== "Lead") return RedirectToAction("Lead", "Role");
                 else if (E.Role_assigned == "Manager") return RedirectToAction("Manager", "Role");
                else return RedirectToAction("Admin", "Role");
            }
            else
            {
                ViewBag.msg = "Wrong Credentials";
                return View();
            }
                
            */

            return View();
            
        }

       
    }
}