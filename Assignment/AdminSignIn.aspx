<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSignIn.aspx.cs" Inherits="Assignment.AdminSignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AdminSignIn.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
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
                    <h1>Sign In</h1>
                    <p>To manage you restaurant</p>
                    <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="Please insert with your email!" ControlToValidate="TextBox1" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TextBox1" type="email" autocomplete="off" placeholder="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Please insert your Password!" ControlToValidate="TextBox2" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TextBox2" type="password" autocomplete="off" placeholder="Password" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click"/>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [restaurant_details]"></asp:SqlDataSource>
                </div>
                <div class="signup">
                   <a href="RestaurantForm.aspx">List Your Restaurant Now! <span style="color:#6DD47E">Join With Us</span></a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
