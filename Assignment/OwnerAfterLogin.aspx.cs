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
    public partial class OwnerAfterLogin : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userr"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                cmd.Connection = con;
                con.Open();
                menushow();
                showdata();
                insert();
                showdata2();
                feedbackshow();
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["userr"] = null;
            Response.Redirect("AdminSignIn.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPlacedOrder.aspx");
        }

        public void showdata()
        {
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");
            first_name.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
            restaurant_name.Text = ds.Tables[0].Rows[0]["restaurant_name"].ToString();
            category.Text = ds.Tables[0].Rows[0]["category"].ToString();
            city.Text = ds.Tables[0].Rows[0]["city"].ToString();
            restaurant_address.Text = ds.Tables[0].Rows[0]["restaurant_address"].ToString();

            StringBuilder html = new StringBuilder();
            html.Append("<div class=\"image\">");
            html.Append("<img src=\"upload/");
            html.Append(ds.Tables[0].Rows[0]["img_upload"]);
            html.Append("\" height=\"200px\"");
            html.Append("\" width=\"350px\">");
            html.Append("</div>");
            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

        }

        public void insert()
        {
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");

            StringBuilder html = new StringBuilder();
            html.Append("<a class=\"insert\" href=\"AddMenu.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Insert Menu</a>");
            PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });
        }

        private DataTable GetDoto()
        {
            SqlCommand cmddw = new SqlCommand();
            SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            SqlDataAdapter sdads = new SqlDataAdapter();
            DataSet dsdde = new DataSet();
            cmddw.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmddw.Connection = conde;
            sdads.SelectCommand = cmddw;
            sdads.Fill(dsdde, "restaurant_details");
            String syalalali = dsdde.Tables[0].Rows[0]["id"].ToString();

            String constrdd = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            using (SqlConnection conss = new SqlConnection(constrdd))
            {
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM menu_details WHERE restaurant_id =" + syalalali))
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

        private DataTable GetDotu()
        {
            SqlCommand cmddw = new SqlCommand();
            SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            SqlDataAdapter sdads = new SqlDataAdapter();
            DataSet dsdde = new DataSet();
            cmddw.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmddw.Connection = conde;
            sdads.SelectCommand = cmddw;
            sdads.Fill(dsdde, "restaurant_details");
            String syalalali = dsdde.Tables[0].Rows[0]["id"].ToString();

            String constrdd = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            using (SqlConnection conss = new SqlConnection(constrdd))
            {
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM Feedback WHERE restaurant_id =" + syalalali))
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

        public void showdata2()
        {
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");

            StringBuilder html = new StringBuilder();
            html.Append("<a class=\"manage\" href=\"RestaurantProfile.aspx?Id=" + ds.Tables[0].Rows[0]["id"] + "\">Edit Details</a>");
            PlaceHolder5.Controls.Add(new Literal { Text = html.ToString() });



        }

        public void feedbackshow()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDotu();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                   
                    string name = row["name"].ToString();
                    string email = row["email"].ToString();
                    string message = row["message"].ToString();


                    html.Append("<div class=\"feedback\">");
                    html.Append("<p class=\"rPara\">" + name + "</p>");
                    html.Append("<p class=\"rPara2\">" + email + "</p>");
                    html.Append("<p class=\"rPara3\">" + message + "</p>");
                    html.Append("</div>");
                }

                PlaceHolder4.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        public void menushow()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM menu_details", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                con.Close();
                string restaurant_id = ds.Tables[0].Rows[0]["restaurant_id"].ToString();

                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<div class=\"box\">");
                   
                    html.Append("<img src=\"upload/");
                    html.Append(row["menu_image"]);
                    html.Append("\" width=\"100%\"");
                    html.Append("\" border-radius=\"5px\"");
                    html.Append("\" height=\"130px\">");
                    html.Append("<p class=\"Rname\">" + row["menu_name"] + "</p>");
                    html.Append("<p class=\"Rcaption\">" + "Price: " + row["menu_price"] + "RM" + "</p>");
                    html.Append("<a onClick=\"return confirm('Are you sure want to delete this menu?')\" class=\"delete1\" href=\"deletemenu.aspx?Id=" + row["MenuId"] + "\">Delete</a>");
                    html.Append("</div>");
                }

                PlaceHolder3.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

    }
}