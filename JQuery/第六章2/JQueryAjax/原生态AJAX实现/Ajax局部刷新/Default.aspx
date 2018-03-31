<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head  runat ="server" >
    <title>无标题页</title>
   
   <style >
       #iddd{margin:0 auto}
       </style>
    <script type ="text/javascript" >
        var xmlhttp;
        function createHTTP()
        {
        //需要针对IE和其他类型的浏览器建立这个对象的不同方式写不同的代码
            if (window.ActiveXObject) {
                //针对IE6，IE5.5，IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            else if (window.XMLHttpRequest) {
                //针对FireFox，Mozillar，Opera，Safari，IE7，IE8
                xmlhttp = new XMLHttpRequest();
            }           
          
        }
     function getData()
     {
       var city=document.getElementById ("txt").value;
          //创建异步对象
          createHTTP();    
          //状态变化与事件关联
           xmlhttp.onreadystatechange=statechange;
           //创建一个请求，并准备向服务器端发送（加载要链接的页面）
           xmlhttp.open("get","Handler.ashx?city="+city,true);
           //发出HTTP请求
           xmlhttp.send();
       
     }
     function statechange()
     {
      //判断是否是完成状态
         if(xmlhttp.readyState==4)
         {
            //判断是否执行成功
            if(xmlhttp.status==200) {
              // alert (xmlhttp.responseText)
            //将返回数据作为参数，传递给填充方法
                FillData(xmlhttp.responseText);
            }
            else
            {
              document.write ("异步调用失败"+xmlhttp.status);
            }
          }        
     }
     function FillData(strcity)
     {
        document.getElementById ("DropDownList1").options.length=0;
        var indexofcity;
        var city;
        //切割传递来的字符串
        while(strcity.length>0)
        {
        //判断是否是最后一个字符串
            indexofcity=strcity.indexOf(",");
            
            if(indexofcity>0)
            {
               city=strcity.substring(0,indexofcity);
               strcity=strcity.substring(indexofcity+1);
               //填充下拉列表
               document.getElementById ("DropDownList1").options.add(new Option(city,city));
               
            }
            else
            {
               lastcity=strcity.substring(0,2);
               document.getElementById ("DropDownList1").options .add(new Option(lastcity,lastcity));
               break;
            }
        }
     }
    </script>
     <style type ="text/css" >      
      .table1{border-collapse:collapse}
      .table1 td{border:1px solid skyblue} 
  
    </style>
</head>
<body>
<center >
   <div id='iddd'>
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
      <table class="table1" > 
            <tr >  
                <td colspan="2" >
                  Ajax实现局部刷新</td>
               
            </tr>
            <tr >
                <td  >
                    填写城市名称:</td>
                <td  >
                    &nbsp;
                    <input id="txt"  type="text" />
                </td>
            </tr>
            <tr >
                <td >
                </td>
                <td >                   
                    <input id="Button1" 
                        type="button" value="查询" onclick ="getData()" />
                </td>
            </tr>
            <tr >
                <td  >
                    选择区域列表</td>
                <td  >
                    &nbsp;
                    <select id="DropDownList1"> 
                        <option selected="selected"></option>
                    </select>
                </td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
