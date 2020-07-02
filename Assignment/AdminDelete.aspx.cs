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
    public partial class AdminDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int user_id = Convert.ToInt32(Request.QueryString["Id"]);
                SqlConnection con = new SqlConnection(ConfigurationManager
                    .ConnectionStrings["ConnectionString"].ConnectionString);

                string query = "DELETE FROM customer_details WHERE Id=" + user_id;

                SqlCommand cmd = new SqlCommand(query, con);

                

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("AdminSite.aspx");
                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}