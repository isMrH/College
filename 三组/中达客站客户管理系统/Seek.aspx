<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Seek.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/Seek.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form" runat="server">
    <div class="father">
        <div class="center">
            <div>
                <asp:Label ID="Label1" runat="server" Text="请输入您的账号："></asp:Label>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="下一步" />
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="您的验证问题为："></asp:Label>
                <asp:Label ID="lblValidate" runat="server"></asp:Label>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="请输入您的答案："></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="下一步" Height="26px" />
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="请输入新的密码："></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="请重新确认密码："></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="确认修改" Width="65px" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
