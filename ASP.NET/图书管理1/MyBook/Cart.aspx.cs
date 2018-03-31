using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using MyBookManager.BLL;
using MyBook.Model;


public partial class Cart : System.Web.UI.Page
{
    CartsManager cm = new CartsManager();
    Users user;
    protected void Page_Load(object sender, EventArgs e)
    {
        //接受登录者的信息
        user = Session["us"] as Users;
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
            BindGridView(user.username);
           
        }
    }

    // 结算
   
    protected void imgb_Salary_Click(object sender, ImageClickEventArgs e)
    {
        //根据登录者的id将购物车里的信息取出来
        List<Carts> listcarts = cm.GetAllInfo(user.username);
        int count = listcarts.Count;
        if (count == 0)
        {
            //如果该用户购物车为空，则提醒用户添加商品
            Response.Write("<script>alert('您的购物车为空,请加入图书!');document.location='BookList.aspx';</script>");
            return;
        }
        //实例化银行serice类
        MyBank.Service service = new MyBank.Service();
        //调用方法
        int res = service.SelectAccount(user.username, user.userpassword);
        //判断用户名和密码是否输入正确
        if (res > 0)
        {
            int res1 = service.SelectStatus(user.username);
            //判断该账户的状态
            if (res1 == 1)
            {
                int res2 = service.SelectMoney(Convert.ToDouble(ltrSalary.Text), user.username);
                //查看余额
                if (res2 <= 0)
                {
                    int res3 = service.UpdateMoney(user.username, Convert.ToDouble(ltrSalary.Text));
                    //支付账单，
                    if (res3 > 0)
                    {
                        //支付成功
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('支付成功！！')</script>");
                        //将购物车的信息删除
                        cm.DeleteInfo(user.username);
                        //刷新列表
                        BindGridView(user.username);
                    }
                    else
                    {

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('支付失败！！')</script>");
                    }
                }
                else
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('余额不足！！')</script>");
                }
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该账户暂时不能支付！')</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('账号或密码输入错误！！！')</script>");
        }
    }

    // 绑定GridView方法
    private void BindGridView(string id)
    {
        gvCart.DataSource = cm.GetAllInfo(id);
        gvCart.DataBind();
        //调用计算总价的函数
        TotalPrice();
    }

    // 为前台图片找到正确的路径
   
    public string GetUrl(string url)
    {
        return StringHandler.CoverUrl(url);
    }

    // GridView编辑按钮处理事件
   
    protected void gvCart_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //将该行状态变为编辑行
        gvCart.EditIndex=e.NewEditIndex;
        //刷新列表
        BindGridView(user.username);
    }

    // GridView分页处理事件
    
    protected void gvCart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvCart.PageIndex = e.NewPageIndex;
        BindGridView(user.username);
    }

    // GridView删除按钮处理事件
    
    protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string name =(gvCart.Rows[e.RowIndex].FindControl("lblBookName") as Label).Text;
        int res1 = cm.DeleteById(name, user.username);
        if (res1 > 0)
        {
            BindGridView(user.username);
        }
    }

   // GridView取消按钮处理事件
    
    protected void gvCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvCart.EditIndex = -1;
        BindGridView(user.username);
    }

    // GridView更新按钮处理事件
    
    protected void gvCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int count = Convert.ToInt32((gvCart.Rows[e.RowIndex].FindControl("txtNumber") as TextBox).Text);
        string name = (gvCart.Rows[e.RowIndex].FindControl("lblBookName") as Label).Text;
        int res = cm.UpdateCount(count, user.username, name);
        gvCart.EditIndex = -1;
        BindGridView(user.username);

    }


    // GridView数据绑定后激发的事件
    protected void gvCart_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lb= e.Row.FindControl("lnkbtnDelete") as LinkButton;
            lb.Attributes.Add("onclick","return confirm('确定删除吗?')");
        }
    }
    

    // 计算总价
    private void TotalPrice()
    {
        List<Carts> list = cm.GetAllInfo(user.username);
        double Total = 0;
        for (int i = 0; i < list.Count; i++)
        {
            Carts ca = list[i];
            Total += Convert.ToDouble(ca.BookPrice*Convert.ToDouble(ca.BookCount));
        }

        ltrSalary.Text = Total.ToString();
    }
}
