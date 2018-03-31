<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserRegisterControl.ascx.cs" Inherits="_Controls_UserRegisterControl" %>
<%@ Register Assembly="WebValidates" Namespace="WebValidates" TagPrefix="cc1" %>
    <style type="text/css">
    <!--
    .STYLE1 {
	    font-family: "黑体";
	    font-size: 16px;
	    color: #660000;
    }
    .STYLE2 {
	    font-size: 14px;
	    font-weight: bold;
	    color: #FF9900;
    }
    .STYLE4 {
	    font-size: 12px;
	    color: #000000;
    }
    .STYLE5 {color: #CC9900}
    -->
    </style>

  <div style="font-size:small">
  <table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td style="width: 10px"><img src="../Images/az-tan-top-left-round-corner.gif" width="10" height="28" /></td>
    <td bgcolor="#DDDDCC"><span class="STYLE1">注册新用户</span></td>
    <td width="10"><img src="../Images/az-tan-top-right-round-corner.gif" width="10" height="28" /></td>
  </tr>
</table>


<table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
    <td><div align="center">
      <table height="61" cellpadding="0" cellspacing="0">
        <tr>
          <td height="33" colspan="6"><p class="STYLE2">注册新帐户方便又容易</p></td>
        </tr>
        <tr>
          <td width="24%" align="center" valign="top" style="height: 26px">真实姓名：</td>
          <td valign="top" width="37%" align="left" style="height: 26px">
          <asp:TextBox ID="txt_LoginId" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvTrueName" runat="server" ErrorMessage="请输入真实姓名" ControlToValidate="txt_Name">*</asp:RequiredFieldValidator></td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">用户名：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ErrorMessage="请输入用户名" ControlToValidate="txt_LoginId">*</asp:RequiredFieldValidator></td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txt_LoginPwd" runat="server" TextMode="Password"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvPass" runat="server" ErrorMessage="请输入密码" ControlToValidate="txt_LoginPwd">*</asp:RequiredFieldValidator>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">确认密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txt_PwdAgain" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
          <asp:CompareValidator ID="cvPass" runat="server" ErrorMessage="两次密码不一致" ControlToCompare="txt_LoginPwd" ControlToValidate="txt_PwdAgain">*</asp:CompareValidator></td>          
        </tr>
         <tr>
          <td width="24%" height="26" align="center" valign="top">Email：</td>
          <td valign="top" width="37%" align="left">
              <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="请输入Email" ControlToValidate="txt_Email">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="格式错误" ControlToValidate="txt_Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">地址：</td>
          <td valign="top" width="37%" align="left">
             <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvAddr" runat="server" ErrorMessage="请输入地址" ControlToValidate="txt_Address">*</asp:RequiredFieldValidator>&nbsp;
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">手机：</td>
          <td valign="top" width="37%" align="left">
              <asp:TextBox ID="txt_Tele" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvTel" runat="server" ErrorMessage="请输入手机号" ControlToValidate="txt_Tele">*</asp:RequiredFieldValidator>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">
              验证码：</td>
          <td valign="top" width="37%" align="left">
              <asp:TextBox ID="tbCode" runat="server"></asp:TextBox>&nbsp;
              <cc1:SerialNumber ID="snCode" runat="server">
              </cc1:SerialNumber>
              &nbsp;
          </td>          
        </tr>
        <tr>
          <td colspan="2" align="left"><font color="red">
              <asp:ValidationSummary ID="vsregister" runat="server" ShowMessageBox="True" ShowSummary="False" />
          </font></td>           
        </tr>
        <tr>
          <td colspan="2" align="center"><asp:ImageButton id="btn_Register" onclick="btnSubmit_Click" runat="server" ImageUrl="../Images/az-finish.gif"></asp:ImageButton><asp:Literal id="ltMain" runat="server"></asp:Literal></td>           
        </tr>
      </table>
      <div class="STYLE5">---------------------------------------------------------</div>
    </div>	
    </td>
    <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
  </tr>
</table>

<table width="60%" height="3" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="3" bgcolor="#DDDDCC"><img src="../Images/touming.gif" width="27" height="9" /></td>
  </tr>
</table>
</div>