using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyAirTicket.BLL;
using MyAirTicket.Model;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    CityInfoManager cm = new CityInfoManager();
    ProvinceInfoManager pm = new ProvinceInfoManager();
    TicketManager tm = new TicketManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlProvince.DataSource = pm.GetAllInfo();
            ddlProvince.DataValueField = "ProviceId";
            ddlProvince.DataTextField = "ProviceName";
            ddlProvince.DataBind();

            ddlProvince1.DataSource = pm.GetAllInfo();
            ddlProvince1.DataValueField = "ProviceId";
            ddlProvince1.DataTextField = "ProviceName";
            ddlProvince1.DataBind();

            ddlCity.DataSource = cm.GetCityBypid(1);
            ddlCity.DataValueField = "CityId";
            ddlCity.DataTextField = "CityName";
            ddlCity.DataBind();

            ddlCity1.DataSource = cm.GetCityBypid(1);
            ddlCity1.DataValueField = "CityId";
            ddlCity1.DataTextField = "CityName";
            ddlCity1.DataBind();

            txtDate.Text = DateTime.Now.ToString("yyyy-M-dd");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtDate.Text = Calendar1.SelectedDate.Date.ToString("yyyy-M-dd");
        Calendar1.Visible = false;
        Button1.Visible = false;
    }
    //出发地
    protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        int pid = Convert.ToInt32(ddlProvince.SelectedValue);
        ddlCity.Items.Clear();
        ddlCity.DataSource = cm.GetCityBypid(pid);
        ddlCity.DataValueField = "CityId";
        ddlCity.DataTextField = "CityName";
        ddlCity.DataBind();
    }

    //到达地
    protected void ddlProvince1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int pid = Convert.ToInt32(ddlProvince1.SelectedValue);
        ddlCity1.Items.Clear();
        ddlCity1.DataSource = cm.GetCityBypid(pid);
        ddlCity1.DataValueField = "CityId";
        ddlCity1.DataTextField = "CityName";
        ddlCity1.DataBind();
    }
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        int fid = Convert.ToInt32(ddlCity.SelectedValue);
        int tid = Convert.ToInt32(ddlCity1.SelectedValue);
        string leavedate = txtDate.Text.Trim();
        List<Ticket> list = tm.GetTicketByFilter(fid, tid, leavedate);
        gvTicket.DataSource = list;
        gvTicket.DataBind();
    }
}
