using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="admin" && TextBox2.Text=="password")
            {
                Response.Redirect("AdminMenu.aspx");  
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
            }    
        }
    }
}