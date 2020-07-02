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
using Microsoft.SqlServer.Server;
using System.Web.DynamicData;

namespace Assignment
{
    public partial class AdminSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DataTable dt = this.GetData();

                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<div class=\"box\">");

                    html.Append("<h3>" + row["first_name"] +" "+ row["last_name"] + "</h3>");
                    html.Append("Mobile Number:<br>" + row["mobile_number"] + "<br><br>");
                    html.Append("Email:<br>" + row["email"] + "<br><br>");
                    html.Append("Home Address:<br>" + row["homeaddress"] + "<br><br>"); 
                    html.Append("Gender:<br>" + row["gender"] + "<br><br>");

                    html.Append("<a class=\"edit\" href=\"AdminEdit.aspx?Id=" + row["id"] + "\">Edit</a>");

                    html.Append("<a onClick=\"return confirm('Delete this record?')\" class=\"delete\" href=\"AdminDelete.aspx?Id=" + row["id"] + "\">Delete</a>");

                    html.Append("</div>");
                }
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        
        private DataTable GetData()
        {

            string constr = ConfigurationManager.ConnectionStrings
                ["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM customer_details"))
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
            string search = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(search);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * FROM customer_details WHERE first_name like '%" + TextBox1.Text + "%' UNION SELECT * FROM customer_details WHERE last_name like '%" + TextBox1.Text + "%'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("first_name", TextBox1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            StringBuilder html = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<div class=\"box\">");

                html.Append("<h3>" + row["first_name"] + " " + row["last_name"] + "</h3>");
                html.Append("Mobile Number:<br>" + row["mobile_number"] + "<br><br>");
                html.Append("Email:<br>" + row["email"] + "<br><br>");
                html.Append("Home Address:<br>" + row["homeaddress"] + "<br><br>");
                html.Append("Gender:<br>" + row["gender"] + "<br><br>");

                html.Append("</div>");


            }


            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}