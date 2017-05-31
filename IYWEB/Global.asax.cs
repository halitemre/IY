using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IYWEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static int UsersConnected { get; set; }

        protected void Application_Start()
        {
            Application.Add("UserCount", 0); 
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            Application.Lock();
            UsersConnected++;
            if (Application["UserCount"] == null)
            {
                Application.Add("UserCount", UsersConnected);
            }
            Application["UserCount"] = UsersConnected;
            Application.UnLock(); 



        }  
    }
}
