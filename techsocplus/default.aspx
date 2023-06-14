<%@ Page Language="C#" AutoEventWireup="true" Inherits="MyNamespace.MainClass" CodeBehind="default.aspx.cs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Welcome - Techsoc+</title>
    <link rel="stylesheet" href="/style.css">
</head>
<body>
    <form id="form1" runat="server">
        <img src="tslogo.png" style="width: 200px; padding-bottom: 25px;">
        <br>
        Click <a href="content/">here</a> to view Techsoc+ content
        <br><br>
        <div class="container">
            <div style="font-size: 10pt; background-color: dimgray; width: 500px; padding: 10px;">
                <b>Upload a file to Techsoc+</b> (max 2 GB)
                <br><br>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="btnUpload" runat="server" Text="Upload file" OnClick="Upload_Click" />
                <asp:Label ID="lblMessage" runat="server" />
            </div>
        </div>
        <div style="font-size: 8pt; color: silver;">
            <br>
            <asp:Literal ID="litUsername" runat="server" />
            <br><br>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="Logout_Click" />
        </div>
    </form>
</body>
</html>
