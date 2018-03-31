<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
       
    <br />
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
              <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tblfirst">
        <tr>
          <td width="10"><img src="Images/az-tan-top-left-round-corner.gif" width="10" height="28" /></td>
          <td bgcolor="#DDDDCC"><span style="font-family: '黑体';font-size: 16px;color: #660000;">登录第三波书店</span></td>
          <td width="10"><img src="Images/az-tan-top-right-round-corner.gif" width="10" height="28" /></td>
        </tr>
    </table>
    <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tblsecend">
       <tr>
          <td colspan=2 height="33" align="center"><p style="font-size:14px;font-weight: bold;color: #FF9900;">注册新用户</p></td>
       </tr>
       <tr>
          <td  height="26"  align="right"  style="width: 226px"><strong>用户名：</strong></td>
          <td>
              <asp:TextBox ID="txtLoginId" runat="server" Width="120px" BorderColor="#003300" 
                  BorderStyle="Solid" BorderWidth="1px" AutoPostBack="True" 
                  ontextchanged="txtLoginId_TextChanged"></asp:TextBox>
              <asp:Label ID="lblMessage" runat="server" ForeColor="#FF3300"></asp:Label>
           </td>
       </tr>
       
       <tr>
          <td  height="26"  align="right"  style="width: 226px"><strong>密　码：</strong></td>
          <td>
              <asp:TextBox ID="txtLoginPwd" runat="server" TextMode="Password" Width="120px" 
                  BorderColor="#003300" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
           </td>
       </tr>
       <tr>
          <td  height="26"  align="right"  style="width: 226px"><strong>确认密码：<strong></td>
          <td>
              <asp:TextBox ID="txtPwd1" runat="server" TextMode="Password" Width="120px" 
                  BorderColor="#003300" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
           </td>
       </tr>
   </table>
   
   <div align="center" style="margin-top:10px;margin-bottom:10px;">
    <asp:ImageButton runat="server" ID="imgbtnLogin" ImageUrl="~/Images/az-finish.gif" 
           OnClick="btnLogin_Click" />
    <asp:ImageButton runat="server" ID="imgbtnRegister" 
           ImageUrl="~/Images/az-login-gold-3d.gif" OnClick="btnRegister_Click"  
           CausesValidation="false"/>
  </div>
   
    <table width="80%" height="20" border="0" align="center" cellpadding="0" cellspacing="0"  runat="server" id="tblthird">
    <tr align="center">
      <td height="3" bgcolor="#DDDDCC">
          &nbsp;
          </td>
          </tr>
    </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

