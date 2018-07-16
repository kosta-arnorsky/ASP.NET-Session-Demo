using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Fast : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlLiteralTime.Text = "... have no idea";
            ctlLiteralEnded.Text = DateTime.Now.ToString();
        }
    }
}