using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace 上机3任务2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["total"] = 0;
            Application["online"] = 0;
            Application.UnLock();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["online"] = Convert.ToInt32(Application["online"]) + 1;
            Application["total"] = Convert.ToInt32(Application["total"]) + 1;

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["online"] = Convert.ToInt32(Application["online"]) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}