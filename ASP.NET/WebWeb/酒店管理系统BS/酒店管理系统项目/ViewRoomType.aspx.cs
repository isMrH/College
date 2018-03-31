using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManager.BLL;

public partial class ViewRoomType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindRoomType();
        }
    }
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
    public void BindRoomType()
    {
        this.gvRoomType.DataSource = RoomTypeManager.GetAllRoomType();
        this.gvRoomType.DataBind();
    }

    protected void gvRoomType_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string cmd = e.CommandName;
        int typeID = Convert.ToInt32(e.CommandArgument);
        if (cmd == "cmdDelete")
        {
            int obj;
            obj = Convert.ToInt32(RoomTypeManager.GetScalarRoomByTypeID(typeID));
            if (obj > 0)
            {
                Response.Write("<script>alert('此类型房间已存在，禁止删除！')</script>");
                return;
            }
            else
            {
                RoomTypeManager.DeleteRoomTypeByTypeID(typeID);
            }
        }
        else if (cmd == "cmdEdit")
        {
            Response.Redirect("~/AddRoomType.aspx");
 
        }
        BindRoomType();
    }
    protected void gvRoomType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvRoomType.PageIndex = e.NewPageIndex;
        BindRoomType();
    }
    protected void gvRoomType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvRoomType_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType==DataControlRowType.DataRow)
        {
            //设置行颜色
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor");
            //添加删除确认
            ImageButton imgbtn = (ImageButton)e.Row.FindControl("btnDelete");
            imgbtn.Attributes.Add("onclick","return confirm('您确认要删除吗？');");
        }
    }
}
