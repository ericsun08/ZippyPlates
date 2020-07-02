<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantAdmin.aspx.cs" Inherits="Assignment.Restaurant_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZippyPlates Admin</title>
     <link href="AdminSite.css" rel="stylesheet"/>
      <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <style>
         .box
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 270px;
            border-radius:5px;            
            box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
            margin-left: 30px;
            margin-right:20px;
            overflow:hidden;
        }
        .box .Rname, .Rcaption
        {
            padding:5px;
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
         a:link.logout
        {
            color:black;
            font-size:20px;
        }
        a:link.logout:hover
        {
            color:black;
        }
        a:link.edit1, a:visited.edit1, a:link.delete1, a:visited.delete1
        {
            font-size:10pt;
            color:white;
            padding:5px 10px;
            text-align:center;
            text-decoration:none;
            display:inline-block;
            border-radius:5px;
        }
        a:hover.edit1, a:active.edit1{
            background-color:green;
        }
        a.edit1 {
            background-color: #00a46e;
            bottom: -15px;
            position: relative;
            margin-left:10px;
        }
        a:hover.delete1, a:active.delete1{
            background-color:red;
        }
        a.delete1 {
            background-color: #ff6f6f;
            bottom:-15px;
            margin-left:10px;
            position:relative;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <nav>
                <div class="wrapper">
            <label class="logo">&nbsp;<a href="AdminMenu.aspx">ZippyPlates Admin</a></label>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" placeholder="Search restaurant name " autocomplete="off"></asp:TextBox>
                    <div class="login">
                        <a class="logout" href="Webform1.aspx">LOGOUT</a>
                    </div>
                </div>

           
            
        </nav>
        <div class="data">
            <div class="wrapper">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </div>
            </div>
        <div class="footer">
            <div class="wrapper">
                    <label class="logo">ZippyPlates</label>
             
                <div class="item4">
                    <p>Support</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="AboutUs.aspx">About Us</a></li>
                        <li><a href="#">Help Centre</a></li>
                        <li><a href="#">Contact Us</a></li>
                        
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
        
            
       
    </form>
  
</body>
</html>
