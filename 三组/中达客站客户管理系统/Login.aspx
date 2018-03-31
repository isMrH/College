<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>中达货站客户结算管理系统</title>
    <link href="CSS/Login.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
    <div id="father">
        <div id="login">
            <div id="text"><b>用户登陆:</b></div>
            <div class="name1">
                <asp:Label ID="lblName" runat="server" Text="账号:"></asp:Label></div>
            <div class="name2">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="账号不能为空" 
                    ValidationGroup="login"></asp:RequiredFieldValidator>
            </div>
            <div class="pwd">
                <asp:Label ID="lblPwd" runat="server" Text="密码:"></asp:Label></div>
            <div>
                <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPwd" ErrorMessage="密码不能为空" ValidationGroup="login"></asp:RequiredFieldValidator>
            </div>
            <div id="forget">
                <asp:LinkButton ID="lkbtnforget" runat="server" onclick="lkbtnforget_Click" 
                    ValidationGroup="for">忘记密码</asp:LinkButton></div>
            <div id="forget1">
                <asp:LinkButton ID="lkbtnLogin" runat="server" ValidationGroup="for">注册账号</asp:LinkButton></div>
            <div id="btn">
                <asp:Button ID="btnLogin" runat="server" Text="登陆" BackColor="#ffffff" 
                    BorderStyle="None" Height="25px" Width="55px" ValidationGroup="login" /></div>
                
            <div id="btn1"> 
              <asp:Button ID="btnExit" runat="server" Text="退出" BackColor="#ffffff" 
                    BorderStyle="None" Height="25px" Width="55px" /></div>
       </div>
    </div>
</form>
</body>
</html>
