using System;
using System.Web.UI;

namespace SessionDemo
{
    public partial class DataBetweenRequests : Page
    {
        protected void Post_Click(object sender, EventArgs e)
        {
            var prev = ctlHiddenFieldAccumulator.Value;
            if (!string.IsNullOrWhiteSpace(ctlTextBoxUserInput.Text))
            {
                if (!string.IsNullOrEmpty(prev))
                {
                    prev += "; ";
                }
                prev += ctlTextBoxUserInput.Text;
            }
            ctlTextBoxUserInput.Text = string.Empty;

            ctlHiddenFieldAccumulator.Value = prev;
            ctlLiteralActionResult.Text = prev;
        }
    }
}