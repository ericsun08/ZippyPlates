using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class RestaurantChangePass : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            showdata();

            if (!IsPostBack)
            {
                string restaurant_id = Request.QueryString["Id"];

                int intTest = Convert.ToInt32(restaurant_id);

                string constr = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM restaurant_details WHERE Id=" + intTest))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                foreach (DataRow row in dt.Rows)
                                {
                                    string restaurantid = row["Id"].ToString();

                                    this.HiddenField1.Value = restaurantid;

                                }
                            }
                        }
                    }
                }
            }
        }

        public void showdata()
        {
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");

            StringBuilder html = new StringBuilder();
            html.Append("<a class=\"profile\" href=\"RestaurantProfile.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Edit Profile</a>");
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM restaurant_details WHERE Id='" + HiddenField1.Value + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            string currentpassword = ds.Tables[0].Rows[0]["password"].ToString();
            if (currentpassword == current_password.Text)
            {
                if (new_password.Text == confirmation.Text)
                {

                    con.Open();
                    string query = "UPDATE restaurant_details SET password='" + new_password.Text + "' WHERE Id='" + HiddenField1.Value + "'";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@password", new_password.Text);

                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Password successfully changed')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Password Does Not match')", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Invalidlid Password')", true);
            }
        }

    }
}