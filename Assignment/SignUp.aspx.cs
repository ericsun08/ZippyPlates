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
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            string validate_username = "SELECT * from customer_details WHERE email=@email";

            con.Open();

            SqlCommand cmd_validate = new SqlCommand(validate_username, con);
            cmd_validate.Parameters.AddWithValue("email", email.Text);
            SqlDataReader sdr = cmd_validate.ExecuteReader();

            if (sdr.HasRows)
            {
                emailwarning.Text = "Email does exists";
                emailwarning.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Close();

                try
                {
                    string query = "INSERT INTO customer_details (first_name, last_name, gender, email, mobile_number, homeaddress, password) " +
                        "VALUES (@first_name, @last_name, @gender, @email, @mobile_number, @homeaddress, @password)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                    cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                    cmd.Parameters.AddWithValue("@gender", gender.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@mobile_number", mobile_number.Text);
                    cmd.Parameters.AddWithValue("@homeaddress", homeaddress.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    con.Open();

                    cmd.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('You have successfully registered')", true);
                    Response.Redirect("SignUp.aspx");

                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.ToString());
                }
            } 
        }
    }
}