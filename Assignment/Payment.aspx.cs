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
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cart();
            restoran();
            customer();
        }

        private DataTable GetDiti()
        {
            SqlCommand cmddw = new SqlCommand();
            SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataAdapter sdads = new SqlDataAdapter();
            DataSet dsdde = new DataSet();
            cmddw.CommandText = "SELECT * FROM cart_table WHERE id='" + Session["cart"] + "'";
            cmddw.Connection = conde;
            sdads.SelectCommand = cmddw;
            sdads.Fill(dsdde, "cart_table");
            String syalalali = dsdde.Tables[0].Rows[0]["restaurant_id"].ToString();

            String constrdd = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
            using (SqlConnection conss = new SqlConnection(constrdd))
            {
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM restaurant_details WHERE id =" + syalalali))
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

        private DataTable GetDutu()
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
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM customer_details WHERE Id =" + syalalali))
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

                foreach (DataRow row in dt.Rows)
                {
                    string cartid = row["Id"].ToString();
                    string customerid = row["customer_id"].ToString();
                    string menid = row["menu_id"].ToString();
                    string restid = row["restaurant_id"].ToString();
                    string menuprice = row["menu_price"].ToString();
                    string menuname = row["menu_name"].ToString();
                    string restname = row["restaurant_name"].ToString();
                    

                    int murah = Convert.ToInt32(menuprice);
                    total = total + murah;

                    html.Append("<div class=\"menu\">");
                    html.Append("<p class=\"rPara\">" + menuname + "</p>");
                    html.Append("<p class=\"rPara2\">" + "RM" + " " + menuprice + "</p>");
                    html.Append("</div>");
                }
                String totals = Convert.ToString(total);
                Label1.Text = "RM" + " " + totals;
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        public void restoran()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDiti();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {

                    html.Append("<div class=\"image\">");
                    html.Append("<img src=\"upload/");
                    html.Append(row["img_upload"]);
                    html.Append("\" margin=\"10px\"");
                    html.Append("\" height=\"230px\"");
                    html.Append("\" width=\"100%\">");
                    html.Append("</div>");
                }
                PlaceHolder3.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        public void customer()
        {
            if (!this.IsPostBack)
            {
                DataTable dt = this.GetDutu();
                StringBuilder html = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {

                    string adres = row["homeaddress"].ToString();
                    Label2.Text = adres;
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("updatedelete.aspx");
        }

    }
}