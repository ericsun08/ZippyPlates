<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <title>ZippyPlates</title>
    <style>
        .box 
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 240px;
            border-radius:5px;            
            box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
            margin-left: 30px;
            margin-right:20px;
            overflow:hidden;
        }
        .box .Rname, .Rcaption
        {
            padding:8px;
        }
        .box h4
        {
            font-weight:bold;
        }
        .box p
        {
            font-size:15px;
        }
        .box a:hover
        {
            color:black;
        }
        a:link.admin:hover, a:visited.admin:hover
        {
            color:#6DD47E;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
            <label class="logo"><a href="WebForm1.aspx">ZippyPlates</a></label>
            <div class="login">
                <span class="btn2">LOGIN</span>
                <div class="sub-login">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">as Customer</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">as Owner</asp:LinkButton>
                </div>
            </div>
            </div>
        </nav>
        <div class="wrapper">
            <div id="content1">
                <div class="order">
                    <asp:TextBox ID="TextBox1" autocomplete="off" placeholder="Search for a dish or a restaurant" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                </div>
                </div>
            <div class="slideshow">
                <div class="slide">
                    <div class="item">
                        <asp:HiddenField ID="HiddenField1" runat="server" value="Chinese"/>
                        <img src="img/chinese.jpg" style="width:100%;height:100%;border-radius:10px;" />
                        <asp:Button class="caption" ID="Button2" runat="server" Text="Chinese Food" OnClick="Button2_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/-fast-food-composition_23-2147695684.jpg" style="width:100%;height:100%;border-radius:10px;" />
                        <asp:Button class="caption" ID="Button3" runat="server" Text="Fast Food" OnClick="Button3_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/dessert.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                        <asp:Button class="caption" ID="Button4" runat="server" Text="Dessert" OnClick="Button4_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/Healthy-delivery-featured.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                        <asp:Button class="caption" ID="Button5" runat="server" Text="Healthy" OnClick="Button5_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/western-grilled-chicken-food-delivery-malaysia.jpg" style="width: 100%; height: 100%; border-radius: 10px;"/>
                         <asp:Button class="caption" ID="Button6" runat="server" Text="Western" OnClick="Button6_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/malay.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                        <asp:Button class="caption" ID="Button7" runat="server" Text="Malay" OnClick="Button7_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/boba.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                         <asp:Button class="caption" ID="Button8" runat="server" Text="Beverages" OnClick="Button8_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/Japan.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                         <asp:Button class="caption" ID="Button9" runat="server" Text="Japanese" OnClick="Button9_Click"  />
                   </div>
                     <div class="item">
                         <img src="img/korean.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                        <asp:Button class="caption" ID="Button10" runat="server" Text="Korean" OnClick="Button10_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/Indonesian.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                         <asp:Button class="caption" ID="Button11" runat="server" Text="Indonesian" OnClick="Button11_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/Chicken-Shawarma-Final-1.jpg" style="width:100%;height:100%;border-radius:10px;" />
                       <asp:Button class="caption" ID="Button12" runat="server" Text="Arabic" OnClick="Button12_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/hainanese-chicken-rice.jpg" style="width:100%;height:100%;border-radius:10px;"/>
                        <asp:Button class="caption" ID="Button13" runat="server" Text="Singaporean" OnClick="Button13_Click"  />
                    </div>
                </div>
                 <div class="controls">
                    <ul>
                        <li></li>
                        <li></li>
                    </ul>
                </div>
                </div>
            
            <div class="content2">
                <h1>Restaurant on ZippyPlates</h1>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" ></asp:Label>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
            <div class="content3">
                <img src="img/undraw_Chef_cu0r.png" style="width:450px;height:350px;float:left;margin:20px;"/>
                <div class="join">
                    <h2>List your restaurant on ZippyPlates</h2>
                    <p>Would you like thousands of new customers to taste your amazing food? So would we!
                    <br />
                    <br />
                    It's simple: we list your menu online, help you process orders, pick them up, and deliver them to customer! 
                    <br />
                    <br />
                    Interested? Let's start our partnership today!</p>
                    <a class="Button2" href="RestaurantForm.aspx">Get Started</a>
                </div>
            </div>
         </div>              
        <div class="footer">
            <div class="wrapper">
                    <label class="logo">ZippyPlates</label>
                <div class="item4">
                    <p>Popular Category</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="#">Chinese</a></li>
                        <li><a href="#">Dessert</a></li>
                        <li><a href="#">Fast Food</a></li>
                        <li><a href="#">Western</a></li>
                    </ul>
                </div>
                <div class="item5">
                    <p>Popular Food</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="#">McDonald</a></li>
                        <li><a href="#">Nasi Lemak</a></li>
                        <li><a href="#">Chicken Rice</a></li>
                        <li><a href="#">Satay</a></li>
                    </ul>
                </div>
                <div class="item6">
                    <p>Support</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="AboutUs.aspx">About Us</a></li>
                        <li><a href="#">Help Centre</a></li>
                        <li><a href="ContactUs.aspx"> Us</a></li>
                        <li><a href="#">FAQs</a></li>
                    </ul>
                </div>
                <div class="item7">
                    <p>Follow Us On</p>
                    <br />
                    <i class="fab fa-facebook-square"></i>
                    <i class="fab fa-twitter-square"></i>
                    <i class="fab fa-instagram"></i>
                </div>
                <a class="admin" href="AdminLogin.aspx" style="color:#FFFFFF;">Admin Login</a>
                <div class="copyright">
                    <p style="color:#eee;"> © ZippyPlates 2020</p> 
                    <br />
                    <p><a href="#">Terms & Condition • Privacy Policy</a></p>
                </div>
            </div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [customer_details]"></asp:SqlDataSource>
    </form>
    <script src="slide.js"></script>
    <script src="cart.js"></script>
</body>
</html>
