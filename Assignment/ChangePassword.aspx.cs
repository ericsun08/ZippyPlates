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
    public partial class ChangePassword : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            showdata();

            if (!IsPostBack)
            {
                string customer_id = Request.QueryString["Id"];

                int intTest = Convert.ToInt32(customer_id);

                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM customer_details WHERE Id=" + intTest))
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
                                    string customerid = row["Id"].ToString();

                                    this.HiddenField1.Value = customerid;
                                    
                                }
                            }
                        }
                    }
                }
            }
        }

        public void showdata()
        {
            cmd.CommandText = "SELECT * FROM customer_details WHERE email='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "customer_details");

            StringBuilder html = new StringBuilder();
            html.Append("<a class=\"profile\" href=\"UserProfile.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Edit Profile</a>");
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customer_details WHERE Id='" + HiddenField1.Value + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            string currentpassword = ds.Tables[0].Rows[0]["password"].ToString();
            if (currentpassword == current_password.Text)
            {
                if (new_password.Text == confirmation.Text)
                {

                    con.Open();
                    string query = "UPDATE customer_details SET password='" + new_password.Text + "' WHERE Id='" + HiddenField1.Value + "'";

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