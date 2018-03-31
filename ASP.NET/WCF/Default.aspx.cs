using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSS.Model;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //取得商品名称
            string name = txtName.Text.Trim();
            //实例化WCF服务
            PSSWCFService.ServiceClient service = new PSSWCFService.ServiceClient();
            //调用查重方法
            int count = service.IsHasInfo(name);
            if (count <= 0)
            {
                //如果没有，则进行添加
                Product pd = new Product();
                gs.GoodsName = txtName.Text.Trim();
                gs.GoodsCount = Convert.ToInt32(txtCount.Text.Trim());
                gs.GoodsPrice = Convert.ToInt32(txtPrice.Text.Trim());
                gs.Company = txtCompany.Text.Trim();
                //调用添加方法
                int res = service.AddInfo(gs);
                if (res > 0)
                {
                    //添加成功后提示，情况文本框
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！！')</script>");
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtCount.Text = "";
                    txtCompany.Text = "";
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加失败！！')</script>");
                }
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('商品名称已存在！！')</script>");
            }
        }
    }
    //退出按钮事件
    protected void btnExit_Click(object sender, EventArgs e)
    {
        //跳到查询页面
        Response.Redirect("~/Default2.aspx");
    }
}
