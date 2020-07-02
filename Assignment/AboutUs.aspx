<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Assignment.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AboutUs.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
         <nav>
            <div class="wrapper">
                <label class="logo"><a href="AfterLogin.aspx">ZippyPlates</a></label>
            </div>
        </nav>
        <div class="wrapper">
            <div class="title">
                <h1>About ZippyPlates</h1>
                <img src="img/undraw_team_page_pgpr.png" style ="width:450px;height:250px;"/>
            </div>
             <div class="about">
                     <h3>Zippy Plates</h3>
                 <h2>Our Vision</h2>
                 "To Create a better connection from food to human."
                 <h2>Our Mission</h2>
                 While the world is changing towards technology. We Provide a better lifestyle for people to obtain the food that they love to have at any time with Zippy Plates any food in your area, can get it for delivery.
             </div>
            <div class="team">
                <h3>Meet Our Team</h3>
                <div class="maincontainer">
                    <div class="subcontainer">
                        <img src="img/IMG_9866%20(1).JPG" style ="width:100%;height:160px;" />
                        <h2>Stanley Wijaya</h2>
                        <p class="role">Designer</p>
                        <p>StanleyWijaya@gmail.com</p>
                        <p><button class="button">Contact</button></p>
                    </div>

                    <div class="subcontainer">
                        <img src="img/IMG_9867%20(1).PNG" style ="width:100%;height:160px;"/>
                        <h2>Eric Sun</h2>
                        <p class="role">Founder & Ceo</p>
                        <p>suneric@gmail.com</p>
                        <p><button class="button">Contact</button></p>
                    </div>

                    <div class="subcontainer">
                        <img src="img/IMG_9865%20(1).JPG" style ="width:100%;height:160px;"/>
                        <h2>Eric Drakevanto</h2>
                        <p class="role">Programmer</p>
                        <p>ericdrake@gmail.com</p>
                        <p><button class="button">Contact</button></p>
                    </div>
                </div>
               
            </div>
        </div>
    </form>
</body>
</html>
