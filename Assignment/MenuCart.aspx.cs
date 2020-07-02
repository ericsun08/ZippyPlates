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
    public partial class MenuCart : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["restoran"] == null)
            {
                Response.Redirect("DisplayRestaurant.aspx");
            }
            else
            {
                if(Session["menu"] == null)
                {
                    string men_id = Request.QueryString["Id"];
                    int intTest = Convert.ToInt32(men_id);
                    Session["menu"] = men_id;
                }
                showdata2();
                showdata();
                
            }
            
        }

        public void showdata()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM menu_details", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                con.Close();
                string restaurant_id = ds.Tables[0].Rows[0]["restaurant_id"].ToString();
                String price = "Price: ";
                String rm = "RM";

                foreach (DataRow row in dt.Rows)
                {
                    string menuid = row["MenuId"].ToString();
                    string menu_name = row["menu_name"].ToString();
                    string menu_price = row["menu_price"].ToString();

                    this.HiddenField2.Value = menuid;
                    this.HiddenField3.Value = menu_price;
                    this.menu_name.Text = menu_name;
                    this.menu_price.Text = price+menu_price+rm;

                    html.Append("<div class=\"image\">");
                    html.Append("<img src=\"upload/");
                    html.Append(row["menu_image"]);
                    html.Append("\" height=\"170px\"");
                    html.Append("\" width=\"300px\">");
                    html.Append("</div>");
                }

                PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

       

        public void showdata2()
        {
            if (!IsPostBack)
            {
                string restaid = Session["menu"].ToString();
                int intTests = Convert.ToInt32(restaid);
                SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                cons.Open();
                SqlDataAdapter sdas = new SqlDataAdapter("SELECT * FROM menu_details WHERE MenuId=" + intTests, cons);
                DataSet ds = new DataSet();
                sdas.Fill(ds);
                cons.Close();
                string restaurant_id = ds.Tables[0].Rows[0]["restaurant_id"].ToString();

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
                            StringBuilder html = new StringBuilder();
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                foreach (DataRow row in dt.Rows)
                                {
                                    string restaurantid = row["Id"].ToString();
                                    string restaurant_name = row["restaurant_name"].ToString();
                                    string restaurant_address = row["restaurant_address"].ToString();
                                    string city = row["city"].ToString();
                                    string category = row["category"].ToString();

                                    this.HiddenField1.Value = restaurantid;
                                    this.restaurant_name.Text = restaurant_name;
                                    this.category.Text = category;
                                    this.city.Text = city;
                                    this.restaurant_address.Text = restaurant_address;

                                    html.Append("<div class=\"image\">");
                                    html.Append("<img src=\"upload/");
                                    html.Append(row["img_upload"]);
                                    html.Append("\" height=\"200px\"");
                                    html.Append("\" width=\"350px\">");
                                    html.Append("</div>");
                                    PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

                                }
                            }
                        }
                    }
                }
            }
        }

        private DataTable GetData()
        {
            string restaurant_id = Session["menu"].ToString();
            int intTest = Convert.ToInt32(restaurant_id);
            String constr = ConfigurationManager.ConnectionStrings
                ["ConnectionString2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM menu_details WHERE MenuId =" + intTest))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }

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

        public void Check()
        {
            DataTable dtq = this.GetDoto();
            StringBuilder html = new StringBuilder();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cart_table",con );
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            String lalali = Session["restoran"].ToString();
            int syala = Convert.ToInt32(lalali);

            foreach (DataRow row in dtq.Rows)
            {
                string cartid = row["Id"].ToString();
                int syalass = Convert.ToInt32(cartid);
                string customer_id = row["customer_id"].ToString();
                string meuid = row["menu_id"].ToString();
                string restauid = row["restaurant_id"].ToString();
                string menprice = row["menu_price"].ToString();
                string mename = row["menu_name"].ToString();
                string restauname = row["restaurant_name"].ToString();

                if(restauid != lalali)
                {
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
                    catch(Exception ex)
                    {
                        Response.Write("Error: " + ex.ToString());
                    }
                }
            }
        }
        

        protected void Button3_Click(object sender, EventArgs e)
        {
            Check();
            SqlCommand cmdd = new SqlCommand();
            SqlConnection cond = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataAdapter sdad = new SqlDataAdapter();
            DataSet dsdd = new DataSet();
            cmdd.CommandText = "SELECT * FROM customer_details WHERE email='" + Session["user"] + "'";
            cmdd.Connection = cond;
            sdad.SelectCommand = cmdd;
            sdad.Fill(dsdd, "customer_details");
            String syalala = dsdd.Tables[0].Rows[0]["id"].ToString();
            int syala = Convert.ToInt32(syalala);
            try
            {
                SqlConnection con = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["ConnectionString"].ConnectionString);
                con.Open();

                string query = "INSERT INTO cart_table (customer_id, menu_id, restaurant_id, menu_price, menu_name, restaurant_name) VALUES (@customer_id, @menu_id, @restaurant_id, @menu_price, @menu_name, @restaurant_name)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customer_id", syala);
                cmd.Parameters.AddWithValue("@menu_id", HiddenField2.Value);
                cmd.Parameters.AddWithValue("@restaurant_id", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@menu_price", HiddenField3.Value);
                cmd.Parameters.AddWithValue("@menu_name", menu_name.Text);
                cmd.Parameters.AddWithValue("@restaurant_name", restaurant_name.Text);

                cmd.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('You have successfully registered')", true);
                Response.Redirect("MenuCart.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayRestaurant.aspx");
        }

    }
}