using FakeBackend;
using System;

namespace SessionDemo
{
    public partial class ControlData2 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlListViewItems.DataSource = Repository.GetItems();
            ctlListViewItems.DataBind();
        }
    }
}