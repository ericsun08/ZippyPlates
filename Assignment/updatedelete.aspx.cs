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
    public partial class updatedelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            update();
            delete();
            Session["cart"] = null;
            Response.Redirect("Feedback.aspx");
        }

        private DataTable GetDoto()
        {
            SqlCommand cmddw = new SqlCommand();
            SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataAdapter sdads = new SqlDataAdapter();
            DataSet dsdde = new DataSet();
            cmddw.CommandText = "SELECT * FROM customer_details WHERE email='" + Session["user"] + "'";
            cmddw.Connection = conde;
            sdads.SelectCommand = cmddw;
            sdads.Fill(dsdde, "customer_details");
            String syalalali = dsdde.Tables[0].Rows[0]["id"].ToString();

            String constrdd = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conss = new SqlConnection(constrdd))
            {
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM cart_table WHERE customer_id =" + syalalali))
                {
                    using (SqlDataAdapter sdadss = new SqlDataAdapter())
                    {
                        cmdaa.Connection = conss;
                        sdadss.SelectCommand = cmdaa;
                        using (DataTable dtq = new DataTable())
                        {
                            sdadss.Fill(dtq);
                            return dtq;
                        }
                    }
                }
            }
        }

        public void update()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    string cartid = row["Id"].ToString();
                    string customerid = row["customer_id"].ToString();
                    string menid = row["menu_id"].ToString();
                    string restid = row["restaurant_id"].ToString();
                    string menuprice = row["menu_price"].ToString();
                    string menuname = row["menu_name"].ToString();
                    string restname = row["restaurant_name"].ToString();
                    Session["restoran"] = restid;

                    try
                    {
                        SqlConnection con = new SqlConnection
                        (ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                        con.Open();

                        string query = "INSERT INTO ordertable (customer_id, menu_id, restaurant_id, menu_price, menu_name, restaurant_name) VALUES (@customer_id, @menu_id, @restaurant_id, @menu_price, @menu_name, @restaurant_name)";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@customer_id", customerid);
                        cmd.Parameters.AddWithValue("@menu_id", menid);
                        cmd.Parameters.AddWithValue("@restaurant_id", restid);
                        cmd.Parameters.AddWithValue("@menu_price", menuprice);
                        cmd.Parameters.AddWithValue("@menu_name", menuname);
                        cmd.Parameters.AddWithValue("@restaurant_name", restname);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.ToString());
                    }

                }  
            }
        }

        public void delete()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    string cartid = row["Id"].ToString();
                    string customerid = row["customer_id"].ToString();
                    string menid = row["menu_id"].ToString();
                    string restid = row["restaurant_id"].ToString();
                    string menuprice = row["menu_price"].ToString();
                    string menuname = row["menu_name"].ToString();
                    string restname = row["restaurant_name"].ToString();

                    try
                    {
                        int custid = Convert.ToInt32(Request.QueryString["cartid"]);

                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                        string query = "DELETE FROM cart_table WHERE Id=" + cartid;

                        SqlCommand cmd = new SqlCommand(query, con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.ToString());
                    }

                }
            }
        }
    }
}