using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DevOpApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            using (log4net.ThreadContext.Stacks["NDC"].Push("Application_Start"))
            {
                log.DebugFormat("Begin: {0}",this.Context.Server);
                AreaRegistration.RegisterAllAreas();
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);
            }
        }

        protected void Application_End()
        {
            using (log4net.ThreadContext.Stacks["NDC"].Push("Application_End"))
            {
                log.DebugFormat("Begin: {0}", this.Context.Server);
            }
        }

        protected void Application_BeginRequest()
        {
            using (log4net.ThreadContext.Stacks["NDC"].Push("Application_BeginRequest"))
            {
                log.DebugFormat("Begin: {0}", this.Request.RawUrl);
            }
        }

        protected void Application_EndRequest()
        {
            using (log4net.ThreadContext.Stacks["NDC"].Push("Application_EndRequest"))
            {
                log.DebugFormat("Begin: {0}", this.Request.RawUrl);
            }
        }
    }
}
