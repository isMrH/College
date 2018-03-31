<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
*
{
	margin:0px;
	padding:0px;
	list-style:none;
}
#lblMessageBoard
{
	text-align:center;
	margin:10px auto;
}
#Label2
{
	margin-bottom:10px; 
	line-height:110px;
	height:110px;
}
#Label1
{
	margin-bottom:10px;
}
#txtTitle
{
	margin-bottom:10px;
}
#form1
{
	text-align:center;
	margin:0px auto;
}
#lblMes,#lblTime,#lblMesTime
{
	text-align:left;
}

</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblMessageBoard" runat="server" Text="简易留言板" Width="450px"></asp:Label>
        <br />
       
        <asp:Label ID="Label1" runat="server" Text="标题:" Width="50px"></asp:Label>
             
       
        <asp:TextBox ID="txtTitle" runat="server" Width="400px" ></asp:TextBox>
       
        <br />
        <asp:Label ID="Label2" runat="server"  Text="内容:"  Width="50px" Height="110px"></asp:Label>
        <asp:TextBox ID="txtMessage" runat="server" Height="110px" TextMode="MultiLine" 
            Width="400px" ></asp:TextBox>
        
    
    </div>
    <asp:Label ID="lblMesTime" runat="server" Text="留言时间：" Width="90px"></asp:Label>
    <asp:Label ID="lblTime" runat="server" Width="360px"></asp:Label>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="留言" onclick="btnSubmit_Click" />
     
        <asp:Button ID="btnRe" runat="server" Text="重置" onclick="btnRe_Click" />
     
    </p>
    <asp:Label ID="lblMes" runat="server" Width="450px"></asp:Label>
    </form>
</body>
</html>
