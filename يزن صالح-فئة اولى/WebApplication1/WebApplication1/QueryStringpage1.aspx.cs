using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QueryStringpage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropDownList1.Items.Add("فلسطين");
                DropDownList1.Items.Add("سوريا");
                DropDownList1.Items.Add("لبنان");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryStringpage2.aspx?Name= " + TextBox1.Text + "&Age= " + TextBox2.Text + "&City= " + DropDownList1.SelectedItem.Text+"&Gender="+RadioButtonList1.Text);
            
        }
    }
}