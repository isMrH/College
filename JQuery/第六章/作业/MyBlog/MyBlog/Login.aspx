<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="text-align :center ">
    <form id="form1" runat="server">
    <div >
    <h2>
                            用户登录
                        </h2>
      <table border="0" style=" background-color: #66CCFF;">
                            <tr>
                                <td >
                                    用户名：</td>
                                <td >
                                    <asp:TextBox ID="txtLoginId" runat="server" CssClass="formfield" Width="100px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td >
                                    密 &nbsp; 码：</td>
                                <td >
                                    <asp:TextBox ID="txtLoginPwd" runat="server" CssClass="formfield" Width="100px" TextMode="Password"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                 <asp:ImageButton ID="imgbtnRegister" runat="server"  ImageUrl="~/images/reg.jpg" OnClick="imgbtnRegister_Click" />
                                 <asp:ImageButton ID="imgbtnLogin" runat="server" 
                                        ImageUrl="~/images/login.jpg" 
                                        OnClick="imgbtnLogin_Click" />
                                </td>
                            </tr>
                        </table>
    </div>
    </form>
</body>
</html>
