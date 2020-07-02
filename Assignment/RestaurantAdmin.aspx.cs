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
    public partial class Restaurant_Admin : System.Web.UI.Page
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
                    html.Append("<a class=\"edit1\" href=\"RestaurantAdminEdit.aspx?Id=" + row["id"] + "\">Edit</a>");

                    html.Append("<a onClick=\"return confirm('Delete this record?')\" class=\"delete1\" href=\"RestaurantAdminDelete.aspx?Id=" + row["id"] + "\">Delete</a>");
                    html.Append("</div>");

                }
               PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private DataTable GetData()
        {

            string constr = ConfigurationManager.ConnectionStrings
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
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string search = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM restaurant_details WHERE restaurant_name like '%" + TextBox1.Text + "%'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("restaurant_name", TextBox1.Text);
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
    }
    
}