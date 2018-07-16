using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            ctlLiteralTime.Text = now.ToString();
            Session["test"] = now;
        }
    }
}