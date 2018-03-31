<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="上机3任务1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        *
    {
    	padding:0px;
    	margin:0px;
    	list-style:none;
            height: 32px;
        }
    body
    {
    	text-align:center;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="确认企业会员信息"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="公司名称："></asp:Label>
        <asp:Label ID="lblName" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="所属行业："></asp:Label>
        <asp:Label ID="lblTrade" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="公司性质："></asp:Label>
        <asp:Label ID="lblQuality" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="注册资金："></asp:Label>
        <asp:Label ID="lblFinancing" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAddresss" runat="server" Text="公司地址："></asp:Label>
        <asp:Label ID="lblAddress" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnSave" runat="server" Text="确定" onclick="btnSave_Click" 
            Height="23px" Width="64px" />
    
    </div>
    </form>
</body>
</html>
