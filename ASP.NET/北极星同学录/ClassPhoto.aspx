<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassPhoto.aspx.cs" Inherits="ClassPhoto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        *
        {
        	margin:0px;
        	padding:0px;
        }
        #Wapper
        {
        	width:1000px;
        	height:700px;
        	
        	margin:0px auto;
        }
        .Title
        {
        	width:1000px;
        	border:1px solid green;
        }
        #Main
        {
        	margin-top:20px;
        	width:1000px;
        	height:600px;
        	border:1px solid green;
        }
        .m_title
        {
        	margin:0px auto;
        	padding:10px;
        	width:950px;
        	font-size:12px;
        	color:Gray;
        	border-bottom:1px solid #CCC;
        }
        .Photo
        {
        	margin:10px auto;
        	width:930px
        }
        .Photo img
        {        	
        	width:300px;
            height:250px;
        }
        .Photo ul
        {
        	float:left;
        	list-style:none;
        	width:300px;
        	margin-right:5px;
        	margin-bottom:5px;
        }
        .Photo ul li
        {
        	width:300px;
        	text-align:center;
        	font-size:12px;
        }
    </style>
</head>
<body>
    <div id="Wapper">
    <form id="form1" runat="server">
        <div class="Title">
            <img src="photo/watermark.jpg" />
        </div>
        <div id="Main">
            <div class="m_title"><p>班级相册</p></div>
            <div class="Photo">
                <ul>
                    <li><img src="photo/1.JPG" /></li>
                    <li>个人风采</li>
                </ul>
                <ul>
                    <li><img src="photo/2.JPG" /></li>
                    <li>草原晨色</li>
                </ul>
                <ul>
                    <li><img src="photo/10.jpg" /></li>
                    <li>竹色青青</li>
                </ul>
                <ul>
                    <li><img src="photo/9.jpg" /></li>
                    <li>电闪雷鸣</li>
                </ul>
                <ul>
                    <li><img src="photo/4.jpg" /></li>
                    <li>轻松校园</li>
                </ul>
                <ul>
                    <li><img src="photo/7.jpg" /></li>
                    <li>山清水秀</li>
                </ul>             
                               
                
            </div>
        </div>
    </form>
    </div>
</body>
</html>
