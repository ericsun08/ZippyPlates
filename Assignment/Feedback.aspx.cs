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
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cart();
        }
        private DataTable GetDiti()
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
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM customer_details WHERE id =" + syalalali))
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

        public void cart()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDiti();
                StringBuilder html = new StringBuilder();
                int total = 0;

                foreach (DataRow row in dt.Rows)
                {
                    
                    string first_name = row["first_name"].ToString();
                    string email = row["email"].ToString();
                    string last_name = row["last_name"].ToString();

                    HiddenField1.Value = first_name + " " + last_name;
                    HiddenField2.Value = email;

                }
               
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["ConnectionString2"].ConnectionString);
            try
            {
                con.Open();

                string restid = Session["restoran"].ToString();
                string query = "INSERT INTO feedback (name, email, message, restaurant_id) VALUES (@name,@email,@message,@restid)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@email", HiddenField2.Value);
                cmd.Parameters.AddWithValue("@message", TextBox3.Text);
                cmd.Parameters.AddWithValue("@restid", restid);

                cmd.ExecuteNonQuery();
                
                Response.Redirect("AfterLogin.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            
            
          
        }
    }
}