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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //如果传过来的值是空的，则是添加
            if (Request.QueryString["typeid"] == null)
            {
                txtTypeName.Enabled = true;
                rdoAddBed.SelectedValue = "是";
            }
            //
            else
            {
                txtTypeName.Enabled = true;
                rdoAddBed.SelectedValue = "是";
                RoomType rt = new RoomType();
                int typeid = Convert.ToInt32(Request.QueryString["typeid"]);
                rt=RoomTypeManager
                //显示信息
                


            }
        }

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtRemark_TextChanged(object sender, EventArgs e)
    {

    }
}
