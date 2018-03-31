$(function() {
    //查重
    $("#name").bind("blur", function() {
        $.get("register.ashx", $("#name").serialize(), function(msg) {
            if (msg == 1) {
                $("#infoname").html("<font color='green'>恭喜您，用户名可以使用！</font>");
            } else {
                $("#infoname").html("<font color='red'>对不起，用户名已经被注册！</font>");
            }


        }, "text");
    });


    //菜单栏
    $('li.col_1').click(function() {   // 获取所有的父行
        $(this).toggleClass("selected1")   // 添加/删除高亮
			   .siblings('.ch_' + this.id).toggle();  // 隐藏/显示所有的子行
    });
    /* $(function() {
    $('li.col_1').click(function() {   // 获取所谓的父行
    $(this).toggleClass("selected")   // 添加/删除高亮
    .siblings(this.id + '_1').toggle();  // 隐藏/显示所谓的子行
    });
    $('li.col_1').click(function() {
    $(this).addClass("selected");
    });

    })*/

    //选项卡
    var $div_li = $("div.col_r ul li");
    $div_li.click(function() {
        $(this).addClass("selected")    //当前 li 元素高亮  
               .siblings().removeClass("selected");    //去掉其他同辈 li 元素的高亮
        var index = $div_li.index(this);

        $("div.Content>div").eq(index).show().siblings().hide();
    }).hover(function() {               //光标划过
        $(this).addClass("hover");
    }, function() {
        $(this).removeClass("hover");
    });

    //日历
    /* var options = {
    showButtonPanel: true,
    onSelect: function(dateText, inst) {
    alert("您选择的日期是：" + dateText);
    }
    };*/
    $("#actualDate").datepicker();
    $("#actualDate2").datepicker();
})