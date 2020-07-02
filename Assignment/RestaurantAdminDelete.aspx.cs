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
    public partial class RestaurantAdminDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int restaurant_id= Convert.ToInt32(Request.QueryString["Id"]);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);

                string query = "DELETE FROM restaurant_details WHERE Id=" + restaurant_id;

                SqlCommand cmd = new SqlCommand(query, con);



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