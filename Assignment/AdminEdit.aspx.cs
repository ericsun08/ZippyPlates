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
    public partial class AdminEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                string user_id= Request.QueryString["Id"];

                int intTest = Convert.ToInt32(user_id);

                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    using(SqlCommand cmd = new SqlCommand("SELECT * FROM customer_details WHERE Id=" + intTest))
                    {
                        using (SqlDataAdapter sda= new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using(DataTable dt=new DataTable())
                            {
                                sda.Fill(dt);
                                
                                foreach(DataRow row in dt.Rows)
                                {
                                    string userid = row["Id"].ToString();
                                    string first_name = row["first_name"] .ToString();
                                    string last_name = row["last_name"].ToString();
                                    string mobile_number = row["mobile_number"].ToString();
                                    string email = row["email"].ToString();
                                    string homeaddress = row["homeaddress"].ToString();
                                    string gender = row["gender"].ToString();

                                    this.HiddenField1.Value = userid;
                                    this.first_name.Text = first_name;
                                    this.last_name.Text = last_name;
                                    this.mobile_number.Text = mobile_number;
                                    this.email.Text = email;
                                    this.homeaddress.Text = homeaddress;
                                    this.gender.Text = gender;


                                }
                            }
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                string query = "UPDATE customer_details SET first_name=@first_name, last_name=@last_name, " +
                    "mobile_number=@mobile_number, email=@email, homeaddress=@homeaddress, gender=@gender WHERE Id=@userid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@userid", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@mobile_number", mobile_number.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@homeaddress", homeaddress.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("AdminSite.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}