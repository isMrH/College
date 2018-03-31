$(document).ready(function() {
    //手动重置页面元素
    $("#reset").click(function() {
        $("*").removeAttr("style");
        $("div[class=none]").css({ "display": "none" });
    });
    //判断是否自动重置
    $("input[type=button]").click(function() {
        if ($("#isreset").is(":checked")) {
            $("#reset").click();
        }
    });
    //给id为mover的元素添加动画.
    function animateIt() {
        $("#mover").slideToggle("slow", animateIt);
    }
    animateIt();


    //btn1  改变id为one的元素的背景色
    $("#btn1").click(function() {
        $("#one").css("background", "#bbffaa");
    });

    //btn2 改变id为mini的所有元素的背景色
    $("#btn2").click(function() {
        $(".mini").css("background", "#bbffaa");
    });

    //btn3 改变元素名是div的背景色
    $("#btn3").click(function() {
        $("div").css("background", "#bbffaa");
    });

    //btn4 改变所有元素的背景色
    $("#btn4").click(function() {
        $("*").css("background", "#bbffaa");
    });

    //btn5 改变所有的span元素和id为two的背景色
    $("#btn5").click(function() {
        $("span,#two").css("background", "#bbffaa");
    });
})