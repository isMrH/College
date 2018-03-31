<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserManager_UserLogin"%>

<%@ Register Src="../_Controls/UserLoginControl.ascx" TagName="UserLoginControl"
    TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>

    <body>
    <form id="form1" runat="server">
        &nbsp;<uc1:UserLoginControl ID="UserLoginControl1" runat="server" OnLoad="UserLoginControl1_Load" />
    </form>
</body>
</html>
