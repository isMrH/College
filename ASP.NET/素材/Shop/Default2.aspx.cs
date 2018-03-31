using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    MyShop1.ServiceClient sr = new MyShop1.ServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //页面加载时，为gridview加载全部信息
            gvGoods.DataSource = sr.GetAllInfo();
            gvGoods.DataBind();
        }
    }
    //查询
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        //根据商品名称查询
        gvGoods.DataSource =  sr.SelectByName(txtName.Text.Trim());
        gvGoods.DataBind();
    }
}
