using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class FastSession : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlLiteralTime.Text = Session["test"].ToString();
            ctlLiteralEnded.Text = DateTime.Now.ToString();
        }
    }
}