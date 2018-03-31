<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
    *
    {margin:0px auto;padding:0px;}
   .father
    {width:1024px;background-image: url(images/di-gwc.gif);background-repeat:no-repeat;}
    .STYLE3 {font-family: "宋体"; font-size: 12px; font-weight: bold;  margin-top:20px;}
    .contentstyle {font-family: "宋体";font-size: 12px;}
    #style4{ padding-left:23px; padding-top:5px;}
    a:link {color: #0000CC;}
    a:visited {color: #666666;}
    a:hover {color: #000000;}
    a:active {color: #000000;}
    #Layer1 {position:absolute;left:216px;top:93px;width:82px;height:31px;z-index:1;}
    #Layer2 {position:absolute;left:433px;top:98px;width:72px;height:25px;z-index:2;}
    #Layer3 {position:absolute;left:525px;top:92px;width:88px;height:31px;z-index:3;}
    #Layer4 {position:absolute;left:22px;top:189px;width:701px;height:27px;z-index:4;}

</style>
</head>
<body class="sub">
<div class="father">
<div id="Layer1"><a href="BookList.aspx"><img src="images/touming.gif" width="74" height="29" border="0" /></a></div>
<div id="Layer2"><a href="Login.aspx"><img src="images/touming.gif" width="74" height="29" border="0" /></a></div>
<div id="Layer3"><a href="#"><img src="images/touming.gif" width="74" height="29" border="0" /></a></div>
<form id="Form1" runat="server">
  <table width="100%" height="132">
    <tr>
      <td><table width="100%">
          <tr>
            <td width="32%">&nbsp;</td>
            <td width="37%"><div align="right" class="STYLE3">
                &nbsp;</div></td>
            <td width="18%"><span class="TitleColor STYLE3">&nbsp;</span></td>
            <td width="4%"><span class="TitleColor STYLE3"></span></td>
            <td width="9%"><span class="TitleColor STYLE3"></span></td>
          </tr>
        </table>
          <img src="images/touming.gif" width="45" height="29" longdesc="http://www.sohu.com" /><img src="images/touming.gif" alt="s" width="45" height="29" longdesc="http://www.sohu.com" /></td>
    </tr>
  </table>
  <table width="100%">
    <tr>
      <td style="height: 18px"><div class="STYLE3" id="__breadcrumb"><img src="images/touming.gif" width="27" height="10" />您现在的位置：<span id="uc_cat_spnPath">
          <asp:SiteMapPath
              ID="SiteMapPath1" runat="server">
          </asp:SiteMapPath>
          </span></div></td>
    </tr>
    <tr> 
        <td id="style4">
            <asp:Label ID="Label3" runat="server" Text="我的订单" Font-Bold="True" 
                Font-Italic="False" Font-Size="Large" ForeColor="#000099"></asp:Label>&nbsp;<asp:ValidationSummary
                ID="vsMessage" runat="server" ShowSummary="False" ShowMessageBox="True" />
        </td>
    </tr>
  </table>  
  <table width="100%" border="0" cellpadding="4" cellspacing="0" class="contentstyle" style="text-align: center">
    <tr style="vertical-align: top" class="HeaderColor">
      <td style="height: 364px">
        <asp:GridView runat="server" ID="gvOrder" Width="95%" AutoGenerateColumns="False" 
              AllowPaging="True" OnPageIndexChanging="gvCart_PageIndexChanging" 
               PageSize="5" 
               OnRowDeleting="gvCart_RowDeleting" 
              OnRowDataBound="gvCart_RowDataBound" >
            <Columns>
                <asp:TemplateField HeaderText="用户名">
                    <ItemTemplate>
                        <asp:Label ID="lblUser" runat="server" Text='<%# Eval("UserId") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="图示">
                    <ItemTemplate>
                        <img runat="server" alt="" id="imgbook" src='<%# GetUrl(Eval("BookImage").ToString()) %>' width="49" height="56"/>
                    </ItemTemplate>
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="书名">                   
                    <ItemTemplate>
                        <asp:Label ID="lblBookName" runat="server" Text='<%# Eval("BookName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="数量">
                    <EditItemTemplate>
                        &nbsp;<asp:TextBox ID="txtNumber" runat="server" Text='<%# Eval("BookCount") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="请输入数量" Text="*"
                           ></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="refNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="请输入非负整数" Text="*" ValidationExpression="^[0-9]*[1-9][0-9]*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("BookCount") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="单价">                    
                    <ItemTemplate>
                        <asp:Label ID="lblUnitPrice" runat="server" Text='<%# Bind("BookPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="总价">
                    <ItemTemplate>
                        <asp:Label ID="lblTotal" runat="server" Text='<%# Eval("Total") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="购买日期">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%# Eval("BuyDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnDelete" runat="server" CausesValidation="False" CommandName="Delete"
                            Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField Visible="False">                   
                    <ItemTemplate>
                        <asp:Label ID="lblBookId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>    
            </Columns>
            <EmptyDataTemplate>
                <asp:Label ID="Label2" runat="server" Text="空空如也！！！"></asp:Label>
            </EmptyDataTemplate>
        </asp:GridView>
      </td>
    </tr>
  </table>
  <table width="100%" class="contentstyle">
    <tr>
      <td width="68%" align="center">
        <a href="Cart.aspx">返回购物车</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="BookList.aspx">继续购书</a>
       </td> 
    </tr>
  </table>
</form>
</div>
</body>
</html>
