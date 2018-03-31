﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="输入车次："></asp:Label>
        <br />
        <asp:TextBox ID="txtTicketNo" runat="server" BorderColor="#00CCFF" 
            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="出发地："></asp:Label>
        <br />
        <asp:TextBox ID="txtFromplace" runat="server" BorderColor="#00CCFF" 
            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="到达地："></asp:Label>
        <br />
        <asp:TextBox ID="txtToplace" runat="server" BorderColor="#00CCFF" 
            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Size="Small" Text="类型："></asp:Label>
        <br />
        <asp:DropDownList ID="ddlType" runat="server" Width="151px">
            <asp:ListItem Value="1">硬座</asp:ListItem>
            <asp:ListItem Value="2">硬卧</asp:ListItem>
            <asp:ListItem Value="3">软卧</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSelect" runat="server" Text="查询" onclick="btnSelect_Click" />
        <br />
        <hr />
        <asp:Label ID="Label5" runat="server" Font-Size="Small" Text="剩余票数："></asp:Label>
        <asp:Label ID="lblNum" runat="server" Font-Size="Small"></asp:Label>
        <asp:Label ID="lblErrorInfo" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
        <br />
        <br />
        
        <asp:Label ID="Label6" runat="server" Font-Size="Small" Text="票 单 价："></asp:Label>
        
        <asp:Label ID="lblUnitprice" runat="server" Font-Size="Small"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Size="Small" Text="发车时间："></asp:Label>
        <asp:Label ID="lblStartTime" runat="server" Font-Size="Small"></asp:Label>
        
    </div>
    </form>
</body>
</html>
