using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QueryStringpage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
          Label1.Text=(Request.QueryString.Get("Name") + " is " + Request.QueryString.Get("Age")+" is " + Request.QueryString.Get("City")+" is "+Request.QueryString.Get("Gender"));
            Label1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}