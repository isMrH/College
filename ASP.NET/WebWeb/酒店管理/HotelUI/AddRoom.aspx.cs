using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManager.BLL;
using HotelManager.Model;


public partial class AddRoom : System.Web.UI.Page
{
    RoomManager roommanager = new RoomManager();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!this.IsPostBack)
        {
            RoomTypeManager rtmanager = new RoomTypeManager();
            ddlType.DataSource = rtmanager.GetAllType();
            ddlType.DataTextField = "typename";
            ddlType.DataValueField = "typeid";
            ddlType.DataBind();
            //如果传过来的roomid是空则执行添加代码
            if (Request.QueryString["roomid"] == null)
            {
                txtNumber.Visible = true;
            }
            else
            {
                lblNumber.Visible = true;
                int roomid = Convert.ToInt32(Request.QueryString["roomid"]);
                Room room = new Room();
                room = roommanager.GetRoomById(roomid);

                lblNumber.Text = room.Number;
                ddlType.Text = room.type.TypeName;
                ddlState.SelectedValue = room.State;
                ddlType.SelectedValue =room.TypeId.ToString();
                txtBednumber.Text =room.BedNumber.ToString();
                txtGuestnumber.Text = room.GuestNumber.ToString();
                txtdes.Text = room.Description.ToString();
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //如果传过来的typeid的值为空，则执行添加操作
        if (Request.QueryString["roomid"] == null)
        {
            if (Page.IsValid)
            {
                Room room = new Room();
                room.Number = txtNumber.Text.Trim();
                room.TypeId = Convert.ToInt32(ddlType.SelectedValue);
                room.State = ddlState.SelectedValue;
                room.GuestNumber = Convert.ToInt32(txtGuestnumber.Text);
                room.Description = txtdes.Text.Trim();


                int cnt = roommanager.InsertRoomInfo(room);
                if (cnt > 0)
                {
                    Response.Redirect("~/ViewRoom.aspx");
                }
                else
                {
                    lblMessage.Text = "添加失败！";
                }
            }
        }
        //否则执行修改操作
        else
        {
           
                Room room = new Room();
                room.TypeId = Convert.ToInt32(ddlType.SelectedValue);
                room.State = ddlState.SelectedValue;
                room.GuestNumber = Convert.ToInt32(txtGuestnumber.Text);
                room.Description = txtdes.Text.Trim();
                room.RoomId = Convert.ToInt32(Request.QueryString["roomid"]);

                int cnt = roommanager.UpdateRoomInfo(room);
                if (cnt > 0)
                {
                    Response.Redirect("~/ViewRoom.aspx");
                }
                else
                {
                    lblMessage.Text = "修改失败！";
                }
            }
        
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int cnt = roommanager.IsHasName(txtNumber.Text);
        if (cnt > 0)
        {
            args.IsValid = false;
        }
        else
        {
            args.IsValid = true;
        }
    }
}
