using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelManager.BLL;
using HotelManager.Model;

public partial class AddRoomType : System.Web.UI.Page
{
    RoomTypeManager rtmanager = new RoomTypeManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //如果传过来的值是空的，则是添加
            if (Request.QueryString["typeid"] == null)
            {
                txtName.Visible = true;
                rdoIsadd.SelectedValue = "是";
            }
            //
            else
            {
                lblName.Visible = true;
                rdoIsadd.SelectedValue = "是";
                RoomType rt = new RoomType();
                int typeid=Convert.ToInt32( Request.QueryString["typeid"]);
                rt = rtmanager.GetTypeByTypeid(typeid);
                //显示信息
                lblName.Text = rt.TypeName;
                txtPrice.Text = rt.TypePrice.ToString();
                rdoIsadd.SelectedValue = rt.IsAddBed.ToString();
                txtAddPrice.Text = rt.AddBedPrice.ToString();
                txtRemark.Text = rt.Remark;

                
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //如果传过来的typeid的值为空，则执行添加操作
        if (Request.QueryString["typeid"] == null)
        {
            if (Page.IsValid)
            {
                RoomType roomtype = new RoomType();
                roomtype.TypeName = txtName.Text.Trim();
                roomtype.TypePrice = Convert.ToInt32(txtPrice.Text.Trim());
                roomtype.IsAddBed = rdoIsadd.SelectedValue.ToString();
                roomtype.AddBedPrice = Convert.ToInt32(txtAddPrice.Text.Trim());
                roomtype.Remark = txtRemark.Text.Trim();


                int cnt = rtmanager.InsertRoomType(roomtype);
                if (cnt > 0)
                {
                    Response.Redirect("~/ViewRoomType.aspx");
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
            
                RoomType roomtype = new RoomType();
                roomtype.TypePrice = Convert.ToInt32(txtPrice.Text.Trim());
                roomtype.IsAddBed = rdoIsadd.SelectedValue.ToString();
                roomtype.AddBedPrice = Convert.ToInt32(txtAddPrice.Text.Trim());
                roomtype.Remark = txtRemark.Text.Trim();
                roomtype.TypeId = Convert.ToInt32(Request.QueryString["typeid"]);

                int cnt = rtmanager.UpdateRoomType(roomtype);
                if (cnt > 0)
                {
                    Response.Redirect("~/ViewRoomType.aspx");
                }
                else
                {
                    lblMessage.Text = "修改失败！";
                }
            }
        
    }
    //如果是否加床为否，则加床价格框不可用，加床价格为空
    protected void rdoIsadd_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdoIsadd.SelectedValue == "否")
        {
            txtAddPrice.Enabled = false;
            txtAddPrice.Text = "0";
        }
    }
    //自定义验证，判断是否重名
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string typename = txtName.Text.Trim();
        int cnt = rtmanager.IsHasName(typename);
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
