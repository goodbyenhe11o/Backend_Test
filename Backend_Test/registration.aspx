<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Backend_Test.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://unpkg.com/nes.css@2.3.0/css/nes.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Press+Start+2P" rel="stylesheet" />
    <link href="allcss/registration.css" rel="stylesheet" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="nes-container with-title is-centered">
            <p class="title">REGISTRATION</p>
            <label>YOUR NAME</label>
            <asp:TextBox ID="txtUname" runat="server" class="nes-input" required></asp:TextBox>
            <label>EMAIL</label>
            <asp:TextBox ID="txtEmail" runat="server" class="nes-input" required></asp:TextBox>
            <label>USERNAME <span>*</span></label>
            <asp:TextBox ID="txtUsername" runat="server" class="nes-input" required></asp:TextBox>
            <label>PASSWORD <span>*</span></label>
            <asp:TextBox ID="txtPassword" runat="server" class="nes-input" required></asp:TextBox>
            <label>CONFIRM YOUR PASSWORD <span>*</span></label>
            <asp:TextBox ID="txtCpassword" runat="server" class="nes-input" required></asp:TextBox>
            <asp:Label ID="lblErrorMessage" runat="server" Text="CONFIRM YOUR PASSWORD"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="UPLOAD YOUR PROFILE PICTURE" class="nes-btn is-error" />
            
            <div class="rego-btn">
                <asp:Button ID="RegoSubmit" runat="server" Text="SUBMIT" class="nes-btn is-primary" />
                <input type="reset"  id="Reset1" class="nes-btn is-warning" value="CANCEL">
            </div>
        </div>
    </form>
</body>
</html>
