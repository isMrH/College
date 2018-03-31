// JavaScript Document
$(document).ready(function(e) {
	$("#Login #txtNum").each(function(){
	  var NumVal=$(this).val();
	  var PwdVal=$(this).val();
	  //判断文本框的值是否为空，有值的情况就隐藏提示语，没有值就显示
	  if(NumVal!=""){
	  	$(this).siblings("#txtNum").hide();
	  }else{
	  	$(this).siblings("#MesNum").show();
	  }
	  //聚焦型输入框验证 
	  $(this).focus(function(){
	  $(this).siblings("#MesNum").hide();
	  }).blur(function(){
	  var val=$(this).val();
	  if(val!=""){
	 	$(this).siblings("#MesNum").hide();
	  }else{
	  	$(this).siblings("#MesNum").show();
	  } 
	  });
  })
  
  $("#Login #txtPwd").each(function(){
	  var PwdVal=$(this).val();
	  //判断文本框的值是否为空，有值的情况就隐藏提示语，没有值就显示
	  if(PwdVal!=""){
	  	$(this).siblings("#MesPwd").hide();
	  }else{
	  	$(this).siblings("#MesPwd").show();
	  }
	  //聚焦型输入框验证 
	  $(this).focus(function(){
	  $(this).siblings("#MesPwd").hide();
	  }).blur(function(){
	  var val=$(this).val();
	  if(val!=""){
	 	$(this).siblings("#MesPwd").hide();
	  }else{
	  	$(this).siblings("#MesPwd").show();
	  } 
	  });
  })
});
//http://www.soso.io/article/18390.html

 