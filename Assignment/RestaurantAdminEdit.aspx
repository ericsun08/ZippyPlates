<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantAdminEdit.aspx.cs" Inherits="Assignment.RestaurantAdminEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZippyClass Admin</title>
    
    <link href="AdminSite.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 8px;
        }
        .lbl, #RF1, #RF2, #RF3, #RF4
        {
            margin-left:50px;
        }
         #RF1, #RF2, #RF3, #RF4
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
            height:550px;
            width:500px;
            margin:20px auto;
        }
          #restaurant_name, #city, #restaurantaddress, #category {
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
                margin-left: 130px;
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
            <label class="logo"> <h3> Edit Restaurant </h3></label>
             <asp:HiddenField ID="HiddenField1" runat="server" />
            
            <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="Restaurant name is Required" ControlToValidate="restaurant_name" ForeColor="Red"></asp:RequiredFieldValidator>
            <label class="lbl">Restaurant Name:</label>
            <asp:TextBox ID="restaurant_name" runat="server" autocomplete="off"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="Category is Required" ForeColor="#FF3300" ControlToValidate="category"></asp:RequiredFieldValidator>
            <label class="lbl">Category:</label>
             <asp:DropDownList ID="category" runat="server" CssClass="auto-style1"> 
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Chinese</asp:ListItem>
                            <asp:ListItem>Dessert</asp:ListItem>
                            <asp:ListItem>Fast Food</asp:ListItem>
                            <asp:ListItem>Healthy</asp:ListItem>
                            <asp:ListItem>Malay</asp:ListItem>
                            <asp:ListItem>Western</asp:ListItem>
                        </asp:DropDownList>
                
            <asp:RequiredFieldValidator ID="RF3" runat="server" ErrorMessage="City is Required" ForeColor="#FF3300" ControlToValidate="city"></asp:RequiredFieldValidator>
            <label class="lbl">City:</label>
            <asp:DropDownList ID="city" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Kuala Lumpur</asp:ListItem>
                            <asp:ListItem>Malacca</asp:ListItem>
                            <asp:ListItem>Ipoh</asp:ListItem>
                            <asp:ListItem>Damansara</asp:ListItem>
                            <asp:ListItem>Penang</asp:ListItem>
                            <asp:ListItem>Genting Highland</asp:ListItem>
                            <asp:ListItem>Cameron Highland</asp:ListItem>
                        </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RF4" runat="server" ErrorMessage="Address is Required" ControlToValidate="restaurantaddress" ForeColor="Red"></asp:RequiredFieldValidator>
           <label class="lbl">Address:</label>
            <asp:TextBox ID="restaurantaddress" runat="server" ></asp:TextBox> 
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                </div>
                </div>
     


        </div>
    </form>
</body>
</html>
