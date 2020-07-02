<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Assignment.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Feedback.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <title>Contact Us!</title>
    <style>
        .box 
        {
            float: left;
            margin:20px;
            width: 250px;
            height: 300px;
            border-radius:5px;            
            box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
            margin-left: 30px;
            margin-right:20px;
            overflow:hidden;
        }
        .box .Rname, .Rcaption
        {
            padding:8px;
        }
        .box h4
        {
            font-weight:bold;
        }
        .box p
        {
            font-size:15px;
        }
        .box a:hover
        {
            color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
            <nav>
            <div class="wrapper">
            <label class="logo"><a href="AfterLogin.aspx">ZippyPlates</a></label>
            </div>
            </nav>
            </div>
             <div class="data">
            <div class="content1">
                <label class="logo">Contact Us!</label>
                <br />
                <img  class="contactus" src="img/undraw_contact_us_15o2.png" /> 
                <br />
                <div class="content3">
                    <label class="logo">Malaysia</label>
                    <br />
                    <label style="font-weight:bolder">Phone:</label> <label>+6012345678</label>
                    <br />
                    <br />
                    <label style="font-weight:bolder">E-Mail:</label> <label>admin@zippyplates.com</label>
                    <br />
                    <br />
                    <label style="font-weight:bolder">Address:</label> <label>Anywhere u like!</label>
                    <br />
                    <br />
                    <i class="fab fa-facebook-square"></i>
                    <i class="fab fa-twitter-square"></i>
                    <i class="fab fa-instagram"></i>
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

        </div>
    </form>
</body>
</html>
