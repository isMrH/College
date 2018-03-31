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
    public string Cut(object obj)
    {
        //限制长度
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
        //模板列操作
        if (e.CommandName == "details")
        {
            Response.Redirect("show.aspx?id=" + e.CommandArgument);
        }
        else if (e.CommandName == "ndelet")
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
            LinkButton btnDel = e.Row.Cells[8].Controls[0] as LinkButton;
            btnDel.Attributes.Add("onclick","javascrdipt:return confirm('你确认要删除吗？')");

            LinkButton ldel = e.Row.FindControl("ldelet") as LinkButton;
            ldel.Attributes.Add("onclick", "javascrdipt:return confirm('你确认要删除吗？')");
        }
    }
    protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //限制词
        if (gvNews.Rows[e.RowIndex].Cells[3].Text.Contains("河北"))
        {
            e.Cancel = true;
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('不能删除标题中含有\"河北\"的新闻')</script>");
        }
    }
}
