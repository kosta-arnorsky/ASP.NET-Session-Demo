using System;
using System.Threading;
using System.Web.UI;

namespace SessionDemo
{
    public partial class FatPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(7000);
            ctlLiteralTime.Text = Session["test"].ToString();
            ctlLiteralEnded.Text = DateTime.Now.ToString();
        }
    }
}