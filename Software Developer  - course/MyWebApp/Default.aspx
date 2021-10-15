<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="tbInput" runat="server" Height="77px" Width="331px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Height="39px" OnClick="btnOk_Click" Text="OK" Width="136px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <br />

        </div>
    </form>
</body>
</html>
