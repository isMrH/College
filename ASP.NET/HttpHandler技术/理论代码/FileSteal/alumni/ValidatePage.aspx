<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidatePage.aspx.cs" Inherits="ValidatePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        
        <div style="z-index: 101; left: 20px; width: 453px; position: absolute; top: 59px;
            height: 150px; font-weight: bold;">
            &nbsp;<asp:Label ID="lblName" runat="server" Style="z-index: 100; 
            top: 136px"></asp:Label>
            <asp:Label ID="lblPsd" runat="server" style="position: static"></asp:Label>
            <asp:Label ID="lblEmail" runat="server" Style="position: static"></asp:Label>
            <asp:Label ID="lblQuestion" runat="server" Style="position: static"></asp:Label>
            <asp:Label ID="lblAnswer" runat="server" Style="position: static"></asp:Label>
            </div>
        <table border="1" bordercolor="#abd48f" cellpadding="2" cellspacing="0" style="border-right: #99cc66 thin solid;
            table-layout: fixed; border-top: #99cc66 thin solid; background-image: url(Image/bg2.jpg);
            border-left: #99cc66 thin solid; width: 499px; border-bottom: #99cc66 thin solid;
            position: static; border-collapse: separate; height: 327px; background-color: aqua">
            <caption style="margin-top: 5px; background-image: url(Image/thbg.gif); font: caption;
                color: red; position: absolute">
                确认用户信息</caption>
            <tr>
                <td colspan="2" rowspan="7" style="height: 165px; width: 495px;">
                   
                   
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
                <td colspan="5" rowspan="0" style="width: 495px; height: 165px " >
                    <asp:Label ID="Label1" runat="server" Text="个人风采：" Font-Bold="True"></asp:Label>
                   
                   
            <asp:Image ID="imgPerson" runat="server" Width="150px" /></td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="height: 39px; width: 495px;">
                    <asp:Button ID="btnSubmit" runat="server" Style="position: static" Text="确  认" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnCancel" runat="server" PostBackUrl="~/ValidatePage.aspx" Style="position: static"
                        Text="返  回" OnClick="btnCancel_Click" />
                    &nbsp;
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
