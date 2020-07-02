using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class RestaurantForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                 (ConfigurationManager.ConnectionStrings
                 ["ConnectionString2"].ConnectionString);

            try
            {
                con.Open();

                string file_name = img_upload.FileName.ToString() + "";
                img_upload.PostedFile.SaveAs(Server.MapPath("~/upload/") + file_name);

                string query = "INSERT INTO restaurant_details (restaurant_name, city, restaurant_address, category, first_name, last_name, mobile_phone, email_address, img_upload, password) VALUES (@restaurant_name, @city, @restaurant_address, @category, @first_name, @last_name, @mobile_phone, @email_address, '"+file_name+"', @password)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@restaurant_name", restaurant_name.Text);
                cmd.Parameters.AddWithValue("@city", city.Text);
                cmd.Parameters.AddWithValue("@restaurant_address", restaurant_address.Text);
                cmd.Parameters.AddWithValue("@category", category.Text);
                cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@mobile_phone", mobile_phone.Text);
                cmd.Parameters.AddWithValue("@email_address", email_address.Text);
                cmd.Parameters.AddWithValue("@img_upload", img_upload.FileBytes);
                cmd.Parameters.AddWithValue("@password", password.Text);
             
                cmd.ExecuteNonQuery();

                Response.Redirect("RestaurantForm.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}