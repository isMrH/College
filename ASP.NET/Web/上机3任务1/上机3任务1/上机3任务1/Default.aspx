<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="上机3任务1._Default" %>

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
    }
    body
    {
    	text-align:center;
    	line-height:30px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="注册企业会员"></asp:Label>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="公司名称："></asp:Label>
    <asp:TextBox ID="txtName" runat="server" Height="20px" Width="200px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="所属行业："></asp:Label>
    <asp:DropDownList ID="ddlTrade" runat="server" Height="20px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="200px">
        <asp:ListItem>经营管理类</asp:ListItem>
        <asp:ListItem>销售管理类</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="公司性质："></asp:Label>
    <asp:DropDownList ID="ddlQuality" runat="server" Height="20px" Width="200px">
        <asp:ListItem>集体企业</asp:ListItem>
        <asp:ListItem>上市企业</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label6" runat="server" Text="注册资金："></asp:Label>
    <asp:TextBox ID="txtFinancing" runat="server" Height="20px" Width="152px"></asp:TextBox>
    <asp:Label runat="server" Text="万元" Width="40px"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="公司地址："></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server" Height="20px" Width="200px"></asp:TextBox>
    <br />
    <asp:Button ID="btnSave" runat="server" Text="完成" 
        PostBackUrl="~/WebForm1.aspx" />
    </form>
</body>
</html>
