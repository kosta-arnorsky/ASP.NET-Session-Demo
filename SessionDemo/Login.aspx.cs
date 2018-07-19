using System;
using System.Web.Security;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Login : Page
    {
        protected void Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ctlTextBoxUsername.Text))
            {
                // Validate credentials, if they are OK:
                FormsAuthentication.SetAuthCookie(ctlTextBoxUsername.Text, true);
                Response.Redirect("~/Protected/");
            }
        }
    }
}