using Newtonsoft.Json;
using SessionDemo.Code;
using System.Web;
using System.Web.UI;

namespace SessionDemo
{
    public partial class Snippet : UserControl
    {
        protected override void Render(HtmlTextWriter writer)
        {
            ctlLiteralJs.Text = HttpUtility.HtmlEncode(@"
<script type=""text/javascript"" src=""https://somepartner.io/snippet.js""></script>
<script type=""text/javascript"">
    (function () {
        var snippet = new SomePartner.Snippet(""a_key"");
        snippet.reg(" + JsonConvert.SerializeObject(Context.GetActions()) + @");
    })();
</script>").Replace("\r\n", "<br>");
            base.Render(writer);
        }
    }
}