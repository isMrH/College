using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyTicketSale.Model;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        TicketService.Service ticketservice = new TicketService.Service();
        
        string trainNo = txtTicketNo.Text.Trim();
        string fromPlace = txtFromplace.Text.Trim();
        string toPlace = txtToplace.Text.Trim();
        int type = ddlType.SelectedIndex;
        int count = ticketservice.TicketCount(trainNo, fromPlace, toPlace, type);
        if (count > 0)
        {
            lblErrorInfo.Text = "";
            TicketService.Ticket ticket = new TicketService.Ticket();
            ticket = ticketservice.TicketSelect(trainNo, fromPlace, toPlace, type);
            lblNum.Text = ticket.Num.ToString() + "(张)";
            lblUnitprice.Text = ticket.UnitPrice.ToString() + "(元)";
            lblStartTime.Text = ticket.StartTime.ToString() + "(北京时间)";
        }
        else
        {
            lblNum.Text = "";
            lblUnitprice.Text = "";
            lblStartTime.Text = "";
            lblErrorInfo.Text = "没有可销售的票！";
        }
    }
}
