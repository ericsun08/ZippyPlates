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
    public partial class RestaurantProfile : System.Web.UI.Page
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
                                    string restaurant_name = row["restaurant_name"].ToString();
                                    string city = row["city"].ToString();
                                    string restaurant_address = row["restaurant_address"].ToString();
                                    string category = row["category"].ToString();
                                    string first_name = row["first_name"].ToString();
                                    string last_name = row["last_name"].ToString();
                                    string mobile_phone = row["mobile_phone"].ToString();

                                    this.HiddenField1.Value = restaurantid;
                                    this.first_name.Text = first_name;
                                    this.last_name.Text = last_name;
                                    this.mobile_phone.Text = mobile_phone;
                                    this.restaurant_address.Text = restaurant_address;
                                    this.category.Text = category;
                                    this.restaurant_name.Text = restaurant_name;
                                    this.city.Text = city;
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
            html.Append("<a class=\"change\" href=\"RestaurantChangePass.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Change Password?</a>");
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);

                string query = "UPDATE restaurant_details SET restaurant_name=@restaurant_name, restaurant_address=@restaurant_address, category=@category, first_name=@first_name, last_name=@last_name, mobile_phone=@mobile_phone, city=@city WHERE Id=@restaurantid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@restaurantid", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@restaurant_name", restaurant_name.Text);
                cmd.Parameters.AddWithValue("@category", category.Text);
                cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@mobile_phone", mobile_phone.Text);
                cmd.Parameters.AddWithValue("@city", city.Text);
                cmd.Parameters.AddWithValue("@restaurant_address", restaurant_address.Text);

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