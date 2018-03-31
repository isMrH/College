using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;
using MySchool.Models;

public partial class AdminNews_CodeNewsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayNews();
        }
      
    }   
    private void DisplayNews()
    {
        //GridView控件的数据绑定
        
    }   
}