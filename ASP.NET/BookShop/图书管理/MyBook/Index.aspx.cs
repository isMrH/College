using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using AjaxControlToolkit;
using MyBookManager.BLL;
using MyBook.Model;

public partial class _Index : System.Web.UI.Page
{
    CategoryManager cm = new CategoryManager();
    BookManager bm = new BookManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DisplayHotBoks(); //显示书目录信息
        }        
    }

    protected void DisplayHotBoks()
    {
        //得到所有类型
        IList<Category> list = cm.GetAll();
        //遍历类型
        foreach (Category item in list)
        {
            //实例化一个控件
            AccordionPane ap = new AccordionPane();
            //实例化label
            Label lblCategory = new Label();
            //将类名存到label中
            lblCategory.Text = item.name;
            //将类名加到标题区
            ap.HeaderContainer.Controls.Add(lblCategory);
            //取得类的id
            int id = item.id;
            //根据类型id查找图书
            IList<Book> booklist = bm.GetBooksByCategoryId(id);
            foreach (Book bitem in booklist)
            {
                //实例化一个超链接控件
                HyperLink title = new HyperLink();
                //将书名放到超链接中
                title.Text = "&nbsp;&nbsp;&nbsp;"+bitem.Title+"<br/>";
                //取得书的id
                int bookid = bitem.Id;
                //设置超链接路径
                title.NavigateUrl = "bookshow.aspx?id="+bookid+"";
                //将书名加到内容区
                ap.ContentContainer.Controls.Add(title);
            }

            Accordion1.Panes.Add(ap);
        }
        
    }
}
