<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style type="text/css">
#lblPwd,#lblUname 
{
	text-align:right;
}
</style>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUname" runat="server" Text="登录名:" Width="60px"></asp:Label>
        <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
    
    </div>
    <div>
    
        <asp:Label ID="lblPwd" runat="server" Text=" 密 码:" Width="60px"></asp:Label>
        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
    
    </div>
    <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="登录" />
    <p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
