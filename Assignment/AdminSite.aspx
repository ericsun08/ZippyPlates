<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSite.aspx.cs" Inherits="Assignment.AdminSite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zippy Plates Admin</title>
    <link href="AdminSite.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    
    <style> 
        .box
        {
            float:left;
            margin:10px;
            padding:10px;
            width:200px;
            height:300px;
            background-color:antiquewhite;
            border-radius:10px;
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
        .data
        {
            width:100%;
            min-height:700px;
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
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <nav>
                <div class="wrapper">
            <label class="logo">&nbsp;<a href="AdminMenu.aspx">ZippyPlates Admin</a></label>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" placeholder="Search customer name" autocomplete="off"></asp:TextBox>
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
