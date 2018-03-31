<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" bgcolor="#F5F2ED" style="width: 358px; height: 178px; background-color: #9999ff;">
          <tr>
            <td colspan="2" style="background-image:  url(Image/admin_bg_1.gif)"><div align="center" class="STYLE1" style="font-weight: bold; color: #ff0000">
                同学录后台登录</div></td>
          </tr>
          <tr>
            <td style="width: 86px; height: 28px" align="right" >用户名：</td>
            <td style="width: 162px; height: 28px">&nbsp;<asp:TextBox ID="txtName" runat="server" Style="position: static"></asp:TextBox></td>
          </tr>
          <tr>
            <td style="width: 86px; height: 43px;" align="right">密 &nbsp;码： </td>
            <td style="width: 162px; height: 43px;">&nbsp;<asp:TextBox ID="txtPsd" runat="server" Style="position: static" TextMode="Password"></asp:TextBox></td>
          </tr>
          <tr>
            <td colspan="2" align=center>&nbsp;<asp:Button ID="btnLogin" runat="server" Style="position: static" Text="登 录"  OnClick="btnLogin_Click"  />
                </td>
          </tr>
      </table>
    </div>
    </form>
</body>
</html>
