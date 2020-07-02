<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Assignment.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZippyPlates</title>
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="SignUp.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <nav>
            <div class="wrapper">
                <a class="logo" href="WebForm1.aspx">ZippyPlates</a>
            </div>
        </nav>
            <div class="container">
                    <div class="form">
                        <h3>Create Account</h3>
                        <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="First Name is Required" ControlToValidate="first_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="last_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="first_name" type="string" autocomplete="off" placeholder="First Name" runat="server"></asp:TextBox>
                        <asp:TextBox ID="last_name" type="string" autocomplete="off" placeholder="Last Name" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RF8" runat="server" ErrorMessage="Gender is Required" ControlToValidate="gender" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="gender" runat="server">
                            <asp:ListItem Selected="True" Enabled="False"> Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="RF3" runat="server" ErrorMessage="Email is Required" ControlToValidate="email" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="email" autocomplete="off" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>
                        <br />
                        <asp:Label ID="emailwarning" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:RequiredFieldValidator ID="RF4" runat="server" ErrorMessage="Mobile Number is Required" ControlToValidate="mobile_number" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CV2" runat="server" ErrorMessage="Must be Number" ControlToValidate="mobile_number" Operator="DataTypeCheck" Type="Integer" ForeColor="#FF3300"></asp:CompareValidator>
                        <br />
                        <asp:TextBox ID="mobile_number" type="integer" autocomplete="off" placeholder="Mobile Number" runat="server" TextMode="Phone"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RF7" runat="server" ErrorMessage="Home Address is Required" ControlToValidate="homeaddress" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="homeaddress" runat="server" autocomplete="off" TextMode="SingleLine" placeholder="Home Address"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RF5" runat="server" ErrorMessage="Password is Required" ControlToValidate="password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RF6" runat="server" ErrorMessage="Confirmation is Required" ControlToValidate="confirmation" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="password" type="password" autocomplete="off" placeholder="Password" runat="server"></asp:TextBox>
                        <asp:TextBox ID="confirmation" type="password" autocomplete="off" placeholder="Password Confirmation" runat="server"></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="REV1" runat="server" ErrorMessage="at least 8 characters, (A-Z, 1-9, !@#$%^) " ControlToValidate="password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                        <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Password does not match!" ForeColor="#FF3300" ControlToCompare="password" ControlToValidate="confirmation"></asp:CompareValidator>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Sign up" OnClick="Button1_Click" />
                            <div class="signin">
                            <a href="SignIn.aspx">You have an account? <span style="color:#6DD47E">Login</span></a>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [customer_details]"></asp:SqlDataSource>
                        </div>
                    </div>
            </div>
    </form>
</body>
</html>
