<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OwnerAfterLogin.aspx.cs" Inherits="Assignment.OwnerAfterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="OwnerAfterLogin.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
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

        .box
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 280px;
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
        .box a:hover, .feedback a:hover
        {
            color:black;
        }
        .feedback
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 200px;
            border-radius:5px;            
            box-shadow: 0 16px 20px 0 rgba(0, 0, 0, 0.2);
            background-color:#eee;
            margin-left: 30px;
            margin-right:20px;
            overflow:hidden;
        }
        .feedback .rPara, .rPara2, .rPara3
        {
            font-size:15px;
            margin:10px;
        }
        .feedback .rPara
        {
            font-weight:bold;
        }
        .delete1
        {
            color:#FFFFFF;
            background-color:red;
            padding:8px 16px;
            margin:10px;
            border-radius:5px;
            border:none;
            font-size:15px;
        }
        .delete1:hover
        {
            color:#FFFFFF;
        }
        .container
        {
            width:100%;
            display:block;
            min-height:420px;
            border-top:ridge;
        }
        h1
        {
            text-align:center;
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
                        <div class="sub-div">
                            <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
                            <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">View Placed Order</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton2" runat="server" OnCLick="LinkButton2_Click">Logout</asp:LinkButton>
                        </div>
                </div>
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
                </div>
            </div>
            <div class="container">
                <h1>Menu</h1>
                <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                <br />
            </div>
            <div class="container">
                <br />
                <h1>Feedback</h1>
                <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </form>
</body>
</html>
