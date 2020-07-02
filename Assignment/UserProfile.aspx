<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Assignment.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="UserProfile.css" rel="stylesheet" />
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
        #RF1, #RF2, #RF3, #RF4, #RF5, #CV1
        {
            font-size: 12px;
            margin-left:30px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
                <label class="logo"><a href="AfterLogin.aspx">ZippyPlates</a></label>
            </div>
        </nav>
        <div class="maincontainer">
        <div class="container">
            <div class="form">
                <h1>My Profile</h1>
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <asp:HiddenField ID="HiddenField2" runat="server" />
                <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="First Name is Required" ControlToValidate="first_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="first_name" type="string" autocomplete="off" placeholder="First Name" runat="server"></asp:TextBox>       
                <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="last_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="last_name" type="string" autocomplete="off" placeholder="Last Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RF3" runat="server" ErrorMessage="Gender is Required" ControlToValidate="gender" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="gender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Must be Number" ControlToValidate="mobile_number" ForeColor="#FF3300" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RF4" runat="server" ErrorMessage="Mobile Number is Required" ControlToValidate="mobile_number" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="mobile_number" type="integer" autocomplete="off" placeholder="Mobile Number" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RF5" runat="server" ErrorMessage="Address is Required" ControlToValidate="homeaddress" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:TextBox ID="homeaddress" runat="server" placeholder="Home Address"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Save Changes" OnClick="Button1_Click" />
            </div>
            <div class="password">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
