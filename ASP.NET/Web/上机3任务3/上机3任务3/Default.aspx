<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="上机3任务3._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="用户名：" Width="70px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="密码：" Width="70px"></asp:Label>
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="完成" />
    
    </div>
    </form>
</body>
</html>
