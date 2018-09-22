using System;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace SessionDemo
{
    public partial class AjaxSession : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = "User Id";
        }

        [WebMethod]
        public static string LockSession()
        {
            var userId = HttpContext.Current.Session["user"] as string;

            Thread.Sleep(7000);
            return "Session has been unlocked, " + DateTime.Now.ToString("mm:ss.fff");
        }

        [WebMethod]
        public static string AnAction()
        {
            var userId = HttpContext.Current.Session["user"] as string;

            Thread.Sleep(1000);
            return "Session is used, " + DateTime.Now.ToString("mm:ss.fff");
        }
    }
}