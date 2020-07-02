using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<div class=\"box\">");
                    html.Append("<a href=\"DisplayRestaurant2.aspx?Id=" + row["id"] + "\">");
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


                    html.Append("<div class=\"box\">");
                    html.Append("<a href=\"DisplayRestaurant2.aspx?Id=" + dr["id"] + "\">");
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

                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
            else
            {
                Label1.Text = "The Restaurant you search is not exist";
                Label1.Visible = true;
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


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSignIn.aspx");
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}