using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManager.BLL;

public partial class ViewRoom : System.Web.UI.Page
{
    RoomManager roommanager = new RoomManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindRoom();
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
    protected void BindRoom()
    {
        this.gvRoom.DataSource = roommanager.GetAllRoom();
        this.gvRoom.DataBind();
    }
    //绑定房间状态
    public string GetRoomState(string state)
    {
        string ViewsState = string.Empty;
        if (state == "housing")
            ViewsState = "入住";
        else if (state == "modify")
            ViewsState = "维修";
        else if (state == "arrive")
            ViewsState = "将到";
        else if (state == "leave")
            ViewsState = "将离";
        else if (state == "empty")
            ViewsState = "空闲";
        else
            ViewsState = "自用";

        return ViewsState;
    }
   
    //执行分页
    protected void gvRoom_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvRoom.PageIndex = e.NewPageIndex;
        BindRoom();
    }
    protected void gvRoom_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string cmd = e.CommandName;
        int roomid =Convert.ToInt32( e.CommandArgument);
        //执行删除
        if (cmd == "dl")
        {
            roommanager.DelRoom(roomid);
        }
        //跳到添加或编辑页面
        else if (cmd == "ed")
        {
            Response.Redirect("AddRoom.aspx?roomid=" + Convert.ToString(roomid));
        }
        BindRoom();
    }
    protected void gvRoom_RowDataBound(object sender, GridViewRowEventArgs e)
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
}
