<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfterLogin.aspx.cs" Inherits="Assignment.AfterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <link href="AfterLogin.css" rel="stylesheet" />
    <title></title>
    <style>
        .box 
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 240px;
            border-radius: 5px;
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
        a:link.edit, a:visited.edit {
            border-radius: 10px;
            border: 1px solid #6DD47E;
            background: #6DD47E;
            color:#ffffff;
            font-size:9px;
            font-weight: bold;
            padding: 12px 20px;
            letter-spacing: 1px;
            text-transform:uppercase;
            transition: transform 80ms ease-in;
            margin-top: 20px;
            float:left;
        }
        a:link.delete, a:visited.delete
        {
            border-radius: 10px;
            border: 1px solid red;
            background: red;
            color:#ffffff;
            font-size:9px;
            font-weight: bold;
            padding: 12px 20px;
            letter-spacing: 1px;
            text-transform:uppercase;
            transition: transform 80ms ease-in;
            margin-top: 20px;
            float:right;
        }
        a:link.delete1, a:visited.delete1
        {
            border-radius: 10px;
            border: 1px solid red;
            background: red;
            color:#ffffff;
            font-size:9px;
            font-weight: bold;
            padding: 8px 16px;
            letter-spacing: 1px;
            text-transform:uppercase;
            transition: transform 80ms ease-in;
            margin:8px;
            margin-right:30px;
            display:inline-block;
            float:right;
        }
        .menu .rPara, .rPara2
        {
            margin: 10px;
            display:inline-block;
        }
        .menu .rPara
        {
            font-size: 20px;
        }
         .menu .rPara2
         {
             margin-left:20px;
             font-size:15px;
         }
        .menu{
            
            height: 45px;
            margin:10px;
            background-color:#eee;
            border-radius:5px;
            border:none;
            display:block;
        }
        .menulist
        {
            height:80%;
            overflow:scroll;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        
            <div  id="myProfile" class="profile">
                <div class="profiletext">
                        <h5>My Profile</h5>
                        <a href="javascript:void(0)" class="closebttn" onclick="pcloseNav()">&times;</a>
                </div>
                    <div class="subprofile">
                        <div class="profpict">
                            <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                        </div>
                        <div class="fullName">
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </div>
                        <br />
                        <br />
                        Email: <br />
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        Mobile Number: <br />
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        <br />
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                    </div>
            </div>
 
            <div  id="mySidenav" class="sidenav">
                <div class="basket">
                        <h5>Basket</h5>
                        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
                </div>
                <div class="menulist">
                     <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
                </div>
                <div class="coBtn">
                    <asp:Label ID="Label6" runat="server" Text="Total: "></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text="">RM</asp:Label>  
                    <br />
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Check Out</asp:LinkButton>
                    </div>
            </div>
        <nav>
            <div class="wrapper">
            <label class="logo"><a href="AfterLogin.aspx">ZippyPlates</a></label>
            <div class="name">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <div class="sub-profile">
                        <span id="LinkButton1" onclick="popenNav()">My Profile</span>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Logout</asp:LinkButton>
                    </div>
            </div>
            <span class="btn3"><i class="fas fa-shopping-bag" onclick="openNav()"></i></span>
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
                        <img src="img/chinese.jpg" style="width:100%;height:100%;border-radius:10px;" />
                        <asp:Button class="caption" ID="Button2" runat="server" Text="Chinese Food" OnClick="Button2_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/-fast-food-composition_23-2147695684.jpg" style="width:100%;height:100%;border-radius:10px;" />
                        <asp:Button class="caption" ID="Button3" runat="server" Text="Fast Food" OnClick="Button3_Click"  />
                    </div>
                    <div class="item">
                        <img src="img/dessert.jpg" style="width: 100%; height: 100%; border-radius: 10px;"/>
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
                <asp:HiddenField ID="HiddenField1" runat="server" />
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
                        <li><a href="ContactUs.aspx">Contact Us</a></li>
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
                <div class="copyright">
                    <p style="color:#eee;">© ZippyPlates 2020</p>
                    <br />
                    <p><a href="#">Terms & Condition • Privacy Policy</a></p>
                </div>
            </div>
        </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [customer_details]"></asp:SqlDataSource>
        </div>

    </form>
    <script src="slide.js"></script>
    <script src="cart.js"></script>
    <script src="profile.js"></script>
</body>
</html>
