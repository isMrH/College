using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthTypeItemDB.BLL;
using HealthTypeItemDB.Medol;

public partial class update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblmessage.Visible = false;
            int ItemListlds = Convert.ToInt32(Request.QueryString["ItemListld"].ToString());
            if (ItemListlds != 0)
            {
               HealthItemList ha= HealthItemListManager.GetAllHealthItemListByid(ItemListlds);
               ItemListld.Text = ha.ItemListld.ToString();
               txtname.Text = ha.ItemListName;
                int i=ha.IsGood;
                if (i == 1)
                {
                    checkis.Checked = true;
                }
                else
                {
                    checkis.Checked = false;
                }
                txtcankao.Text = ha.Standard;
                txtprice.Text = ha.Price.ToString();
                txtinfo.Text = ha.Info;
                
            }
        }
    }

    protected void btnupd_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(ItemListld.Text);
        string name = txtname.Text;
        int isgood = 0;
        if (checkis.Checked == true)   
        {
            isgood = 1;
        }
        string cankao = txtcankao.Text;
        double price = Convert.ToDouble(txtprice.Text);
        string info = txtinfo.Text;
        int cnt = HealthItemListManager.updatelist(id, name, isgood, cankao, price, info);
        if (cnt > 0)
        {
            Response.Redirect("healthList.aspx");
        }
        else
        {
            lblmessage.Visible = true;
            lblmessage.Text = "修改失败";
        }
        
    }
    protected void btnexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("healthList.aspx");
    }
}
