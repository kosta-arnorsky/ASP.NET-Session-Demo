using SessionDemo.Code;
using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class External : UserControl
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Context.RegistreAction("External displayed");
        }
    }
}