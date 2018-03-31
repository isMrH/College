<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="My97DatePicker/skin/WdatePicker.css" rel="stylesheet" type="text/css" />
</head>

<script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript">
    function CheckFile(file) {
        var filename = file.value;
        filename = filename.toLowerCase().substr(filename.lastIndexOf("."));
        if (filename != ".jpg") {
            alert("只能上传JPG格式的文件");
            form1.reset();
        }
    }
</script>
<body>
    <form id="form1" runat="server">
    <div>
    <input class="Wdate" id="htStart" type="text" onfocus="new WdatePicker(this,'%Y年%M月%D日',false)" />
    <input class="Wdate" id="Ac" type="text" onfocus="new WdatePicker(this,'%h:%m:%s',true,'whyGreen')" />
    <input class="Wdate" id="Text1" type="text" onfocus="new WdatePicker(this,'%Y年%M月%D日 %h时%m分%s秒',true)" />

        <br />
        <br />
    </div>
    <div>
        <asp:FileUpload ID="fulFile" runat="server" onchange="CheckFile(this);"/>
        <asp:Button ID="btnUpload" runat="server" Height="22px" 
            onclick="btnUpload_Click" Text="上传" Width="87px" />
        <br />
        <asp:Label ID="lblMes" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
