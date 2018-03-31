<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            $('span').bind("click", function(e) {
                var txt = $('#msg').html() + "<p>内层span元素被单击.</p>";
                $('#msg').html(txt);
                e.stopPropagation();
            });
            $('#content').bind("click", function() {
                var txt = $('#msg').html() + "<p>外层div元素被单击.</p>";
                $('#msg').html(txt);
            });
            $("body").bind("click", function() {
                var txt = $('#msg').html() + "<p>body元素被单击.</p>";
                $('#msg').html(txt);
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="content">
        外层div元素
        <span>内层span元素</span>
        外层div元素
    </div>
    <div id="msg"></div>
    </div>
    </form>
</body>
</html>
