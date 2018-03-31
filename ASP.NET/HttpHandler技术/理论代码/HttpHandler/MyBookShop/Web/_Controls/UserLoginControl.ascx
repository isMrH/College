<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLoginControl.ascx.cs" Inherits="_Controls_UserLoginControl" %>
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
.STYLE5 {color: #CC9900}
.STYLE6 {font-size: 12px}
-->
</style>
 <table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tbl_first">
        <tr>
          <td width="10"><img src="../Images/az-tan-top-left-round-corner.gif" width="10" height="28" /></td>
          <td bgcolor="#DDDDCC"><span class="STYLE1">登录第三波书店</span></td>
          <td width="10"><img src="../Images/az-tan-top-right-round-corner.gif" width="10" height="28" /></td>
        </tr>
      </table>
      <table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tbl_secend">
        <tr>
          <td bgcolor="#DDDDCC" style="width: 2px">&nbsp;</td>
          <td><div align="center">
              <table height="61" cellpadding="0" cellspacing="0">
                <tr>
                  <td height="33" colspan="6"><p class="STYLE2">已注册用户请从这里登录</p></td>
                </tr>
                <tr>
                  <td width="24%" height="26" rowspan="2" align="right" valign="top"><strong>用户名：</strong></td>
                  <td valign="top" width="37%">
                      &nbsp;<asp:TextBox ID="txt_LoginId" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_LoginId"
              ErrorMessage="*"></asp:RequiredFieldValidator><!--input name="EMail" type="text" size="33" onblur="checkEmail();"--></td>                  
                </tr>
              </table>
            <table height="61" cellpadding="0" cellspacing="0">
                <tr>
                  <td height="1" colspan="6"></td>
                </tr>
                <tr>
                  <td width="24%" height="26" rowspan="2" align="right" valign="top"><strong>密　码：</strong></td>
                  <td valign="top" width="37%">
                      &nbsp;<asp:TextBox ID="txt_LoginPwd" runat="server" TextMode="Password"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_LoginPwd"
              ErrorMessage="*"></asp:RequiredFieldValidator><!--input name="EMail" type="text" size="33" onblur="checkEmail();"--></td>                  
                </tr>
              </table>
            <!-- -->
              <div class="STYLE5">
            <asp:ImageButton runat="server" ID="btn_Login" ImageUrl="../Images/az-login-gold-3d.gif" OnClick="btn_Login_Click1" />
            <asp:ImageButton runat="server" ID="btn_Register" ImageUrl="../Images/az-newuser-gold-3d.gif" OnClick="btn_Register_Click"  CausesValidation="false"/>
          </div>
              <div class="STYLE5">
                <div align="center"><img src="../Images/touming.gif" width="27" height="15" /></div>
              </div>
            </td>
          <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
        </tr>
      </table>
      <table width="60%" height="3" border="0" align="center" cellpadding="0" cellspacing="0"  runat="server" id="tbl_third">
        <tr align="center">
          <td height="3" bgcolor="#DDDDCC"><img src="../Images/touming.gif" width="27" height="9"/>
          <a href="~/Membership/UserExit.aspx" runat="server" id="link_Exit" visible="false">注销</a></td>
        </tr>
      </table>
