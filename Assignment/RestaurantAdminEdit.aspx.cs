using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class RestaurantAdminEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                                    string category = row["category"].ToString();
                                    string city = row["city"].ToString();
                                    string restaurantaddress = row["restaurant_address"].ToString();


                                    this.HiddenField1.Value = restaurantid;
                                    this.restaurant_name.Text = restaurant_name;
                                    this.category.Text = category;
                                    this.city.Text = city;
                                    this.restaurantaddress.Text = restaurantaddress;



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
               

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                string query = "UPDATE restaurant_details SET restaurant_name=@restaurant_name, category=@category, city=@city, restaurant_address=@restaurant_address WHERE Id=@restaurantid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@restaurantid", HiddenField1.Value);
              
                cmd.Parameters.AddWithValue("@restaurant_name", restaurant_name.Text);
                cmd.Parameters.AddWithValue("@category", category.Text);
                cmd.Parameters.AddWithValue("@city", city.Text);
                cmd.Parameters.AddWithValue("@restaurant_address", restaurantaddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("RestaurantAdmin.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}