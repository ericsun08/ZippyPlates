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
    public partial class deletemenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            delete_cart();
            delete();
            Response.Redirect("OwnerAfterLogin.aspx");
        }

        public void delete()
        {
            try
            {
                int customer_id = Convert.ToInt32(Request.QueryString["Id"]);

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);

                string query = "DELETE FROM menu_details WHERE MenuId=" + customer_id;

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

        private DataTable GetDoto()
        {
            int customer_id = Convert.ToInt32(Request.QueryString["Id"]);

            SqlCommand cmddw = new SqlCommand();
            SqlDataAdapter sdads = new SqlDataAdapter();

            String constrdd = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conss = new SqlConnection(constrdd))
            {
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM cart_table WHERE menu_id =" + customer_id))
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

        public void delete_cart()
        {
            DataTable dtq = this.GetDoto();
            int custmer_id = Convert.ToInt32(Request.QueryString["Id"]);

            foreach (DataRow row in dtq.Rows)
            {
                string cartid = row["Id"].ToString();
                int syalass = Convert.ToInt32(cartid);
                string customer_id = row["customer_id"].ToString();
                string meuid = row["menu_id"].ToString();
                int cust_id = Convert.ToInt32(Request.QueryString["meuid"]);
                string restauid = row["restaurant_id"].ToString();
                string menprice = row["menu_price"].ToString();
                string mename = row["menu_name"].ToString();
                string restauname = row["restaurant_name"].ToString();

                    try
                    {
                        int delete_id = Convert.ToInt32(cartid);

                        SqlConnection condo = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        condo.Open();
                        string query = "DELETE FROM cart_table WHERE Id= " + delete_id;

                        SqlCommand cmdded = new SqlCommand(query, condo);

                        cmdded.ExecuteNonQuery();
                        condo.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.ToString());
                    }


                
            }
        }
    }
}