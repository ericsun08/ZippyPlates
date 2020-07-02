<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantForm.aspx.cs" Inherits="Assignment.RestaurantForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <link href="RestaurantForm.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">

        <nav>
            <div class="wrapper">
                <label class="logo"><a href="WebForm1.aspx">ZippyPlates</a></label>
            </div>
        </nav>
        <div class="wrapper">
                <div class="text">
                    <div class="caption">Partner with us</div>
                </div>
                <div class="walkthrough">
                    <h1>How it works:</h1>
                    <div class="caption1">
                        <img src="img/undraw_my_location_f9pr.png" style="width:100%;height:150px" />
                        <p>Customers enter a delivery address via the app or website and select a restaurant nearby.</p>
                    </div>
                    <div class="caption1">
                        <img src="img/undraw_barbecue_3x93.png" style="width:100%;height:150px"/>
                        <p>Restaurant accepts the order through the tablet we provide, and starts preparing the food for a specific pick up time.</p>
                    </div>
                    <div class="caption1">
                        <img src="img/undraw_on_the_way_ldaq.png" style="width:100%;height:150px"/>
                        <p>Our rider arrives at the right time to collect and delivers the order within 30min after the order was placed.</p>
                    </div>
                    <div class="caption1"> 
                        <img src="img/undraw_wallet_aym5.png" style="width:100%;height:150px"/>
                        <p>zippyplates sends you the proceeds from your orders every month and provides detailed insights on your performance.</p>
                    </div>
                </div>
                <div class="container">
                    <div class="form">
                        <label class="logo">ZippyPlates</label>
                        <br />
                        <div class="caption2">
                        Interested? Fill in the form below to become our partner and 
                        increase your revenue!
                        </div>
                        <br />
                        
                        <asp:RequiredFieldValidator ID="RF1" runat="server" ErrorMessage="Restaurant Name is Required!" ForeColor="#FF3300" ControlToValidate="restaurant_name"></asp:RequiredFieldValidator>
                        <asp:Label ID="L1" runat="server" Text="Restaurant Name:"></asp:Label>
                        <asp:TextBox ID="restaurant_name" autocomplete="off" runat="server"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RF10" runat="server" ErrorMessage="Image is Required" ForeColor="#FF3300" ControlToValidate="img_upload"></asp:RequiredFieldValidator>
                        <asp:Label ID="L11" runat="server" Text="Restaurant Logo:"></asp:Label>
                        <asp:FileUpload ID="img_upload" runat="server" />
                        
                        <asp:RequiredFieldValidator ID="RF2" runat="server" ErrorMessage="City is Required" ForeColor="#FF3300" ControlToValidate="city"></asp:RequiredFieldValidator>
                        <asp:Label ID="L2" runat="server" Text="Select City"></asp:Label>
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
                        
                        <asp:RequiredFieldValidator ID="RF3" runat="server" ErrorMessage="Restaurant Address is Required!" ForeColor="#FF3300" ControlToValidate="restaurant_address"></asp:RequiredFieldValidator>
                        <asp:Label ID="L3" runat="server" Text="Restaurant Address:"></asp:Label>
                        <asp:TextBox ID="restaurant_address" autocomplete="off" runat="server"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Category is Required" ControlToValidate="category" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:Label ID="L4" runat="server" Text="Food Category:"></asp:Label>
                        <asp:DropDownList ID="category" runat="server">
                            <asp:ListItem>Chinese</asp:ListItem>
                            <asp:ListItem>Dessert</asp:ListItem>
                            <asp:ListItem>Fast Food</asp:ListItem>
                            <asp:ListItem>Healthy</asp:ListItem>
                            <asp:ListItem>Malay</asp:ListItem>
                            <asp:ListItem>Western</asp:ListItem>
                        </asp:DropDownList>
                        
                        <asp:RequiredFieldValidator ID="RF11" runat="server" ErrorMessage="First Name is Required!" ForeColor="#FF3300" ControlToValidate="first_name"></asp:RequiredFieldValidator>
                        <asp:Label ID="L7" runat="server" Text="First Name:"></asp:Label>
                        <asp:TextBox ID="first_name" autocomplete="off" runat="server"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RF6" runat="server" ErrorMessage="Last Name is Required!" ForeColor="#FF3300" ControlToValidate="last_name"></asp:RequiredFieldValidator>
                        <asp:Label ID="L8" runat="server" Text="Last Name:"></asp:Label>
                        <asp:TextBox ID="last_name" autocomplete="off" runat="server"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RF7" runat="server" ErrorMessage="Mobile Phone is Required!" ForeColor="#FF3300" ControlToValidate="mobile_phone"></asp:RequiredFieldValidator>
                        <asp:Label ID="L9" runat="server" Text="Mobile Number:"></asp:Label>
                        <asp:TextBox ID="mobile_phone" autocomplete="off" runat="server" ></asp:TextBox>
                        <asp:CompareValidator ID="CV2" runat="server" ErrorMessage="Must Be Number" ControlToValidate="mobile_phone" Operator="DataTypeCheck" Type="Integer" ForeColor="#FF3300"></asp:CompareValidator>
                        
                        <asp:RequiredFieldValidator ID="RF8" runat="server" ErrorMessage="Email Address is Required!" ForeColor="#FF3300" ControlToValidate="email_address"></asp:RequiredFieldValidator>
                        <asp:Label ID="L10" runat="server" Text="Email Address:"></asp:Label>
                        <asp:TextBox ID="email_address" AutoComplete="off" runat="server" TextMode="Email"></asp:TextBox>

                        <asp:RegularExpressionValidator ID="REV1" runat="server" ErrorMessage="at least 8 characters, (A-Z, 1-9, !@#$%^) " ControlToValidate="password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                        <asp:Label ID="L12" runat="server" Text="Password:"></asp:Label> 
                        <asp:TextBox ID="password" runat="server" type="password"></asp:TextBox>

                        <asp:CompareValidator ID="CV1" runat="server" ErrorMessage="Password does not match!" ForeColor="#FF3300" ControlToCompare="password" ControlToValidate="confirm"></asp:CompareValidator>
                        <asp:Label ID="L13" runat="server" Text="Password Confirmation:"></asp:Label>
                        <asp:TextBox ID="confirm" runat="server" type="password"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Submit Form" OnClick="Button1_Click"/>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [restaurant_details]"></asp:SqlDataSource>
                        <br />
                    </div>
                </div>
            </div>
    </form>
</body>
</html>
