<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Register.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 30%;
            text-align:center;
        }
        .style2
        {
            text-align: left;
            width: 205px;
        }
        .style3
        {
            width: 93px;
            text-align: right;
        }
        #form1
        {}
    </style>
</head>
<body>
<div id="Wapper">

    <form id="form1" runat="server">
    <table class="Table" border="1px">
        <tr>
            <td class="style1" colspan="2">
                管理员注册</td>
        </tr>
        <tr>
            <td class="style3">
                账号：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                密码：</td>
            <td class="style2">
                <asp:TextBox ID="txt" runat="server" TextMode="Password" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                确认密码：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                电话：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox4" runat="server" Width="184px" 
                    style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Email：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox5" runat="server" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                备注：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox6" runat="server" Width="184px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="确认注册" />
            </td>
        </tr>
    </table>
    </form>
</div>
</body>
</html>
