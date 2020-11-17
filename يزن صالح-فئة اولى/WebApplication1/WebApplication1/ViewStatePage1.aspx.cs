using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewStatePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["UserName"] = TextBox1.Text;
            ViewState["Password"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text= " ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(" UserName : " + ViewState["UserName"] + "  Password : " + ViewState["Password"]);
        }

     
    }
}