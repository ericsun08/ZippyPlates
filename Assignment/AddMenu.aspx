<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMenu.aspx.cs" Inherits="Assignment.AddMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AddMenu.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
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
         <div class="maincontainer">
            <div class="container">
                <div class="form">
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <h1>Insert Menu</h1>
                    <asp:RequiredFieldValidator ID="R1" runat="server" ErrorMessage="Menu Name is Required" ControlToValidate="menu_name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="menu_name" runat="server"  placeholder="Menu Name" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="R2" runat="server" ErrorMessage="Price is Required" ControlToValidate="menu_price" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="menu_price" runat="server"   placeholder="Menu Price"></asp:TextBox>
                    <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Must be Number" ForeColor="#FF3300" ControlToValidate="menu_price" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="R3" runat="server" ErrorMessage="Image is Required" ControlToValidate="menu_image" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:FileUpload ID="menu_image" runat="server" />
                    <asp:Button ID="Button1" runat="server" Text="Save Changes" OnClick="Button1_Click" />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [menu_details]"></asp:SqlDataSource>
                </div>
                </div>
        </div>
    </form>
</body>
</html>
