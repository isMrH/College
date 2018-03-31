using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default2.aspx");
    }
    public string GetState(object state)
    {
        int newsstate = Convert.ToInt32(state);
        return newsstate == 1 ? "有效" : "无效";
    }
    public string GetTop(object top)
    {
        int newstop = Convert.ToInt32(top);
        return newstop == 1 ? "是" : "否";
    }

    public bool GetNewsState(object state)
    {
        int newsstate = Convert.ToInt32(state);
        return newsstate == 1 ? true : false;
    }
    public bool GetNewsTop(object top)
    {
        int newstop = Convert.ToInt32(top);
        return newstop == 1 ? true : false;
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
   
    protected void DetailsView1_ItemUpdating1(object sender, DetailsViewUpdateEventArgs e)
    {
        CheckBox chkState = DetailsView1.FindControl("chkState") as CheckBox;
        CheckBox chkTop = DetailsView1.FindControl("chkTop") as CheckBox;
        int state = chkState.Checked ? 1 : 0;
        int top = chkTop.Checked ? 1 : 0;

        ObjectDataSource1.UpdateParameters.Add("state", state.ToString());
        ObjectDataSource1.UpdateParameters.Add("isTop", top.ToString());
    }
}
