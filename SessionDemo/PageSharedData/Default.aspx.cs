using FakeBackend;
using System;
using System.Web;

namespace SessionDemo
{
    public partial class PageSharedData : BasePage
    {
        private Item _item;

        // Othe options:
        //  - private Lazy<Item> _item;
        //  - initialize on page load
        protected Item Item
        {
            get
            {
                if (_item == null)
                {
                    if (long.TryParse(Request["id"], out long id))
                    {
                        _item = Repository.GetItem(id);
                    }
                    if (_item == null)
                    {
                        throw new HttpException(404, "Not found");
                    }
                }

                return _item;
            }
        }

        protected void DoSomething_Click(object sender, EventArgs e)
        {
            ctlLiteralActionResult.Text = "Still have access the Item ID " + Item.Id + " without calling the repository twice or saving it in the session.";
        }
    }
}