using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace Sample
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