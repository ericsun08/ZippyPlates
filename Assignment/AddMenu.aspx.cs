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
    public partial class AddMenu : System.Web.UI.Page
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

            first_name.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);

                string file_name = menu_image.FileName.ToString() + "";
                menu_image.PostedFile.SaveAs(Server.MapPath("~/upload/") + file_name);

                string query = "INSERT INTO menu_details (menu_name, menu_price, menu_image, restaurant_id) VALUES (@menu_name, @menu_price, '" + file_name + "' , @restaurant_id)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@menu_name", menu_name.Text);
                cmd.Parameters.AddWithValue("@menu_price", menu_price.Text);
                cmd.Parameters.AddWithValue("@menu_image", menu_image.FileBytes);
                cmd.Parameters.AddWithValue("@restaurant_id", HiddenField1.Value);

                con.Open();
                cmd.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('You have successfully registered')", true);
                Response.Redirect("OwnerAfterLogin.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }


        }
    }
}