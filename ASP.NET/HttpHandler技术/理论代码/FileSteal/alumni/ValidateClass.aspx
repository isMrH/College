<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidateClass.aspx.cs" Inherits="ValidateClass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" bordercolor="#abd48f" cellpadding="2" cellspacing="0" style="border-right: #99cc66 thin solid;
            table-layout: fixed; border-top: #99cc66 thin solid; background-image: url(Image/bg2.jpg);
            border-left: #99cc66 thin solid; width: 430px; border-bottom: #99cc66 thin solid;
            position: static; border-collapse: separate; height: 257px; background-color: aqua">
            <caption style="margin-top: 5px; background-image: url(Image/thbg.gif); font: caption;
                color: red; position: absolute">
                确认用户信息</caption>
            <tr>
                <td colspan="2" rowspan="7" style="height: 165px">
                    &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<div style="font-weight: bold; width: 332px;
                        position: static; height: 140px">
                        &nbsp;<asp:Label ID="lblName" runat="server" Style="z-index: 100; top: 136px"></asp:Label>
                        <asp:Label ID="lblEnter" runat="server" Style="position: static"></asp:Label>
                        <asp:Label ID="lblLeave" runat="server" Style="position: static"></asp:Label>
                        <asp:Label ID="lblSchool" runat="server" Style="position: static"></asp:Label>
                        <asp:Label ID="lblCreateTime" runat="server" Style="position: static"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td align="center" colspan="2" style="height: 39px">
                    <asp:Button ID="btnSubmit" runat="server" Style="position: static" Text="确  认" />
                    <asp:Button ID="btnCancel" runat="server" PostBackUrl="~/ValidatePage.aspx" Style="position: static"
                        Text="返  回" />
                    &nbsp;
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
