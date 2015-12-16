<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateScan.aspx.cs" Inherits="GISTEAMA1.GenerateScan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
        <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
    </div>
        <asp:PlaceHolder ID="plBarCode" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
