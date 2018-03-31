using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBook.Model;
using MyBookManager.BLL;

public partial class Order : System.Web.UI.Page
{
    User user;
    OrderDetailsManager odm = new OrderDetailsManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        //接受登录者的信息
        user = Session["LoginUser"] as User;
        //判断user是否为空
        if (user == null)
        {
            //如果为空跳到登录页
            Response.Write("<script>alert('登陆超时,请重新登陆');document.location='Login.aspx';</script>");
            return;
        }

        if (!IsPostBack)
        {
            //绑定数据
            BindGridView(user.LoginId);

        }
    }

    // 绑定GridView方法
    private void BindGridView(string id)
    {
        gvOrder.DataSource = odm.GetInfoByid(user.LoginId);
        gvOrder.DataBind();
    }

    // 为前台图片找到正确的路径

    public string GetUrl(string url)
    {
        return StringHandler.CoverUrl(url);
    }

    protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //取得要删除的书名
        string name = (gvOrder.Rows[e.RowIndex].FindControl("lblBookName") as Label).Text;
        //根据书名和登录者id删除信息
        int res1 = odm.DeleteInfo(name, user.LoginId);
        if (res1 > 0)
        {
            //删除成功后刷新列表
            BindGridView(user.LoginId);
        }
    }
    protected void gvCart_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lb = e.Row.FindControl("lnkbtnDelete") as LinkButton;
            lb.Attributes.Add("onclick", "return confirm('确定删除吗?')");
        }
    }
    protected void gvCart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //取得当前页索引
        gvOrder.PageIndex = e.NewPageIndex;
        //刷新列表
        BindGridView(user.LoginId);
    }
}
