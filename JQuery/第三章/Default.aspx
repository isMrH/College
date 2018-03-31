<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .myclass
        {
            color: Red;
        }
        .high
        {
            font-weight: bold;
            color: Blue;
        }
        .another
        {
            font-style: italic;
            color: Red;
        }
    </style>

    <script src="jquery-1.4.1-vsdoc.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#btnInput").click(function() {
                var p_class = $("p").attr("class");
                $("p").append(p_class);
            });
            $("#btnAttr").click(function() {
                $("p").attr("class", "high");
            });
            $("#btnAdd").click(function() {
                $("p").addClass("another");
            });
            $("#btnRemoveAll").click(function() {
                $("p").removeClass();
            });
            $("#btnRemove").click(function() {
                $("p").removeClass("myclass");
            });
            $("#btnToggle").click(function() {
                $("p").toggleClass("another");
            });
            $("ul li").click(function() {
                $(this).clone().appendTo("ul");
            });
            // $("ul li").click(function(){
            //    $(this).clone(ture).appendTo("ul");
            // });
            $("#btnWrap").click(function() {
                $("p").wrap("<b></b>")
                //$("p").wrapAll("<b></b>")
                //$("p").wrapInner("<b></b>")
            });
            $("#btnTit").click(function() {
                var p_txt = $("p").attr("title");
                //删除属性
                //$("p").removeAttr("title");
            });

        })
    
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <input type="button" id="btnInput" value="输出class类" />
    <input type="button" id="btnAttr" value="设置class类" />
    <input type="button" id="btnAdd" value="追加class类" />
    <input type="button" id="btnRemoveAll" value="删除全部class类" />
    <input type="button" id="btnRemove" value="删除指定class类" />
    <input type="button" id="btnToggle" value="重复切换class类" />
    <input type="button" id="btnWrap" value="包裹节点" />
    <input type="button" id="btnTit" value="获取属性" />
    <div>
        <p class="myclass" title="喜欢">
            你最喜欢的水果是？</p>
        <ul>
            <li>苹果</li>
            <li>橘子</li>
            <li>菠萝</li>
        </ul>
    </div>
    </form>
</body>
</html>
