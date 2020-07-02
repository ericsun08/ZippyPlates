<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Assignment.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="AdminSignIn.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <title>Zippy Plates Admin</title>
    <style>
        .maincontainer {
            height: 95vh;
            display: flex;
            background-image: url('img/undraw_product_iteration_kjok.png');
            background-size: auto;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            margin: 0 0 0 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
                <a class="logo" href="WebForm1.aspx">ZippyPlates</a>
            </div>
        </nav>
        <div class="maincontainer">
            <div class="container">
                <div class="form">
                    <h1>Admin Sign In</h1>
                    <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="Please enter your Username!" ControlToValidate="TextBox1" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TextBox1" type="username" autocomplete="off" runat="server" placeholder="username"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Please insert your Password!" ControlToValidate="TextBox2" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TextBox2" type="password" autocomplete="off" placeholder="Password" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click"/>
                </div>
                   
                </div>
        </div>
    </form>
</body>
</html>
