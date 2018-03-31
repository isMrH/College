using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManager.BLL;
using System.Data;

public partial class ViewRoomType : System.Web.UI.Page
{
    RoomTypeManager rtmanager = new RoomTypeManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindRoomType();
        }
    }
    //截取文本
    public string Cut(object obj)
    {
        string str = obj.ToString();
        if (str.Length > 20)
        {
            return str.Substring(0, 20) + "...";
        }
        else
        {
            return str;
        }
    }
    //数据填充
    protected void BindRoomType()
    {
        this.gvRoomtype.DataSource = rtmanager.GetAllType();
        this.gvRoomtype.DataBind();
    }
    //执行数据行按钮事件
    protected void gvRoomtype_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string cmd = e.CommandName;
        int typeid = Convert.ToInt32(e.CommandArgument);
        //执行删除
        if (cmd == "dl")
        {
            int cnt = rtmanager.IsHasRoomInfo(typeid);
            if (cnt > 0)
            {
                Response.Write("<script>alert('该类型房间已有住房信息,不能删除！')</script>");
            }
            else
            {
                rtmanager.DeleteTypeInfo(typeid);
            }
             
        }
        //跳到添加或编辑页面
        else if(cmd=="ed")
        {
            Response.Redirect("AddRoomtype.aspx?typeid="+Convert.ToString(typeid));
        }
        BindRoomType();
    }
    protected void gvRoomtype_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //产生光棒效果
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "defaultcolor=this.style.backgroundColor;this.style.backgroundColor='#ff9900'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=defaultcolor");
        }
        //如果绑定是数据行
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //模板删除
            ImageButton lbDel = e.Row.FindControl("ImgbtnDelete") as ImageButton;
            lbDel.Attributes.Add("onclick", "javascript:return confirm('你确认要删除吗？')");
        }
    }
    //执行分页
    protected void gvRoomtype_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvRoomtype.PageIndex = e.NewPageIndex;
        BindRoomType();
    }
    protected void gvRoomtype_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        
    }
    protected void gvRoomtype_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
