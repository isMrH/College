<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <table width="450" border="1" cellpadding="2" cellspacing="0" bordercolor="#ABD48F" style=" height: 227px; position: static; background-color: aqua; border-right: #99cc66 thin solid; table-layout: fixed; border-top: #99cc66 thin solid; background-image: url(Image/moduleBg.gif); border-left: #99cc66 thin solid; border-bottom: #99cc66 thin solid; border-collapse: separate;">
            <caption style="font: caption; color: red; background-image: url(Image/thbg.gif); margin-top: 5px; position: absolute;">
                注册新用户</caption>
            <tr>
                <td width="150" >
                    用 户 名：</td>
                <td >
                    <asp:TextBox ID="txtName" runat="server" Style="z-index: 100; left: 141px; 
                        top: 34px"></asp:TextBox>              </td>
            </tr>
            <tr>
                <td >
                    密 &nbsp; &nbsp; &nbsp; 码：</td>
                <td >
                    <asp:TextBox ID="txtPsd" runat="server" Style="z-index: 100; left: 142px; 
                        top: 65px" TextMode="Password" Width="149px"></asp:TextBox>                </td>
            </tr>
            <tr>
                <td >
                    确认密码：</td>
                <td style="width: 154px">
                    <asp:TextBox ID="txtCfmPsd" runat="server" Style="z-index: 100; left: 142px; 
                        top: 96px" TextMode="Password" Width="149px"></asp:TextBox>                </td>
            </tr>
            <tr>
                <td >
                    电子邮件：</td>
                <td style="width: 154px">
                    <asp:TextBox ID="txtEmail" runat="server" Style="z-index: 100; left: 141px; 
                        top: 127px"></asp:TextBox>                </td>
            </tr>
            <tr>
                <td >
                    密码问题：</td>
                <td style="width: 154px">
                    <asp:TextBox ID="txtQuestion" runat="server" Style="z-index: 100; left: 140px;
                        top: 160px"></asp:TextBox>                </td>
            </tr>
            <tr>
                <td >
                    问题答案：</td>
                <td style="width: 154px">
                    <asp:TextBox ID="txtAnswer" runat="server" Style="z-index: 100; left: 141px; 
                        top: 191px"></asp:TextBox>                </td>
            </tr>
            <tr>
                <td>
                    个人风采：</td>
                <td style="width: 154px">
                    <asp:FileUpload ID="fulFile" runat="server" />
                    <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="上 传" />
                    <asp:Label ID="lblFile" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td >                </td>
                <td style="width: 154px; height: 30px;">
                    <asp:Button ID="btnSubmit" runat="server" Style="z-index: 100; left: 142px; 
                        top: 225px" Text="创建新用户" PostBackUrl="~/ValidatePage.aspx" />                </td>
            </tr>
      </table>
    <div>
        &nbsp;
        
    
    </div>
       
    </form>
</body>
</html>
