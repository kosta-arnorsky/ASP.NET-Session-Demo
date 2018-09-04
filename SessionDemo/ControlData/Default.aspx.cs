using FakeBackend;
using System;

namespace SessionDemo
{
    public partial class ControlData : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var items = Repository.GetItems();
            ctlItemListItems.Bind(items);
        }
    }
}