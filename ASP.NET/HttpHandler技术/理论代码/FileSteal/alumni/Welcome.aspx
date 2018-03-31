<%@ Page Language="C#" AutoEventWireup="true"    validateRequest="false" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<%@ Register Assembly="FreeTextBox"       Namespace="FreeTextBoxControls"  TagPrefix="FTB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>班级在线留言</title>
   
</head>
<body>
    <form id="form1" runat="server">
      
       
       <table id="__01" width="658" height="460" border="0" cellpadding="0" cellspacing="0">
	<tr>
		<td colspan="3">
			<img src="Image/index-1_01.jpg" width="658" height="34" alt=""></td>
	</tr>
	<tr>
		<td background="Image/index-1_02.jpg">
			<img src="Image/index-1_02.jpg" width="21" height="404" alt=""></td>
		<td valign="top">
		<table width="619" border="0" cellspacing="0">
          <tr>
            <td bgcolor="#E4FFE1" class="STYLE4" style="width: 177px; height: 33px;">
                留言标题：</td>
            <td width="516" bgcolor="#F5FFF4" style="height: 33px">&nbsp;
        
        
      
        <asp:Label ID="lblTitle" runat="server" Width="372px"  ></asp:Label>
       
    </td>
          </tr>
          <tr>
            <td bgcolor="#E4FFE1" >
                留言内容：</td>
            <td bgcolor="#F5FFF4" >&nbsp;
        <asp:Label ID="lblMessage" runat="server" Width="371px">暂无留言！</asp:Label>
        </td>
          </tr>
          <tr bgcolor="#E4FFE1" class="STYLE4">
            <td colspan="2" align="center"><span class="STYLE5">请在此留言</span></td>
          </tr>
          <tr>
            <td bgcolor="#E4FFE1" class="STYLE4" style="width: 177px"><span class="STYLE4"></span></td>
            <td bgcolor="#F5FFF4">&nbsp;</td>
          </tr>
          <tr>
            <td bgcolor="#E4FFE1" class="STYLE4" style="width: 177px">留言人：</td>
            <td bgcolor="#F5FFF4">&nbsp;<asp:Label ID="lblWelcome" runat="server"  EnableViewState="False" ></asp:Label>
            </td>
          </tr>
          <tr>
            <td bgcolor="#E4FFE1" class="STYLE4" style="width: 177px; height: 36px;">
                留言标题：</td>
            <td bgcolor="#F5FFF4" >  <asp:TextBox ID="txtTitle" runat="server" ></asp:TextBox></td>
          </tr>
          <tr>
            <td height="222" bgcolor="#E4FFE1" class="STYLE4" style="width: 177px">
                留言内容：</td>
            <td bgcolor="#F5FFF4">&nbsp;<FTB:FreeTextBox ID="txtContent" runat="server" Height="250px" Width="450px" Language="zh-CN">
        </FTB:FreeTextBox>
        </td>
          </tr>
          
          <tr>
            <td bgcolor="#E4FFE1" style="width: 177px; height: 40px;">&nbsp;留言时间：</td>
            <td bgcolor="#F5FFF4" style="height: 40px">&nbsp;
        <asp:Label ID="lblNowTime" runat="server"  ></asp:Label>
        </td>
          </tr>
          <tr>
            <td bgcolor="#E4FFE1" style="width: 177px; height: 37px;">&nbsp;</td>
            <td bgcolor="#F5FFF4" style="height: 37px">
                &nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="提 交" OnClick="btnSubmit_Click"  />
        <asp:Button ID="btnReset" runat="server" Text="重　置" OnClick="btnReset_Click"  /></td>
          </tr>
        </table></td>
		<td background="Image/index-1_04.jpg">
			<img src="Image/index-1_04.jpg" width="18" height="404" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="Image/index-1_05.jpg" width="658" height="22" alt=""></td>
	</tr>
</table>
        &nbsp;
        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
       
    </form>
</body>
</html>
