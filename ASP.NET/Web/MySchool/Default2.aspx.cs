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
    public string Cut(object obj)
    {
        string str = obj.ToString();
        if (str.Length > 30)
        {
            return str.Substring(0, 30) + "...";
        }
        else
        {
            return str;
        }
    }
}
