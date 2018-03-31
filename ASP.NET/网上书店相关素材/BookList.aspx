<%@ Page Language="C#" AutoEventWireup="true"   MasterPageFile="~/MasterPage.master" CodeFile="BookList.aspx.cs" Inherits="BookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    
    
      <DIV class=STYLE4>
      <DIV id=divOrder>
      <DIV style="MARGIN: 0px 0px; TEXT-ALIGN: left">排序方式： <INPUT class=anniu id=ctl00_cphContent_btnDate style="BORDER-RIGHT: seagreen 1px solid; BORDER-TOP: seagreen 1px solid; FONT-WEIGHT: normal; FONT-SIZE: 12px; BORDER-LEFT: seagreen 1px solid; WIDTH: 57px; COLOR: black; BORDER-BOTTOM: seagreen 1px solid; HEIGHT: 16px; BACKGROUND-COLOR: #c0ffc0" type=submit value=出版日期 name=ctl00$cphContent$btnDate> 
      | <INPUT class=anniu id=ctl00_cphContent_btnPrice style="BORDER-RIGHT: seagreen 1px solid; BORDER-TOP: seagreen 1px solid; FONT-WEIGHT: normal; FONT-SIZE: 12px; BORDER-LEFT: seagreen 1px solid; WIDTH: 57px; COLOR: black; BORDER-BOTTOM: seagreen 1px solid; HEIGHT: 16px; BACKGROUND-COLOR: #c0ffc0" type=submit value=价格 name=ctl00$cphContent$btnPrice></DIV></DIV></DIV>
      <DIV class=STYLE4>
      <TABLE id=ctl00_cphContent_dl_Books style="BORDER-COLLAPSE: collapse" 
      cellSpacing=0 border=0>
        <TBODY>
        <TR>
          <TD>
            <TABLE>
              <TBODY>
              <TR>
                <TD rowSpan=2><A 
                  onclick="window.location='BookDetail.aspx?bid=4939'"><IMG 
                  src="image/9787115145543.jpg" 
                  alt="C++ Primer中文版(第4版）（一本久负盛名的C++经典教程）"  width=95 height=121 
                  id=ctl00_cphContent_dl_Books_ctl01_imgBook 
                  style="CURSOR: hand"></A> </TD>
                <TD style="FONT-SIZE: small; COLOR: red" width=650><SPAN 
                  id=ctl00_cphContent_dl_Books_ctl01_lblBookName><A class=STYLE5 
                  id=link_prd_name 
                  href="BookDetail.aspx?bid=4939" 
                  target=_blank name=link_prd_name>C++ 
                  Primer中文版(第4版）（一本久负盛名的C++经典教程）</A></SPAN> </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=left><SPAN 
                  id=ctl00_cphContent_dl_Books_ctl01_lblAuthor>（美）Stanley B. 
                  Lippman Barbara E. Moo Josée LaJoie 著，李师贤 
                  等译</SPAN><BR><BR><SPAN 
                  id=ctl00_cphContent_dl_Books_ctl01_lblContent>本书是久负盛名的C++经典教程，其内容是C++大师Stanley 
                  B. Lippman丰富的实践经验和C++标准委员会原负责人Josée 
                  Lajoie对C++标准深入理解的完美结合，已经帮助全球无数程序员学会了C++。本版对前一版进行了彻底的修订，内容经过了重新组织，更加入了C++先驱Barba...</SPAN> 
                </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=right colSpan=2><SPAN 
                  id=ctl00_cphContent_dl_Books_ctl01_lblPrice>99.0000</SPAN> 
              </TD></TR></TBODY></TABLE></TD></TR>
        <TR>
          <TD>
            <HR>
          </TD></TR>
        <TR>
          <TD>
            <TABLE>
              <TBODY>
              <TR>
                <TD rowSpan=2><A 
                  onclick="window.location='BookDetail.aspx?bid=4942'"><IMG 
                  id=IMG1 
                  style="CURSOR: hand" height=121 alt="C++ Primer 习题解答（第4版）" 
                  src="image\9787115155108.jpg" 
                  width=95></A> </TD>
                <TD style="FONT-SIZE: small; COLOR: red" width=650><SPAN 
                  id=SPAN1><A class=STYLE5 
                  id=A1 
                  href="BookDetail.aspx?bid=4942" 
                  target=_blank name=link_prd_name>C++ Primer 
                  习题解答（第4版）</A></SPAN> </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=left><SPAN 
                  id=SPAN2>蒋爱军，李师贤，梅晓勇 
                  著</SPAN><BR><BR><SPAN 
                  id=SPAN3>C++ 
                  Primer(第4版)是C++大师Stanley B. Lippman丰富的实践经验和C++标准委员会原负责人Josée 
                  Lajoie对C++标准深入理解的完美结合，更加入了C++先驱Barbara E. 
                  Moo在C++教学方面的真知灼见，是初学者的最佳C++指南，而且对于中高级程序员，...</SPAN> </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=right colSpan=2><SPAN 
                  id=SPAN4>45.0000</SPAN> 
              </TD></TR></TBODY></TABLE></TD></TR>
        <TR>
          <TD>
            <HR>
          </TD></TR>
        <TR>
          <TD>
            <TABLE>
              <TBODY>
              <TR>
                <TD rowSpan=2><A 
                  onclick="window.location='BookDetail.aspx?bid=4943'"><IMG 
                  id=IMG2 
                  style="CURSOR: hand" height=121 
                  alt="Effective C# 中文版改善C#程序的50种方法" 
                  src="image\978711515888.jpg" 
                  width=95></A> </TD>
                <TD style="FONT-SIZE: small; COLOR: red" width=650><SPAN 
                  id=SPAN5><A class=STYLE5 
                  id=A2 
                  href="BookDetail.aspx?bid=4943" 
                  target=_blank name=link_prd_name>Effective C# 
                  中文版改善C#程序的50种方法</A></SPAN> </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=left><SPAN 
                  id=SPAN6>（美）瓦格纳 著，李建忠 
                  译</SPAN><BR><BR><SPAN 
                  id=SPAN7>本书围绕一些关于C#和.NET的重要主题，包括C#语言元素、.NET资源管理、使用C#表达设计、创建二进制组件和使用框架等，讲述了最常见的50个问题的解决方案，为程序员提供了改善C#和.NET程序的方法。本书通过将每个条款构建在之前的条款之上，并合理地利用之前的条款，来让读者最大限度地学习书中的...</SPAN> 
                </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=right colSpan=2><SPAN 
                  id=SPAN8>49.0000</SPAN> 
              </TD></TR></TBODY></TABLE></TD></TR>
        <TR>
          <TD>
            <HR>
          </TD></TR>
        <TR>
          <TD>
            <TABLE>
              <TBODY>
              <TR>
                <TD rowSpan=2><A 
                  onclick="window.location='BookDetail.aspx?bid=4944'"><IMG 
                  id=IMG3 
                  style="CURSOR: hand" height=121 alt=C程序设计语言（第2版·新版） 
                  src="image\9787111128069.jpg" 
                  width=95></A> </TD>
                <TD style="FONT-SIZE: small; COLOR: red" width=650><SPAN 
                  id=SPAN9><A class=STYLE5 
                  id=A3 
                  href="BookDetail.aspx?bid=4944" 
                  target=_blank name=link_prd_name>C程序设计语言（第2版·新版）</A></SPAN> 
              </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=left><SPAN 
                  id=SPAN10>（美）克尼汉，（美）里奇 
                  著，徐宝文，李志 译</SPAN><BR><BR><SPAN 
                  id=SPAN11>本书是由C语言的设计者Brian 
                  W.Kernighan和Dennis 
                  M.Ritchie编写的一部介绍标准C语言及其程序设计方法的权威性经典著作。全面、系统地讲述了C语言的各个特性及程序设计的基本方法，包括基本概念，类型和表达式、控制流、函数与程序结构、指针与数组、结构、输入与输出、UNIX系...</SPAN> 
                </TD></TR>
              <TR>
                <TD style="FONT-SIZE: small" align=right colSpan=2><SPAN 
                  id=SPAN12>30.0000</SPAN> 
              </TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>&nbsp; </DIV>
      <DIV class=STYLE4 style="MARGIN: 20px 0px; TEXT-ALIGN: left"><SPAN 
      id=ctl00_cphContent_lblCurrentPage>第 1 页 共 270 页</SPAN> <INPUT class=anniu id=ctl00_cphContent_btnPrev style="BORDER-RIGHT: seagreen 1px solid; BORDER-TOP: seagreen 1px solid; FONT-WEIGHT: normal; FONT-SIZE: 12px; BORDER-LEFT: seagreen 1px solid; WIDTH: 57px; COLOR: black; BORDER-BOTTOM: seagreen 1px solid; HEIGHT: 16px; BACKGROUND-COLOR: #c0ffc0" disabled type=submit value=上一页 name=ctl00$cphContent$btnPrev> 
<INPUT class=anniu id=ctl00_cphContent_btnNext style="BORDER-RIGHT: seagreen 1px solid; BORDER-TOP: seagreen 1px solid; FONT-WEIGHT: normal; FONT-SIZE: 12px; BORDER-LEFT: seagreen 1px solid; WIDTH: 57px; COLOR: black; BORDER-BOTTOM: seagreen 1px solid; HEIGHT: 16px; BACKGROUND-COLOR: #c0ffc0" type=submit value=下一页 name=ctl00$cphContent$btnNext> 
      </DIV>

</asp:Content>
