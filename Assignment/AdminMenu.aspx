<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="Assignment.AdminMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zippy Plates Admin Menu</title>
    <link href="AdminSite.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Ropa+Sans&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a41182d877.js"></script>
    <style type="text/css">
        .auto-style2 {
            height: 473px;
           
            justify-content:center;
        }
        a.logout
        {
            margin-left:300px;
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
            width: 180px;
            margin-top: 10px;
            margin-left: 390px;
            
        }

        #Button1:active {
            transform: scale(0.95);
        }

        #Button1:focus {
            outline: none;
        }

        #Button2 {
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
            width: 180px;
            margin-top: 10px;
            margin-left: 390px;
            
        }

        #Button2:active {
            transform: scale(0.95);
        }

        #Button2:focus {
            outline: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <nav>
                <div class="wrapper">
            <label class="logo">&nbsp;<a href="AdminMenu.aspx">ZippyPlates Admin</a></label>
                    <div class="login">
                        <a class="logout" href="Webform1.aspx">LOGOUT</a>
                    </div>
                </div>
             </nav>
        <div>
            <div class ="wrapper">
            <div class="container">
            <div class="form">
            <label class="logo"><h3>Admin Main Page</h3></label>
                <img src="img/undraw_add_notes_8cfw.png" style="height:500px;width:500px;margin:20px auto;" />
                <asp:Button ID="Button1" runat="server" Text="Manage Customer" OnClick="Button1_Click" /> 
                <asp:Button ID="Button2" runat="server" Text="Manage Restaurant" OnClick="Button2_Click" /> 
            <br />
           
            </div>
            </div>
            </div>
               </div>
        
    </form>
</body>
</html>
