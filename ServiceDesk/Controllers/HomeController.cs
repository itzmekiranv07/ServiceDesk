using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Newtonsoft.Json;
using Owin;
using ServiceDesk.Models;

namespace ServiceDesk.Controllers
{
    public class HomeController : Controller
    {


        [AllowAnonymous]
        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(int empid, string pass_word)
        {
            WebAPIDBO dbo = new WebAPIDBO();

            Employee E=new Employee();
            E = dbo.getProfile(empid);
            if(E != null && E.Emp_ID==empid && E.Emp_Pwd == pass_word)
            {
                Employee e = dbo.getProfile(empid);
                Session["Employee"] = dbo.getProfile(empid);
                Session["Emp"] = new Emp(e.Emp_ID,e.Emp_Name,e.Emp_Role);
                //
                /*
                var ident = new ClaimsIdentity(
                new[] { 
                    // adding following 2 claim just for supporting default antiforgery provider
                    new Claim(ClaimTypes.NameIdentifier,E.Emp_ID.ToString()),
                    new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"),

                    new Claim(ClaimTypes.Name,E.Emp_ID.ToString()),

                    // optionally you could add roles if any
                    new Claim(ClaimTypes.Role, E.Emp_Role),
                    //new Claim(ClaimTypes.Role, "AnotherRole"),

                    },
                    DefaultAuthenticationTypes.ApplicationCookie);
                
                    HttpContext.GetOwinContext().Authentication.SignIn(
                    new AuthenticationProperties { IsPersistent = false }, ident);


                *///
                return RedirectToAction("StartRoute", "Role");
            }
            else
            {
                ViewBag.msg = "Enter Valid Details";
                return View();
            }

        }
        [Route("Home/Logout")]
        public ActionResult Logout()
        {
            Session["Employee"] = null;
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.AddHeader("Cache-control", "no-store, must-revalidate, private, no-cache");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");
            Response.AppendToLog("window.location.reload();");
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public void X(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            });
        }

    }
    }
