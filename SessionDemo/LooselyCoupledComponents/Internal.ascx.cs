using SessionDemo.Code;
using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Internal : UserControl
    {
        public string Name { get; set; }

        protected void Post_Click(object sender, EventArgs e)
        {
            Context.RegistreAction(Name + " clicked");
        }
    }
}