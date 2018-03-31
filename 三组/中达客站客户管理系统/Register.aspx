<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员注册</title>
    <link href="CSS/Register.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
        <div class="item"><i>*</i> 用户名：</div>
        <asp:TextBox ID="txtUserName" runat="server" class="inputbox"></asp:TextBox>                  
        <div id="infoUserName" class="box_info">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="请输入用户名！" ControlToValidate="txtUserName"></asp:RequiredFieldValidator></div>
        
        <div class="item"><i>*</i> 密码：</div>
        <asp:TextBox ID="txtPwd" runat="server" class="inputbox" TextMode="Password"></asp:TextBox>                  
        <div id="infoPwd" class="box_info">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="请确认电话号码！" ControlToValidate="txtPwd"></asp:RequiredFieldValidator></div>
        
        <div class="item"><i>*</i> 确认密码：</div>
        <asp:TextBox ID="txtRePwd" runat="server" class="inputbox" TextMode="Password"></asp:TextBox>                  
        <div id="infoRePwd" class="box_info">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="请输入密码！" ControlToValidate="txtRePwd" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txtPwd" ControlToValidate="txtRePwd" ErrorMessage="两次密码输入不同！"></asp:CompareValidator>
        </div>
        
        <div class="item"><i>*</i>电话号码：</div>
        <asp:TextBox ID="txtTel" runat="server" class="inputbox"></asp:TextBox>                  
        <div id="infoTel" class="box_info">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ErrorMessage="请输入电话号码！" ControlToValidate="txtTel" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtTel" ErrorMessage="电话号码格式错误！" 
                ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"></asp:RegularExpressionValidator>
        </div>
        
        <div class="item"><i>*</i> E-mail：</div>
        <asp:TextBox ID="txtEmail" runat="server" class="inputbox"></asp:TextBox>                  
        <div id="infoEmail" class="box_info">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="请输入E-mail！" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="邮箱格式错误！" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div class="btnAdd">
            <asp:Button ID="btnAdd" runat="server" Text="我要注册" Font-Size="14px" 
                Height="30px" Width="70px" /></div>
    </div>
    </form>
</body>
</html>
