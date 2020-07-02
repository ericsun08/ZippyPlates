using Microsoft.AspNet.FriendlyUrls;
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
    public partial class AfterLogin : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["restoran"] = null;
            Session["menu"] = null;
            if (Session["user"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                cmd.Connection = con;
                con.Open();
                showdata();
                image();
                cart();
            }

            if (!this.IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {

                    html.Append("<div class=\"box\">");
                    html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                    html.Append("<img src=\"upload/");
                    html.Append(row["img_upload"]);
                    html.Append("\" width=\"100%\"");
                    html.Append("\" border-radius=\"5px\"");
                    html.Append("\" height=\"130px\">");
                    html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                    html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                    html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                    html.Append("</a>");
                    html.Append("</div>");
                }
                
                
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

            }

            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Chinese'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Fast Food'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Dessert'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Healthy'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Western'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Malay'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Beverages'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Japanese'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Korean'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Indonesian'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Arabic'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details where category='Singaporean'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {


                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + row["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(row["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + row["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + row["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + row["city"] + ", " + row["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");


            }
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (Session["carti"] == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('You have no item')", true);
                Response.Redirect("AfterLogin.aspx");
            }
            else
            {
                Response.Redirect("Payment.aspx");
            }
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("SignIn.aspx");
        }

        public void showdata()
        {
            cmd.CommandText = "SELECT * FROM customer_details WHERE email='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "customer_details");
            Label2.Text = "Hi," + "&nbsp;" + ds.Tables[0].Rows[0]["first_name"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["first_name"].ToString() + "&nbsp;" + ds.Tables[0].Rows[0]["last_name"].ToString(); 
            Label4.Text = ds.Tables[0].Rows[0]["email"].ToString();
            Label5.Text = ds.Tables[0].Rows[0]["mobile_number"].ToString();

            StringBuilder html = new StringBuilder();
            html.Append("<a class=\"edit\" href=\"UserProfile.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Edit Profile</a>");
            html.Append("<a onClick=\"return confirm('Are you sure want to delete this account permanently?')\" class=\"delete\" href=\"deleteCustomer.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Delete</a>");
            PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });

            
            
        }

        public void image()
        {
            cmd.CommandText = "SELECT * FROM customer_details WHERE email='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "customer_details");

            StringBuilder html = new StringBuilder();
            string gen = ds.Tables[0].Rows[0]["gender"].ToString();
            if (gen.Equals("Male"))
            {
                html.Append("<img src=\"img/Male.png\" width=\"70px\" height=\"70px\" float=\"left\" />");
                PlaceHolder3.Controls.Add(new Literal { Text = html.ToString() });
            }
            else
            {
                html.Append("<img src=\"img/Female.png\" width=\"70px\" height=\"70px\" float=\"left\" />");
                PlaceHolder3.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        private DataTable GetData()
        {
            String constr = ConfigurationManager.ConnectionStrings
                ["ConnectionString2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM restaurant_details"))
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string qr = "SELECT * FROM restaurant_details where restaurant_name='" + TextBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();

                HiddenField1.Value = dr["id"].ToString();

                html.Append("<div class=\"box\">");
                html.Append("<a href=\"DisplayRestaurant.aspx?Id=" + dr["id"] + "\">");
                html.Append("<img src=\"upload/");
                html.Append(dr["img_upload"]);
                html.Append("\" width=\"100%\"");
                html.Append("\" border-radius=\"5px\"");
                html.Append("\" height=\"130px\">");
                html.Append("<h4 class=\"Rname\">" + dr["restaurant_name"] + "</h4>");
                html.Append("<p class=\"Rcaption\">" + dr["category"] + "</p>");
                html.Append("<p class=\"Rcaption\">" + dr["city"] + ", " + dr["restaurant_address"] + "</p>");
                html.Append("</a>");
                html.Append("</div>");

                SqlCommand cmdj = new SqlCommand();
                SqlConnection conf = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                SqlDataAdapter sdaf = new SqlDataAdapter();
                DataSet dsr = new DataSet();
                string restoran = HiddenField1.Value;
                int restoranid = Convert.ToInt32(restoran);
                cmdj.CommandText = "SELECT * FROM restaurant_details WHERE id= " + restoranid;
                cmdj.Connection = conf;
                sdaf.SelectCommand = cmdj;
                sdaf.Fill(dsr);
                if (dsr.Tables[0].Rows.Count > 0 || dsr.Tables[0].Rows.Count < 2)
                {
                    Session["restoran"] = restoran;
                }
                else
                {
                    Response.Redirect("AfterLogin.aspx");
                }

                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
            
            else
            {
               
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

        public void cart()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();
                int total = 0;

                if(dt.Rows.Count == 0)
                {
                    Session["carti"] = null;
                }
                else
                {
                    Session["carti"] = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        string cartid = row["Id"].ToString();
                        string customerid = row["customer_id"].ToString();
                        string menid = row["menu_id"].ToString();
                        string restid = row["restaurant_id"].ToString();
                        string menuprice = row["menu_price"].ToString();
                        string menuname = row["menu_name"].ToString();
                        string restname = row["restaurant_name"].ToString();

                        Session["cart"] = cartid;
                        int murah = Convert.ToInt32(menuprice);
                        total = total + murah;

                        html.Append("<div class=\"menu\">");
                        html.Append("<p class=\"rPara\">" + menuname + "</p>");
                        html.Append("<p class=\"rPara2\">" + "RM" + " " + menuprice + "</p>");
                        html.Append("<a onClick=\"return confirm('Are you sure want to delete this menu from the cart?')\" class=\"delete1\" href=\"deletecart.aspx?Id=" + row["id"] + "\">Remove</a>");
                        html.Append("</div>");
                    }
                    String totals = Convert.ToString(total);
                    Label7.Text = "RM" + " " + totals;
                    PlaceHolder4.Controls.Add(new Literal { Text = html.ToString() });
                }

                
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}