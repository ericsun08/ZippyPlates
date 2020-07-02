<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEdit.aspx.cs" Inherits="Assignment.AdminEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZippyPlates Admin</title>
    <link href="AdminSite.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 491px;
            width: 100%;
        }
        .lbl,  #RF1, #RF2, #RF3, #RF4, #RF5, #RF6, #CV1
        {
            margin-left:100px;
        }
        #RF1, #RF2, #RF3, #RF4, #RF5, #RF6, #CV1
         {
              font-size:12px;
         }
        .form 
        {
            background: #fff;
            display: flex;
            flex-direction: column;
            border-radius: 10px;
            box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);
            height:750px;
            width:600px;
            margin:20px auto;
        }
          #first_name, #last_name, #mobile_number, #email, #homeaddress, #gender {
            background: #eee;
            border: none;
            padding: 12px 15px;
            margin: 1px auto;
            width: 300px;
         }
          #Button1 {
                border-radius: 20px;
                border: 1px solid #6DD47E;
                background: #6DD47E;
                color: #fff;
                font-size: 12px;
                font-weight: bold;
                padding: 15px;
                letter-spacing: 1px;
                text-transform: uppercase;
                transition: transform 80ms ease-in;
                width: 130px;
                margin-top: 10px;
                margin-left: 180px;
                display: inline-block;
          }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <nav>
                <div class="wrapper">
            <label class="logo">&nbsp;<a href="AdminMenu.aspx">ZippyPlates Admin</a></label>
                </div>
             </nav>
        <div>
            <div class ="wrapper">
            
            <div class="form">
            <label class="logo"><h3>Edit User</h3></label>
            <asp:HiddenField ID="HiddenField1" runat="server" />

            <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="First Name is Required" ControlToValidate="first_name" ForeColor="Red"></asp:RequiredFieldValidator>
            <label class="lbl">First Name:</label>
            <asp:TextBox ID="first_name" runat="server" AutoComplete="off"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="last_name" ForeColor="Red"></asp:RequiredFieldValidator>
            <label class="lbl">Last Name:</label>
            <asp:TextBox ID="last_name" runat="server" AutoComplete="off"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RF3" runat="server" ErrorMessage="Mobile Number is Required" ControlToValidate="mobile_number" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Must be Number" ForeColor="#FF3300" ControlToValidate="mobile_number" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            <label class="lbl">Mobile Number:</label>
            <asp:TextBox ID="mobile_number" runat="server" AutoComplete="off"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RF4" runat="server" ErrorMessage="Email is Required" ControlToValidate="email" ForeColor="Red"></asp:RequiredFieldValidator>
            <label class="lbl">Email Address:</label>
            <asp:TextBox ID="email" runat="server" TextMode="Email" AutoComplete="off"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RF5" runat="server" ErrorMessage="Address is Required" ControlToValidate="homeaddress" ForeColor="Red"></asp:RequiredFieldValidator>
            <label class="lbl">Home Address:</label>
            <asp:TextBox ID="homeaddress" runat="server" AutoComplete="off"></asp:TextBox>

           <asp:RequiredFieldValidator ID="RF6" runat="server" ErrorMessage="Gender is Required" ForeColor="Red" ControlToValidate="Gender"></asp:RequiredFieldValidator>
           <label class="lbl"> Gender:</label>
            <asp:RadioButtonList ID="gender" runat="server"> 
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
            </div>
            </div>
            </div>
    </form>
</body>
</html>
