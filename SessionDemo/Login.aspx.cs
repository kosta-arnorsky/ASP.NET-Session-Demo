using FakeBackend;
using System;
using System.Web.Security;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Login : Page
    {
        private Lazy<UserManager> _userManager = new Lazy<UserManager>(() => new UserManager(new { someoption = "somevalue" }));

        protected void Login_Click(object sender, EventArgs e)
        {
            var user = _userManager.Value.GetUser(ctlTextBoxUsername.Text);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, true);
                Response.Redirect("~/Protected/");
            }
            else
            {
                ctlLabelError.Text = "Invalid credentials.";
            }
        }
    }
}