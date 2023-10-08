using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Guang
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Console.WriteLine("SS" + Request.Path);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Console.WriteLine("BR" + Request.Path);
            if (Request.Path == "/") {
                string code = Request.QueryString["code"];
                if(code == "jjk")
                {
                    Response.Redirect("Auth/Name.aspx");
                }
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Console.WriteLine("AA" + Request.Path);
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}