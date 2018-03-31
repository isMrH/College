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
    CartManager cm = new CartManager();
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
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登陆超时,请重新登陆！！');location.href='Order.aspx'</script>");
            return;
        }
        
        if (!IsPostBack)
        {
            //绑定数据
            BindGridView(user.LoginId);
           
        }
    }

    // 结算
   
    protected void imgb_Salary_Click(object sender, ImageClickEventArgs e)
    {
        //根据登录者的id将购物车里的信息取出来
        List<Carts> listcarts = cm.GetAllInfo(user.LoginId);
        int count = listcarts.Count;
        if (count == 0)
        {
            //如果该用户购物车为空，则提醒用户添加商品
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请选择要购买的图书！！')</script>");
            return;
        }
        //实例化银行serice类
        MyBank.Service service = new MyBank.Service();
        //调用方法
        int res = service.SelectAccount(user.LoginId, user.LoginPwd);
        //判断用户名和密码是否输入正确
        if (res > 0)
        {
            int res1 = service.SelectStatus(user.LoginId);
            //判断该账户的状态
            if (res1 == 1)
            {
                int res2 = service.SelectMoney(Convert.ToDouble(ltrSalary.Text), user.LoginId);
                //查看余额
                if (res2 > 0)
                {
                    int res3 = service.UpdateMoney(user.LoginId, Convert.ToDouble(ltrSalary.Text));
                    //支付账单，
                    if (res3 > 0)
                    {
                       
                        //将购物车的信息加入到历史订单中
                        List<Carts> listcarts1 = GetChecked();
                        for (int i = 0; i < listcarts1.Count; i++)
                        {
                            OrderDetails ods = new OrderDetails();
                            ods.UserId = user.LoginId;
                            ods.BookName = listcarts1[i].BookName;
                            ods.BookCount = listcarts1[i].BookCount;
                            ods.BookImage = listcarts1[i].BookImage;
                            ods.BookPrice = listcarts1[i].BookPrice;
                            ods.BuyDate =Convert.ToDateTime( DateTime.Now.ToLongDateString());
                            ods.Total = ods.BookPrice * Convert.ToDouble( ods.BookCount);
                            int re = odm.AddInfoByid(ods);
                            cm.DeleteById(listcarts1[i].BookName, user.LoginId);
                        }
                        BindGridView(user.LoginId);
                        //支付成功
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('支付成功,请查看订单！！');location.href='Order.aspx'</script>");

                        //Response.Redirect("Order.aspx");
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
        BindGridView(user.LoginId);
    }

    // GridView分页处理事件
    
    protected void gvCart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //取得当前页索引
        gvCart.PageIndex = e.NewPageIndex;
        //刷新列表
        BindGridView(user.LoginId);
    }

    // GridView删除按钮处理事件
    
    protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //取得要删除的书名
        string name =(gvCart.Rows[e.RowIndex].FindControl("lblBookName") as Label).Text;
        //根据书名和登录者id删除信息
        int res1 = cm.DeleteById(name, user.LoginId);
        if (res1 > 0)
        {
            //删除成功后刷新列表
            BindGridView(user.LoginId);
        }
    }

   // GridView取消按钮处理事件
    
    protected void gvCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //点击取消时，取消编辑状态
        gvCart.EditIndex = -1;
        //刷新列表
        BindGridView(user.LoginId);
    }

    // GridView更新按钮处理事件
    
    protected void gvCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //取得要更改的数量
        int count = Convert.ToInt32((gvCart.Rows[e.RowIndex].FindControl("txtNumber") as TextBox).Text);
        //取得书名
        string name = (gvCart.Rows[e.RowIndex].FindControl("lblBookName") as Label).Text;
        //根据书名和登录者id修改数量
        int res = cm.UpdateCount(count, user.LoginId,name);
        if (res > 0)
        {
            //更新完取消编辑状态
            gvCart.EditIndex = -1;
            //刷新列表
            BindGridView(user.LoginId);
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('更新错误！！')</script>");
        }

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
        List<Carts> list = new List<Carts>();
        list = GetChecked();
        if (list.Count > 0)
        {
            double Total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Carts ca = list[i];
                Total += Convert.ToDouble(ca.BookPrice * Convert.ToDouble(ca.BookCount));
            }

            ltrSalary.Text = Total.ToString();
        }
        else
        {
            ltrSalary.Text = "0";
        }
    }

    protected void chk_CheckedChanged(object sender, EventArgs e)
    {
        TotalPrice();
    }
    protected void chkall_CheckedChanged(object sender, EventArgs e)
    {
        TotalPrice();
    }

    private List<Carts> GetChecked()
    {
        int count = 0;
        count = gvCart.Rows.Count;
        List<Carts> list = new List<Carts>();
        for (int i = 0; i < count; i++)
        {
            CheckBox chk = gvCart.Rows[i].FindControl("chk") as CheckBox;
            if (chk.Checked == true)
            {
                string name = (gvCart.Rows[i].FindControl("lblBookName") as Label).Text;
                Carts ct = new Carts();
                ct = cm.GetByName(name, user.LoginId);
                list.Add(ct);
            }
        }

        return list;
    }
}
