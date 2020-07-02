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
    public partial class UserProfile : System.Web.UI.Page
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
                                    string email = row["email"].ToString();
                                    string first_name = row["first_name"].ToString();
                                    string last_name = row["last_name"].ToString();
                                    string gender = row["gender"].ToString();
                                    string mobile_number = row["mobile_number"].ToString();
                                    string homeaddress = row["homeaddress"].ToString();

                                    this.HiddenField1.Value = customerid;
                                    this.HiddenField2.Value = email;
                                    this.first_name.Text = first_name;
                                    this.last_name.Text = last_name;
                                    this.gender.Text = gender;
                                    this.mobile_number.Text = mobile_number;
                                    this.homeaddress.Text = homeaddress;
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
            html.Append("<a class=\"change\" href=\"ChangePassword.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Change Password?</a>");
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                string query = "UPDATE customer_details SET email=@email, first_name=@first_name, last_name=@last_name, gender=@gender, mobile_number=@mobile_number, homeaddress=@homeaddress WHERE Id=@customerid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customerid", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@email", HiddenField2.Value);
                cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);
                cmd.Parameters.AddWithValue("@mobile_number", mobile_number.Text);
                cmd.Parameters.AddWithValue("@homeaddress", homeaddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Profile successfully changed')", true);
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}