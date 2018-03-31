<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script  type ="text/javascript"  src="Scripts/jquery-1.4.1.js" >
    </script>
    
    <script type="text/javascript" language="javascript">

        $(function() {
            //用户名的注册
            $("#txtLoginId").bind("blur", function() {
                $.ajax({
                    url: "Handler/Register.ashx",//处理方式
                    type: "post",//提交方式
                    data: {UserName: $("#txtLoginId").val() }, //传过去的处理函数
                    success: function(result) {//成功返回结果
                    //返回结果页面加载
                        $("#msg").html(result);
                    },
                    error: function() {
                    //失败返回结果 //返回结果页面加载
                    $("#msg").html("<font color='red'>服务器连接错误</font>");
                    }
                });
            });
        });
     </script>
    <style type="text/css">
        #msg
        {
            width: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td style="width: 10px"><img src="images/topleft.gif" width="10" height="28" /></td>
    <td bgcolor="#DDDDCC"><span >注册新用户</span></td>
    <td width="10"><img src="images/topright.gif" width="10" height="28" /></td>
  </tr>
</table>


<table height="22" border="0" align="center" cellpadding="0" cellspacing="0" 
                style="width: 59%">
  <tr>
    <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
    <td><div align="center">
      <table height="61" cellpadding="0" cellspacing="0" style="width: 389px">
        <tr>
          <td height="33" colspan="6"><p class="STYLE2">注册新帐户方便又容易</p></td>
        </tr>
        <tr>
          <td width="24%" align="center" valign="top" style="height: 26px">用户名</td>
          <td valign="top" width="37%" align="left" style="height: 26px">
          <asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox><span id="msg"></span>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">
              昵称：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtLoginPwd" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">确认密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
          </td>          
        </tr>
         <tr>
          <td width="24%" height="26" align="center" valign="top">Email：</td>
          <td valign="top" width="37%" align="left">
              <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
              &nbsp;
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">
              QQ：</td>
          <td valign="top" width="37%" align="left">
             <asp:TextBox ID="txtQQ" runat="server"></asp:TextBox>
              &nbsp;
          </td>          
        </tr>
        <tr>
          <td colspan="2" align="center"><asp:ImageButton id="btnRegister"  runat="server" ImageUrl="images/finish.jpg" OnClick="btnRegister_Click"></asp:ImageButton>
              <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>           
        </tr>
      </table>
      <div class="STYLE5"></div>
    </div>	
    </td>
    <td bgcolor="#DDDDCC">&nbsp;</td>
  </tr>
</table>


<table width="60%" height="3" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="3" bgcolor="#DDDDCC">&nbsp;</td>
  </tr>
</table>

    </div>
    </form>
</body>
</html>
