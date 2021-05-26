using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mainpagedemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected override void OnPreInit(EventArgs e)
        {
            String s1 = Request.QueryString["name"].ToString();
            this.Theme = s1;
          
           
            if (s1 == "textcolor")
            {
                TextBox1.SkinID = "abc";
                TextBox2.SkinID = "abc";
                TextBox3.SkinID = "abc";
            }
            else
            {
                TextBox1.SkinID = "xyz";
                TextBox2.SkinID = "xyz";
                TextBox3.SkinID = "xyz";
            }
            base.OnPreInit(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            
        }
    }
}