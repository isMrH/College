﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="WebValidates" Namespace="WebValidates" TagPrefix="cc1" %>

<%@ Register Src="LoginControl.ascx" TagName="LoginControl" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;
        <uc1:LoginControl id="LoginControl1" runat="server" OnLoad="LoginControl1_Load">
        </uc1:LoginControl>
    
    
    
    
    
    </form>
</body>
</html>
