<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="LoginForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="heading">Login Page</h1>
            <asp:Label runat="server" ID="nameLabel">Enter your username: </asp:Label>
            <asp:TextBox CssClass="field" runat="server" ID="username"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="passLabel">Enter you password: </asp:Label>
            <asp:TextBox CssClass="field" runat="server" ID="password"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn" runat="server" ID="loginBtn" Text="Login" OnClick="Login"/>


        </div>
    </form>

   
</body>
</html>