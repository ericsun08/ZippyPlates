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
    public partial class DisplayRestaurant2 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (Session["restoran"] == null)
                {
                    string restaurant_id = Request.QueryString["Id"];
                    int intTest = Convert.ToInt32(restaurant_id);
                    Session["restoran"] = restaurant_id;
                }
                showdata2();
                showdata();
            
        }

        public void showdata2()
        {
            if (!IsPostBack)
            {

                string restaurant_id = Session["restoran"].ToString();
               
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSignIn.aspx");
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

                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<div class=\"box\">");
                    html.Append("<a href=\"SignIn.aspx\">");
                    html.Append("<img src=\"upload/");
                    html.Append(row["menu_image"]);
                    html.Append("\" width=\"100%\"");
                    html.Append("\" border-radius=\"5px\"");
                    html.Append("\" height=\"130px\">");
                    html.Append("<p class=\"Rname\">" + row["menu_name"] + "</p>");
                    html.Append("<p class=\"Rcaption\">" + "Price: " + row["menu_price"] + "RM" + "</p>");
                    html.Append("</a>");
                    html.Append("</div>");
                }

                PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        private DataTable GetData()
        {
            string restaurant_id = Session["restoran"].ToString();
            int intTest = Convert.ToInt32(restaurant_id);
            String constr = ConfigurationManager.ConnectionStrings
                ["ConnectionString2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM menu_details WHERE restaurant_id =" + intTest))
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

    }
}