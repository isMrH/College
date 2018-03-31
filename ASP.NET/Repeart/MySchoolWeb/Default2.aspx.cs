using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //截取文本
    public string Cut(object obj)
    {
        string str = obj.ToString();
        if (str.Length > 30)
        {
            return str.Substring(0, 30) + "...";
        }
        else
        {
            return str;
        }
    }
    protected void btnModify_Click(object sender, EventArgs e)
    {
        string strNewsIDs = "";
        for (var i = 0; i < gvNews.Rows.Count; i++)
        {
            CheckBox chk = gvNews.Rows[i].FindControl("chk") as CheckBox;
            if (chk != null && chk.Checked == true)
            {
                strNewsIDs += gvNews.DataKeys[i].Value + ",";
            }
        }
        if (strNewsIDs.Length > 0)
        {
            strNewsIDs = strNewsIDs.Substring(0, strNewsIDs.Length - 1);
            string newstypeid = DropDownList1.SelectedValue.ToString();

            if (NewsManager.UpdateTypeID(strNewsIDs, newstypeid) > 0)
            {
                gvNews.DataSourceID = objNews.ID;
            }
        }
    }
    protected void gvNews_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvNews_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "details")
        {
            Response.Redirect("show.aspx?id=" + e.CommandArgument);
        }
        else if (e.CommandName == "ndelete")
        {
            NewsManager.DeleteNewsId(Convert.ToInt32(e.CommandArgument));
            gvNews.DataSourceID = objNews.ID;
        }
    }
    protected void gvNews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //产生光棒效果
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover","defaultcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
            e.Row.Attributes.Add("onmouseout","this.style.backgroundColor=defaultcolor");
        }
        //如果绑定是数据行
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //微软删除
            LinkButton btnDel = e.Row.Cells[8].Controls[0] as LinkButton;
            btnDel.Attributes.Add("onclick","javascript:return confirm('你确认要删除吗？')");
            //模板删除
            LinkButton lbDel = e.Row.FindControl("lbDel") as LinkButton;
            lbDel.Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗？')");
        }
    }
    //验证
    protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //取正在删除列的新闻标题文本，检查文本中是否包含关键字
        if (gvNews.Rows[e.RowIndex].Cells[3].Text.Contains("超市"))
        {
            //取消删除
            e.Cancel = true;
            //输出提示信息
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('不能删除标题中含有\"超市\"的新闻')</script>");
        }
    }
}
