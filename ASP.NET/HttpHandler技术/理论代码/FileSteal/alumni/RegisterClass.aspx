<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterClass.aspx.cs" Inherits="RegisterClass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" bordercolor="#abd48f" cellpadding="2" cellspacing="0" style="border-right: #99cc66 thin solid;
            table-layout: fixed; border-top: #99cc66 thin solid; background-image: url(Image/moduleBg.gif);
            border-left: #99cc66 thin solid; width: 348px; border-bottom: #99cc66 thin solid;
            position: static; border-collapse: separate; height: 227px; background-color: aqua; text-align: right;"
            width="317">
            <caption style="margin-top: 5px; background-image: url(Image/thbg.gif); font: caption;
                color: red; position: absolute">
                注册新班级</caption>
            <tr>
                <td style="width: 93px" align="right">
                    班 级 名：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtName" runat="server" Style="z-index: 100; left: 141px; top: 34px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 93px" align="right">
                    入学年月：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtEnter" runat="server" Style="z-index: 100; left: 142px; top: 65px" Width="149px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 93px" align="right">
                    毕业年月：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtLeave" runat="server" Style="z-index: 100; left: 142px; top: 96px" Width="149px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 93px" align="right">
                    所在学校：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtSchool" runat="server" Style="z-index: 100; left: 141px; top: 127px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 93px" align="right">
                    创建时间：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtCreateTime" runat="server" Style="z-index: 100; left: 140px;
                        top: 160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 93px">
                </td>
                <td style="width: 100px; height: 30px">
                    <asp:Button ID="btnSubmit" runat="server" PostBackUrl="~/ValidateClass.aspx"
                        Style="z-index: 100; left: 142px; top: 225px" Text="创建新班级" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
