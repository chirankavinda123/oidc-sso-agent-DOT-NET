using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample2
{
    public partial class _Default : Page
    {
        public Dictionary<String, String> Claims { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Claims = (Dictionary<String, String>)HttpContext.Current.Session["claims"];
            this.rpIFrame.Attributes.Add("src", "rpIFrame.aspx");
        }
    }
}