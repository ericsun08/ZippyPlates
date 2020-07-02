<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPlacedOrder.aspx.cs" Inherits="Assignment.ViewPlacedOrder" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ViewPlacedOrder.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <style>
         #Button1
        {
            border:none;
            width:100%;
            display: block;
            padding: 12px 16px;
            text-decoration: none;
            text-align:left;
            background-color:#FFFFFF;
        }
        #Button1:hover
        {
            background-color: #6DD47E;
            color: black;
        }
         .insert
        {
            display: block;
            padding: 12px 16px;
            text-decoration: none;
        }
        .insert:hover
        {
            background-color: #6DD47E;
            color: black;
        }
        .menu
        {
            display:inline-block;
            height:350px;
            width:450px;
            margin:20px;
            border-radius:10px;
            box-shadow: 0 12px 22px 0 rgba(0, 0, 0, 0.2);
        }
        .menu2
        {
            display:inline-block;
            height:90px;
            margin:20px;
            color:black;
            font-size:15px;
        }
        .menu3
        {
            display:block;
            height:200px;
            background-color:#FFFFFF;
            color:black;
            overflow:scroll;
        }
         .manage
        {
            display: block;
            padding: 12px 16px;
            text-decoration: none;
        }
        .manage:hover
        {
            background-color: #6DD47E;
            color: black;
        }
        .list
        {
            display:block;
            height:60px;
            margin:10px;
            background-color:gray;
            color:black;
        }
        .rPara1, .rPara2, .rPara3
        {
            font-size:20px;
            margin:10px;
        }
        .mPara2, .mPara3
        {
            display:inline-block;
            font-size:20px;
            margin:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <nav>
            <div class="wrapper">
                <label class="logo"><a href="OwnerAfterLogin.aspx">ZippyPlates</a></label>
                <div class="name">
                    <asp:Label ID="first_name" runat="server" Text="Label"></asp:Label>
                        
                </div>
            </div>
        </nav>
        <div class="wrapper">
            <h1>Placed Order</h1>
            <div class="placed">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
            <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>