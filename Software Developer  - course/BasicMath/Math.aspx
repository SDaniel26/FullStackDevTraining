<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Math.aspx.cs" Inherits="BasicMath.Math" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbInput" runat="server" Height="76px" Width="223px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="lblRezultat" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            First name<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            last name<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
