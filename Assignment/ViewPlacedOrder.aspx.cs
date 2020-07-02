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
    public partial class ViewPlacedOrder : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            cust();
            showdata();
            
            
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
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM ordertable WHERE restaurant_id =" + syalalali))
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
                using (SqlCommand cmdaa = new SqlCommand("SELECT * FROM ordertable WHERE id =" + syalalali))
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

        public void cust()
        {
            if (!this.IsPostBack)
            {
                String labl = "tot";

                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();
                String testi = null;


                foreach (DataRow row in dt.Rows)
                {
                    string cartid = row["Id"].ToString();
                    string customerid = row["customer_id"].ToString();
                    string menid = row["menu_id"].ToString();
                    string restid = row["restaurant_id"].ToString();
                    string menuprice = row["menu_price"].ToString();
                    string menuname = row["menu_name"].ToString();
                    string restname = row["restaurant_name"].ToString();


                    if (testi == null)
                    {
                        int tulul = Convert.ToInt32(customerid);
                        SqlCommand cmddw = new SqlCommand();
                        SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        SqlDataAdapter sdads = new SqlDataAdapter();
                        DataSet dsdde = new DataSet();
                        cmddw.CommandText = "SELECT * FROM customer_details WHERE id='" + tulul + "'";
                        cmddw.Connection = conde;
                        sdads.SelectCommand = cmddw;
                        sdads.Fill(dsdde, "customer_details");
                        String first_name = dsdde.Tables[0].Rows[0]["first_name"].ToString();
                        String last_name = dsdde.Tables[0].Rows[0]["last_name"].ToString();
                        String mobile_number = dsdde.Tables[0].Rows[0]["mobile_number"].ToString();
                        String homeaddress = dsdde.Tables[0].Rows[0]["homeaddress"].ToString();

                        html.Append("<div class=\"menu\">");
                        html.Append("<div class=\"menu2\">");
                        html.Append("<p class=\"rPara1\">" + first_name + last_name + "</p>");
                        html.Append("<p class=\"rPara2\">" + mobile_number + "</p>");
                        html.Append("<p class=\"rPara3\">" + homeaddress + "</p>");
                        
                        html.Append("</div>");
                        /*
                        html.Append("<div class=\"done\">");
                        html.Append("<a class=\"delete1\" href=\"deletecart.aspx>Done</a>");
                        html.Append("</div>");
                        */
                        html.Append("<div class=\"menu3\">");
                        html.Append("<div class=\"list\">");
                        html.Append("<p class=\"mPara2\">" + menuname + "</p>");
                        html.Append("<p class=\"mPara3\">" + menuprice + "</p>");
                        html.Append("</div>");
                        testi = customerid;
                    }

                    else if (testi != customerid)
                    {
                        int tulul = Convert.ToInt32(customerid);
                        SqlCommand cmddw = new SqlCommand();
                        SqlConnection conde = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        SqlDataAdapter sdads = new SqlDataAdapter();
                        DataSet dsdde = new DataSet();
                        cmddw.CommandText = "SELECT * FROM customer_details WHERE id='" + tulul + "'";
                        cmddw.Connection = conde;
                        sdads.SelectCommand = cmddw;
                        sdads.Fill(dsdde, "customer_details");
                        String first_name = dsdde.Tables[0].Rows[0]["first_name"].ToString();
                        String last_name = dsdde.Tables[0].Rows[0]["last_name"].ToString();
                        String mobile_number = dsdde.Tables[0].Rows[0]["mobile_number"].ToString();
                        String homeaddress = dsdde.Tables[0].Rows[0]["homeaddress"].ToString();
                        
                        html.Append("</div>");
                        html.Append("</div>");

                        html.Append("<div class=\"menu\">");
                        html.Append("<div class=\"menu2\">");
                        html.Append("<p class=\"rPara1\">" + first_name + last_name + "</p>");
                        html.Append("<p class=\"rPara2\">" + mobile_number + "</p>");
                        html.Append("<p class=\"rPara3\">" + homeaddress + "</p>");
                        html.Append("</div>");
                        /*
                        html.Append("<div class=\"done\">");
                        html.Append("<a class=\"delete1\" href=\"deletecart.aspx>Done</a>");
                        html.Append("</div>");
                        */
                        html.Append("<div class=\"menu3\">");
                        html.Append("<div class=\"list\">");
                        html.Append("<p class=\"mPara2\">" + menuname + "</p>");
                        html.Append("<p class=\"mPara3\">" + menuprice + "</p>");
                        html.Append("</div>");
                        

                        testi = customerid;
                    }
                    else
                    {
                        html.Append("<div class=\"list\">");
                        html.Append("<p class=\"mPara2\">" + menuname + "</p>");
                        html.Append("<p class=\"mPara3\">" + menuprice + "</p>");
                        html.Append("</div>");

                        testi = customerid;
                    }
                }
                html.Append("</div>");
                html.Append("</div>");
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        public void showdata()
        {
            cmd.CommandText = "SELECT * FROM restaurant_details WHERE email_address='" + Session["userr"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "restaurant_details");
            first_name.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPlacedOrder.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["userr"] = null;
            Response.Redirect("AdminSignIn.aspx");
        }

        

        public void menu()
        {
            if (!this.IsPostBack)
            {
                String labl = "tot";

                DataTable dt = this.GetDoto();
                StringBuilder html = new StringBuilder();
                String testi = null;


                foreach (DataRow row in dt.Rows)
                {
                    string cartid = row["Id"].ToString();
                    string customerid = row["customer_id"].ToString();
                    string menid = row["menu_id"].ToString();
                    string restid = row["restaurant_id"].ToString();
                    string menuprice = row["menu_price"].ToString();
                    string menuname = row["menu_name"].ToString();
                    string restname = row["restaurant_name"].ToString();


                    if (testi == null)
                    {
                        

                        html.Append("<div class=\"menu\">");

                        html.Append("<div class=\"testing\">");
                        html.Append("<p class=\"rPara1\">" + menuname + "</p>");
                        html.Append("<p class=\"rPara2\">" + menuprice + "</p>");
                        html.Append("</div>");

                        testi = customerid;
                    }

                    else if (testi != customerid)
                    {
                        html.Append("</div>");

                        html.Append("<div class=\"menu\">");
                        html.Append("<div class=\"testing\">");
                        html.Append("<p class=\"rPara1\">" + menuname + "</p>");
                        html.Append("<p class=\"rPara2\">" + menuprice + "</p>");
                        html.Append("</div>");

                        testi = customerid;
                    }
                    else
                    {
                        html.Append("<div class=\"testing\">");
                        html.Append("<p class=\"rPara1\">" + menuname + "</p>");
                        html.Append("<p class=\"rPara2\">" + menuprice + "</p>");
                        html.Append("</div>");

                        testi = customerid;
                    }
                }
                PlaceHolder3.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
    }
}