<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="上机3任务2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
    *
    {
    	margin:0px;
    	padding:0px;
    	list-style:none;
    }
    .cen
    {
    	text-align:center;
    	margin:50px auto;
    }
    #form1
    {
    	text-align:right;
    	width:300px;
    	margin:0px auto;
    }
    </style>
</head>
<body>
<div class="cen">
    <form id="form1" runat="server">
  
        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>   
        <br />  
    
    <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password">txtPwd</asp:TextBox>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="登录" onclick="btnSave_Click" />
    </p>

    </form>
</div>
</body>
</html>
