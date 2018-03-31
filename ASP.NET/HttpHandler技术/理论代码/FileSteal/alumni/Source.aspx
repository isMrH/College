<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtMessage" runat="server" Style="z-index: 100; left: 66px; position: absolute;
            top: 71px"></asp:TextBox>
    
    
        <asp:Button ID="btnSubmit" runat="server" Style="z-index: 102; left: 153px; position: absolute;
            top: 120px" Text="提 交" PostBackUrl="~/Target.aspx" OnClick="btnSubmit_Click" />
            
            </div>
    </form>
</body>
</html>
