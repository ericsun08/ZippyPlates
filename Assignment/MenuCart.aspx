﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuCart.aspx.cs" Inherits="Assignment.MenuCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="DisplayRestaurant.css" rel="stylesheet" />
    <style>
        .image
        {
        height:200px;
        float:left;
        margin:20px;
        border-radius:5px;
        margin-right:60px;
        overflow:hidden;
        }
        
        .box 
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 250px;
            border-radius:5px;            
            box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
            margin-left: 30px;
            margin-right:20px;
            overflow:hidden;
        }
        .box p.Rname
        {
            font-weight:bold;
            font-size: 20px;
            margin:10px;
        }
        .box p.Rcaption
        {
            font-size:15px;
            margin:10px;
            
        }
        .box a:hover
        {
            color:black;
        }
        .add
        {
            background-color:#6DD47E;
            color:#FFFFFF;
            width:100%;
            height:30px;
            border-radius:5px;
            padding: 8px 15px;
        }
        #Button3
        {
            border-radius:5px;
            border:none;
            background-color:#6DD47E;
            color:#FFFFFF;
            padding:8px 16px;
            font-size:15px;
        }
        #Button3
        {
            cursor:pointer;
        }
        #LinkButton1
        {
            background-color:transparent;
            border:1px solid #6DD47E;
            border-radius:5px;
            font-size:20px;
            color:#6DD47E;
            padding:8px 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <nav>
            <div class="wrapper">
                <label class="logo"><a href="AfterLogin.aspx">ZippyPlates</a></label>
            </div>
        </nav>
        <div class="wrapper">
            <div class="restaurant">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <div class="details">
                    <asp:Label ID="restaurant_name" runat="server" Text="Label"></asp:Label>
                    &nbsp;
                    <asp:Label ID="strip" runat="server" Text="-"></asp:Label>
                    &nbsp;
                    <asp:Label ID="category" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="city" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="restaurant_address" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Explore More!</asp:LinkButton>
                </div>
            </div>
            <div class="menu">
                <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                <div class="details">
                    <div class="menunamedesign">
                        <asp:Label ID="menu_name" runat="server" Text="Label"></asp:Label>
                    </div>
                    <asp:HiddenField ID="HiddenField2" runat="server" />
                    <br />
                    <asp:Label ID="menu_price" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:HiddenField ID="HiddenField3" runat="server" />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Add To Cart" OnClick="Button3_Click" />
                </div>
                
            </div>
        </div>
        <div class="footer">
            <div class="wrapper">
                    <label class="logo">ZippyPlates</label>
                <div class="item6">
                    <p>Support</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="#">About Us</a></li>
                        <li><a href="#">Help Centre</a></li>
                        <li><a href="#">Contact Us</a></li>
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
    </form>
</body>
</html>
