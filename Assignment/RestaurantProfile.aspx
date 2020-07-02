<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantProfile.aspx.cs" Inherits="Assignment.RestaurantProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="RestaurantProfile.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <style>
         a:link.change, a:visited.change
        {
            color:black;
        }
        a.change:hover
        {
            color:#6DD47E;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
                <label class="logo"><a href="OwnerAfterLogin.aspx">ZippyPlates</a></label>
            </div>
        </nav>
        <div class="maincontainer">
        <div class="container">
            <div class="form">
                <h1>My Profile</h1>
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <asp:RequiredFieldValidator ID="RF5" runat="server" ErrorMessage="Restaurant Name is Required!" ForeColor="#FF3300" ControlToValidate="restaurant_name"></asp:RequiredFieldValidator>
                <asp:TextBox ID="restaurant_name" runat="server"></asp:TextBox>
                <asp:DropDownList ID="city" runat="server">
                    <asp:ListItem>Kuala Lumpur</asp:ListItem>
                    <asp:ListItem>Malacca</asp:ListItem>
                    <asp:ListItem>Ipoh</asp:ListItem>
                    <asp:ListItem>Damansara</asp:ListItem>
                    <asp:ListItem>Penang</asp:ListItem>
                    <asp:ListItem>Genting Highland</asp:ListItem>
                    <asp:ListItem>Cameron Highland</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RF6" runat="server" ErrorMessage="Address is Required" ControlToValidate="restaurant_address" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="restaurant_address" runat="server" placeholder="Home Address"></asp:TextBox>
                <asp:DropDownList ID="category" runat="server">
                    <asp:ListItem>Chinese</asp:ListItem>
                    <asp:ListItem>Dessert</asp:ListItem>
                    <asp:ListItem>Fast Food</asp:ListItem>
                    <asp:ListItem>Healthy</asp:ListItem>
                    <asp:ListItem>Malay</asp:ListItem>
                    <asp:ListItem>Western</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="First Name is Required" ControlToValidate="first_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="first_name" type="string" autocomplete="off" placeholder="First Name" runat="server"></asp:TextBox>   
                <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="last_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="last_name" type="string" autocomplete="off" placeholder="Last Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RF4" runat="server" ErrorMessage="Mobile Number is Required" ControlToValidate="mobile_phone" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="mobile_phone" type="integer" autocomplete="off" placeholder="Mobile Number" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Must be Number" ControlToValidate="mobile_phone" ForeColor="#FF3300" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                <asp:Button ID="Button1" runat="server" Text="Save Changes" OnClick="Button1_Click"/>
            </div>
            <div class="password">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
