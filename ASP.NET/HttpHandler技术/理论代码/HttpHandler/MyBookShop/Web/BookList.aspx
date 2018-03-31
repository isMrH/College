<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="BookList.aspx.cs" Inherits="BookList" Title="图书列表页" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<link href="Css/css.css" rel="stylesheet"  />
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">


<div class="STYLE4">
  <div id="divOrder">
    <div style="text-align:left;margin:20px 0 20px 0;">排序方式：
    <asp:Button ID="btnDate" runat="server" Text="出版日期" OnClick="btnDate_Click" CssClass="anniu"/>       
       | <asp:Button ID="btnPrice" runat="server" Text="价格" OnClick="btnPrice_Click" CssClass="anniu"/></div>
  </div>
</div>

<div class="STYLE4" >
    <asp:DataList ID="dl_Books" runat="server" OnSelectedIndexChanged="dl_Books_SelectedIndexChanged">
        <ItemTemplate>
            <table>
                <tr>
                  <td rowspan="2"><a 
                                    onclick="window.location='BookDetail.aspx?bid=<%# DataBinder.Eval(Container.DataItem,"Id")%>'"><img 
                                    id="ctl00_cphContent_dl_Books_ctl01_img_Book" 
                                    style="CURSOR: hand" height="121" alt="<%# Eval("Title") %>" 
                                    src="<%# GetUrl(Eval("ISBN").ToString()) %>" width="95" /></a> </td>
                  <td style="FONT-SIZE: small; COLOR: red" width="650"><span 
                                    id="ctl00_cphContent_dl_Books_ctl01_lbl_BookName"><a href="BookDetail.aspx?bid=<%# DataBinder.Eval(Container.DataItem,"Id")%>" name="link_prd_name" target="_blank" class="STYLE5" id="link_prd_name" onclick="return s('9317290','01.54.06.06','',this.href)"><%# DataBinder.Eval(Container.DataItem,"Title") %></a></span> </td>
                </tr>
                <tr>
                  <td style="FONT-SIZE: small" align="left"><span 
                                    id="ctl00_cphContent_dl_Books_ctl01_lbl_Author"><%# DataBinder.Eval(Container.DataItem,"Author") %></span><br />
                    <br />
                    <span id="ctl00_cphContent_dl_Books_ctl01_lbl_Content"><%# GetCut(DataBinder.Eval(Container.DataItem,"ContentDescription").ToString(),150) %></span> </td>
                </tr>
                <tr>
                  <td style="FONT-SIZE: small;" align="right" colspan="2"><span 
                                    id="ctl00_cphContent_dl_Books_ctl01_lbl_Price"><%# DataBinder.Eval(Container.DataItem,"UnitPrice") %></span> </td>
                </tr>
            </table>
        </ItemTemplate>
        <SeparatorTemplate>
        <hr />
        </SeparatorTemplate>
    </asp:DataList>&nbsp;
</div>
<div class="STYLE4" style="text-align:left;margin:20px 0 20px 0;">
<asp:Label runat="server" ID="lblCurrentPage"></asp:Label>

<asp:Button ID="btnPrev" runat="server" Text="上一页" OnClick="btnPrev_Click" CssClass="anniu"/> 
<asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" CssClass="anniu"/> 

</div>
    </form>
</body>
</html>

