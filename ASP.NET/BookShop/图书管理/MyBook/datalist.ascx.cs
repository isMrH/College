using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBook.Model;
using MyBookService.DAL;
using MyBookManager.BLL;

public partial class datalist : System.Web.UI.UserControl
{
    BookManager bm = new BookManager();
    public int number =10;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            DisBook(number);
        }
       
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        
        if (txtnumber.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请输入搜索条数！！')</script>");
            return;

        }
        number = Convert.ToInt32(txtnumber.Text.Trim());
        DisBook(number);

    }
    //自定义方法
    public void DisBook(int number)
    {
        //根据数量获得图书信息
        dataBooks.DataSource = bm.Getbooknumber(number);
        dataBooks.DataBind();
    }
    protected void dataBooks_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
