using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News_DisplayDynamicNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            //读取传送的Id值
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string message = "";
            //根据不同的id值显示不同的提示信息
            switch (id)
            {
                case 1:
                    message = "学校新闻";
                    break;
                case 2:
                    message = "行业动态";
                    break;
                case 3:
                    message = "媒体报到";
                    break;
                case 4:
                    message = "企业荣誉";
                    break;
                case 5:
                    message = "焦点关注";
                    break;
                case 6:
                    message = "就业快报";
                    break;
                case 8:
                    message = "企业招聘";
                    break;
                case 9:
                    message = "学员作品";
                    break;
                case 10:
                    message = "学习员地";
                    break;
                case 11:
                    message = "学员感受";
                    break;
                default:
                    message = "新闻信息";
                    break;
            }
            lblMessage.Text = "欢迎访问<b>" + message + "</b>";
        }

    }
}