<%@ page language="java" pageEncoding="UTF-8"%>
<%
String likes[]=request.getParameterValues("like");
if(likes != null && likes.length!=0){
       for(int i=0;i<likes.length;i++){
      out.println(likes[i]);
   }
}
%>

