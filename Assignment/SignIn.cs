using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class SignIn : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("AfterLogin.aspx");
            }
            else
            {
                cmd.Connection = con;
                con.Open();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string user = TextBox1.Text.Trim();
            cmd.CommandText = "SELECT * FROM customer_details WHERE email='" + TextBox1.Text.Trim() + "' AND password ='" + TextBox2.Text.Trim() + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "customer_details");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["user"] = user;
                Response.Redirect("AfterLogin.aspx");
            }
            else if (TextBox1.Text == null || TextBox2.Text == null)
            {

            }
            else 
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Invalid Credentials, Either your Email or Password is incorrect')", true);
            }

        }
    }
}