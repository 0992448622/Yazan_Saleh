<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringpage1.aspx.cs" Inherits="WebApplication1.QueryStringpage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   Name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Age : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
          <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Text="Male"></asp:ListItem>
            <asp:ListItem  Text="Female"></asp:ListItem>
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
