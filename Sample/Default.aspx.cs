using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Sample
{
    public partial class _Default : Page
    {
        protected HtmlGenericControl frame1;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.rpIFrame.Attributes.Add("src", "rpIFrame.aspx");
           
        }
    }
}