using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LogErrors
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Response.Clear();

            HttpException httpexception = ex as HttpException;

            int error = httpexception != null ? httpexception.GetHttpCode() : 0;

            Server.ClearError();

            Response.Redirect(string.Format("~/Error/?error={0}", error, ex.Message));
        }
    }
}
