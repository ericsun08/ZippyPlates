<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Assignment.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet"/>
    <link href="Payment.css" rel="stylesheet" />
    <style>
        .rPara
        {
            display:inline-block;
            margin-left:10px;
            font-size:18px;
            font-weight:bold;
        }
        .rPara2
        {
            display:inline-block;
            float:right;
            margin-right:50px;
            font-weight:bold;
            font-size:15px;
        }
        .ordersummary
        {
            height:200px;
            
            overflow:scroll;
        }
        #Label1
        {
            font-size:18px;
            font-weight:bold;
        }
        #Label2
        {

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="wrapper">
                <a class="logo" href="WebForm1.aspx">ZippyPlates</a>
            </div>
        </nav>
        <div class="wrapper">
            <div class="container">
                
                    
                        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                   
                    <label class="Litem">Item</label>
                    <label class="Lprice">Price</label>
                    <div class="ordersummary">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    </div>
                    <label class="total">Total: </label>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <label class="deliver">Deliver To:</label>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Place Your Order</asp:LinkButton>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
               
            </div>
        </div>
    </form>
</body>
</html>