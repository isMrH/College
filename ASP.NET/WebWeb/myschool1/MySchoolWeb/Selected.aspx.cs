using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;
public partial class Selected : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

    }
    protected void gvNewsType_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
    protected void gvNewsType_SelectedIndexChanged(object sender, EventArgs e)
    {
        int typeid = Convert.ToInt32(gvNewsType.DataKeys[gvNewsType.SelectedIndex].Value);
        gvNews.DataSource = NewsManager.GetNewsByTypeid(typeid);
        gvNews.DataBind();
    }
}
