using FakeBackend;
using System;
using System.Web.Security;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Protected : Page
    {
        private Profile _userProfile;

        protected Profile UserProfile
        {
            get
            {
                if (_userProfile == null)
                {
                    var userManager = new UserManager(new { someoption = "somevalue" });
                    _userProfile = userManager.GetProfile(User.Identity.Name);
                }

                return _userProfile;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ctlLiteralUsername.Text = UserProfile.Username;
            ctlLiteralName.Text = UserProfile.Name;
            ctlLiteralPosition.Text = UserProfile.Position;
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}