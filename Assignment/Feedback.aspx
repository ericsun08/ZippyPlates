<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Assignment.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Feedback.css" rel="stylesheet"/>
        <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
        <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
       <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <title>ZippyPlates</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
            <div class="wrapper">
            <label class="logo"><a href="WebForm1.aspx">ZippyPlates</a></label>
            </div>
            </nav>
            </div>
        <div class="wrapper">
            <div class="content1">
                <label class="logo">ORDER SUCCESFULLY!</label>
                <br />
                <label class="logo">YOUR ORDER WILL BE DELIVERED SHORTLY</label>
                <br />
                <img src="img/undraw_drone_delivery_5vrm.png" style="width:300px;height:300px;" />


            </div>
           
               <div class="feedback">
                    <div class="form">
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                        <asp:HiddenField ID="HiddenField2" runat="server" />
                        <label class="logo">Feedback</label>
                        <br />
                        <label  class="lbl">Message:</label>
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Message Here..." Height="63px" autocomplete="off"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="PLEASE WRITE MESSAGE" ControlToValidate="Textbox3" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:Button ID="Button1" runat="server" Text="Submit!" OnClick="Button1_Click1" style="height: 53px"  />
                    </div>
            </div>
                
          </div>  

             <div class="footer">
            <div class="wrapper">
                    <label class="logo">ZippyPlates</label>
             
                <div class="item4">
                    <p>Support</p>
                    <br />
                    <ul class="fcategory">
                        <li><a href="AboutUs.aspx">About Us</a></li>
                        <li><a href="#">Help Centre</a></li>
                        <li><a href="#">Contact Us</a></li>
                        
                    </ul>
                </div>
                <div class="item7">
                    <p>Follow Us On</p>
                    <br />
                    <i class="fab fa-facebook-square"></i>
                    <i class="fab fa-twitter-square"></i>
                    <i class="fab fa-instagram"></i>
                </div>
                <div class="copyright">
                    <p style="color:#eee;">© ZippyPlates 2020</p>
                    <br />
                    <p><a href="#">Terms & Condition • Privacy Policy</a></p>
                </div>
            </div>
        </div>
   
        

            
                    
      
    </form>
</body>
</html>
