<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      *{ margin:0px auto; padding:0px;}
      .father{ width:600px;height:500px;}
      #title{ text-align:center; margin-top:10px;}
      #c1{ text-align:center; margin-top:10px;}
      #c2{ margin-top:10px;}
      #Add{ margin-left:50px; margin-top:10px;}
      #content{ text-align:center;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="father">
        <div id="title">
           商品名称：<asp:TextBox ID="txtName" runat="server" Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSelect" runat="server" Text="查询" onclick="btnSelect_Click" />
        </div>
        <div id="content">
            <div id="c1">商品信息列表</div>
            <div id="c2">
                <asp:GridView ID="gvGoods" runat="server" AutoGenerateColumns="False" 
                    Width="475px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
                    BorderWidth="1px" CellPadding="4" Font-Size="Small">
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <Columns>
                        <asp:BoundField DataField="GoodsName" HeaderText="名称" />
                        <asp:BoundField DataField="GoodsPrice" HeaderText="单价" />
                        <asp:BoundField DataField="GoodsCount" HeaderText="数量" />
                        <asp:BoundField DataField="Company" HeaderText="供应商" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                </asp:GridView>
            </div>
            <div id="Add"><a href="Default.aspx">添加商品</a></div>
        </div>
    </div>
    </form>
</body>
</html>
