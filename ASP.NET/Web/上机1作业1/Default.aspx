<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        *
        {
        	margin:0px;
        	padding:0px;
        	list-style:none;
        }
        .style1
        {
            width: 26%;
            margin:10px auto;        
        }
        .style2
        {
        }
        .style3
        {
            height: 23px;
        }
        .style4
        {
            width: 135px;
        }
        .style5
        {
            height: 23px;
            width: 135px;
        }
        #form1
        {
        	margin:10px auto;
            height: 211px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
    <table class="style1" id="Table">
        <tr>
            <td align="center" colspan="2">
                注册新账户方便又容易</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                用户名：</td>
            <td>
                <asp:TextBox ID="txtUName" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                昵称：</td>
            <td class="style3" align="left">
                <asp:TextBox ID="txtName" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                密码：</td>
            <td align="left">
                <asp:TextBox ID="txtPWD" runat="server" Width="167px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                确认密码：</td>
            <td>
                <asp:TextBox ID="txtRePWD" runat="server" Width="167px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Email：</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                QQ：</td>
            <td>
                <asp:TextBox ID="txtQQ" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style2" colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="完成" onclick="btnSave_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
