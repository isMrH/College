using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;
using MyBookShop.Models;
using System.Xml;

public partial class Admin_AddBooksCatagory : System.Web.UI.Page
{
    private const string ADD = "增加";
    private const string ADDCATEGORY = "增加分类";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Add_Click(object sender, EventArgs e)
    {
        if (((Button)sender).Text.Equals(ADDCATEGORY))
        {
            this.Operation(true, ADD);
        }
        else
        {
            this.Operation(false, ADDCATEGORY);
            PutData();
            Response.Redirect("AddBooksCatagory.aspx");
        }
    }

    private void Operation(bool flag, string font)
    {
        this.txt_BookCatagory.Visible = flag;
        this.btn_Add.Text = font;
    }

    private void PutData()
    {
        Category cate = new Category();
        cate.Name = this.txt_BookCatagory.Text.Trim();
        CategoryManager.AddCategory(cate);
        XmlDocument xdTree = new XmlDocument();
        xdTree.Load(Server.MapPath("~/TreeView.xml"));
        XmlElement xmlNew=xdTree.CreateElement("siteMapNode");
        xmlNew.SetAttribute("title",cate.Name);
        xmlNew.SetAttribute("url","BookList.aspx?typeid=1");//+cate.Id.ToString());
        xmlNew.SetAttribute("description","");        
        xdTree.SelectSingleNode("siteMapNode").AppendChild(xmlNew);
        xdTree.Save(Server.MapPath("~/TreeView.xml"));
    }
}
