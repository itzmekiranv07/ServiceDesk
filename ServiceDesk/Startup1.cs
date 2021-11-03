using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IO;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

//[assembly: OwinStartup(typeof(StartupDemo.Startup))]

[assembly: OwinStartup(typeof(ServiceDesk.Startup1))]

namespace ServiceDesk
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            /*app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            });*/
        }
    }
}
