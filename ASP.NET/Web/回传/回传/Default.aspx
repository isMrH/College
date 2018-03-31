<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="回传._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;<asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSex" runat="server" Text="性别："></asp:Label>
        <asp:RadioButtonList ID="rdoSex" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" 
        PostBackUrl="~/Default2.aspx" Text="完成" />
    </form>
</body>
</html>
