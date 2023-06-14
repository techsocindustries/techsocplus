<%@ Page Language="C#" AutoEventWireup="true" Inherits="MyNamespace.LoginClass" CodeBehind="login.aspx.cs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login - Techsoc+</title>
    <link rel="stylesheet" href="/style.css">
</head>
<body>
    <img src="tslogo.png" style="width: 200px; padding-bottom: 20px;">
    <br>
    <form id="form1" runat="server">
        <table style="margin-left: auto; margin-right: auto;">
            <tr>
                <td><asp:Label ID="lblUsername" runat="server" Text="Username:" AssociatedControlID="txtUsername" /></td>
                <td><asp:TextBox ID="txtUsername" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword" /></td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
            </tr>
        </table>
        <br>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Login_Click" />
        <br><br>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="False" />
    </form>
</body>
</html>
