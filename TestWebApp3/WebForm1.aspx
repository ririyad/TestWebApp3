<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebApp3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="170px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="clickMeButton" runat="server" OnClick="clickMeButton_Click" Text="Click Me Change By Asadullah Sikdar" />
    
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Width="163px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="clickMeByRiyadTextBox" runat="server" OnClick="clickMeByRiyadTextBox_Click" Text="Click Button by Riyad" Width="342px" />
    
    </div>
    </form>
</body>
</html>
