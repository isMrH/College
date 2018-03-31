using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;
using MySchool.Models;

public partial class AdminNews_NewsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    public string GetContents(object contents)
    {
        return StringHandler.CutString(contents, 15);
    }
    protected void btnModify_Click(object sender, EventArgs e)
    {
        string NewsId = "";

        //遍历所有选中的项
        for (int i = 0; i < gvNews.Rows.Count; i++)
        {
            //获取记录行的复选框
            CheckBox chkSelect = (gvNews.Rows[i].FindControl("chkAll")) as CheckBox;
            if (chkSelect.Checked)
            {
                //根据主键获取选中项的新闻ID
                NewsId += gvNews.DataKeys[i].Value+",";               
            }
        }
        if (NewsId.Length > 1)
        {
            NewsId = NewsId.Substring(0, NewsId.Length - 1);
            //执行更新操作,一次将所有的需更新的新闻类别修改掉，与数据库只交互一次，效率较高
            NewsManager.ModifyNewsType (NewsId, Convert.ToInt32 (this.ddlCategory.SelectedValue));
            //Response.Redirect("NewsList.aspx");
            gvNews.DataSourceID  = SchoolDataSource.ID ;
        }
       
    }
    protected void gvNews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        ////产生光棒效果
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    e.Row.Attributes.Add("onmouseover", "defaultcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
        //    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=defaultcolor");
        //}
    }
}