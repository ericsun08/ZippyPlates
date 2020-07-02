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
    public partial class AdminSignIn : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userr"] != null)
            {
                Response.Redirect("OwnerAfterLogin.aspx");
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
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" 
                + TextBox1.Text + "' AND password ='" + TextBox2.Text + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["userr"] = user;
                Response.Redirect("OwnerAfterLogin.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert" +
                    "('Invalid Credentials, Either your Email or Password is incorrect')", true);
            }

        }
    }
}