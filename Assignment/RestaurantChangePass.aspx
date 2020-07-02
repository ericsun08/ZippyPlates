<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantChangePass.aspx.cs" Inherits="Assignment.RestaurantChangePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="RestaurantChangePass.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <style>
        a:link.profile, a:visited.profile
        {
            color:black;
        }
        a.profile:hover
        {
            color:#6DD47E;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
                <a class="logo" href="OwnerAfterLogin.aspx">ZippyPlates</a>
            </div>
        </nav>
        <div class="maincontainer">
            <div class="container">
                <div class="form">
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <h1>Password</h1>
                    <asp:RequiredFieldValidator ID="R1" runat="server" ErrorMessage="Current Password is Required" ControlToValidate="current_password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="current_password" runat="server" TextMode="Password" placeholder="Current Password" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="R2" runat="server" ErrorMessage="New Password is Required" ControlToValidate="new_password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="new_password" runat="server"  TextMode="Password" placeholder="New Password"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="REV1" runat="server" ErrorMessage="at least 8 characters, (A-Z, 1-9, !@#$%^) " ControlToValidate="new_password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="R3" runat="server" ErrorMessage="Confirmation is Required" ControlToValidate="confirmation" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="confirmation" runat="server" TextMode="Password" placeholder="Password Confirmation"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Save Changes" OnClick="Button1_Click" />
                </div>
                <div class="profile">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </div>
        </div>
        </div>
    </form>
</body>
</html>
