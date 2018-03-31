<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoadInner.aspx.cs" Inherits="LoadTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type ="text/javascript" src ="../../script/jquery.js"></script>
     <script type ="text/javascript" >
         $(function() {
             $("#btnLoad").click(function(event) {
                 $("#load").load("inner.htm");                
             })
         })
      </script>
    <style type="text/css">
        #load
        {
            width: 373px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 201px; float :left">
        <input id="btnLoad" type="button" value="Load加载" />
    </div>
    <div id="load"></div>
    </form>
</body>
</html>
