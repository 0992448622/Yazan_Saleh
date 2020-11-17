<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStatePage1.aspx.cs" Inherits="WebApplication1.ViewStatePage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     UserName :<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        Password : <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add To View" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="View" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
