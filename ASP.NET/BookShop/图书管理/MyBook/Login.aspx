<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tblfirst">
        <tr>
          <td width="10"><img src="Images/az-tan-top-left-round-corner.gif" width="10" height="28" /></td>
          <td bgcolor="#DDDDCC"><span style="font-family: '黑体';font-size: 16px;color: #660000;">登录第三波书店</span></td>
          <td width="10"><img src="Images/az-tan-top-right-round-corner.gif" width="10" height="28" /></td>
        </tr>
    </table>
    <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tblsecend">
       <tr>
          <td colspan=2 height="33" align="center"><p style="font-size:14px;font-weight: bold;color: #FF9900;">已注册用户请从这里登录</p></td>
       </tr>
       <tr>
          <td  height="26"  align="right"  style="width: 226px"><strong>用户名：</strong></td>
          <td>
              <asp:TextBox ID="txtLoginId" runat="server" Width="120px" BorderColor="#003300" 
                  BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                  ControlToValidate="txtLoginId" ErrorMessage="*"></asp:RequiredFieldValidator>
           </td>
       </tr>
       
       <tr>
          <td  height="26"  align="right"  style="width: 226px"><strong>密　码：</strong></td>
          <td>
              <asp:TextBox ID="txtLoginPwd" runat="server" TextMode="Password" Width="120px" 
                  BorderColor="#003300" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                  ControlToValidate="txtLoginPwd" ErrorMessage="*"></asp:RequiredFieldValidator>
           </td>
       </tr>
      
   </table>
   
   <div align="center" style="margin-top:10px;margin-bottom:10px;">
    <asp:ImageButton runat="server" ID="imgbtnLogin" ImageUrl="Images/az-login-gold-3d.gif" OnClick="btnLogin_Click" />
    <asp:ImageButton runat="server" ID="imgbtnRegister" ImageUrl="Images/az-newuser-gold-3d.gif" OnClick="btnRegister_Click"  CausesValidation="false"/>
  </div>
   
    <table width="80%" height="20" border="0" align="center" cellpadding="0" cellspacing="0"  runat="server" id="tblthird">
    <tr align="center">
      <td height="3" bgcolor="#DDDDCC">
          &nbsp;
          </td>
          </tr>
    </table>
</asp:Content>


