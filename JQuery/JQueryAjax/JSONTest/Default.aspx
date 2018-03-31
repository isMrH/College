<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript" src ="scripts/jquery-1.3.1.js"></script>
    <script  type ="text/javascript" >
    $(function (){
        $('#send').click(function() {
            $.ajax({
                type: "GET",
                url: "Handler.ashx",
                dataType: "json",
                success: function(data) {
                    $('#res').empty();
                    var html = '';
                    $.each(data, function(commentIndex, comment) {
                        html += '<div>' + comment['SId'] + ':' + comment["SName"] + "</div>";
                    });
                    $('#res').html(html);
                }
                });
            });
        });

//        $(document).ready(function() {


//            $("#send").click(function() {

//                //                $.ajaxSetup({ cache: false });

//                $.getJSON('Handler.ashx', function(data) {

//                               $.getJSON("Handler.ashx", function(data) {                   
//                                    var dvalue = "";
//                                   $.each(data, function(index, item) {
//                                       dvalue += "sid:" + item.SId + ", sname: " + item.SName + "<br />";
//                                  });
//                                    $("#res").html(dvalue);
//                                });
//                            });
//            });
//        });  

    </script>
</head>
<body>
    <button id="send">获取</button>    
    <div id="res"></div>   
</body>
</html>
