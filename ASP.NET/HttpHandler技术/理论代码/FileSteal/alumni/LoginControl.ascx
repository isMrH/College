<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="LoginControl" %>
<%@ Register Assembly="WebValidates" Namespace="WebValidates" TagPrefix="cc1" %>
<table border="0" bgcolor="#F5F2ED" style="width: 358px; height: 178px">
          <tr>
            <td colspan="3" style="background-image:  url(Image/left13.gif)"><div align="center" class="STYLE1" style="font-weight: bold; color: #ff0000">同学录登录</div></td>
          </tr>
          <tr>
            <td width="119" height="50" rowspan="2"><img src="Image/left12.gif" alt="d" width="78" height="100" /></td>
            <td style="width: 369px; height: 28px" align="right" >用户名：</td>
            <td style="width: 214px; height: 28px">&nbsp;<asp:TextBox ID="txtName" runat="server" Style="position: static" Height="20px" Width="140px"></asp:TextBox></td>
          </tr>
          <tr>
            <td style="width: 369px" align="right">密 &nbsp;码： </td>
            <td style="width: 214px">&nbsp;<asp:TextBox ID="txtPsd" runat="server" Style="position: static" Height="20px" TextMode="Password" Width="140px"></asp:TextBox></td>
          </tr>
         <tr>
             <td rowspan="1" style="height: 52px" width="119">
             </td>
             <td align="right" style="width: 369px; height: 52px">
                 验证码：</td>
             <td style="width: 214px; height: 52px">
                 <asp:TextBox ID="txtValidate" runat="server" Width="140px"></asp:TextBox>&nbsp;
             </td>
         </tr>
         <tr>
             <td rowspan="1" style="height: 52px" colspan="2">
                 <asp:LinkButton ID="lnkbtnAgain" runat="server" OnClick="lnkbtnAgain_Click">不清楚，再来一张</asp:LinkButton></td>
             <td style="width: 214px; height: 52px">
                 &nbsp;<cc1:SerialNumber ID="snValidate" runat="server">
                 </cc1:SerialNumber>
             </td>
         </tr>
          <tr>
            <td>&nbsp;</td>
            <td colspan="2" align=center>&nbsp;<asp:Button ID="btnLogin" runat="server" Style="position: static" Text="登 录"  OnClick="btnLogin_Click"  />
                <asp:Button ID="btnRegister" runat="server" Style="position: static" Text="注 册" /></td>
          </tr>
      </table>