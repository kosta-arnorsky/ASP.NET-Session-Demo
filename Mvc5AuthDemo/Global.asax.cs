using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Routing;

namespace Mvc5AuthDemo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }
    }
}
