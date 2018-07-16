using System;
using System.Threading;
using System.Web.Services;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Ajax : Page
    {
        [WebMethod]
        public static string AnAction()
        {
            Thread.Sleep(1000);
            return "Sesson is used, " + DateTime.Now.ToString("mm:ss.fff");
        }
    }
}