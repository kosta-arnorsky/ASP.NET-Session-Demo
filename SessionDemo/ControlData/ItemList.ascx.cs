using FakeBackend;
using System.Collections.Generic;
using System.Web.UI;

namespace SessionDemo
{
    public partial class ItemList : UserControl
    {
        public void Bind(IEnumerable<Item> items)
        {
            ctlListViewItems.DataSource = items;
            ctlListViewItems.DataBind();
        }
    }
}