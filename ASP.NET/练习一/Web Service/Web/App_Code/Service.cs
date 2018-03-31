using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MyTicketSale.BLL;
using MyTicketSale.Model;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
// [System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }
    TicketManager tm = new TicketManager();
    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public Ticket TicketSelect(string trainNo, string fromplace, string toplace,int type)
    {
        Ticket ticket = new Ticket();
        ticket = tm.GetTicketByFilter(trainNo, fromplace, toplace, type);
        return ticket;
    }
    [WebMethod]
    public int TicketCount(string trainNo, string fromplace, string toplace, int type)
    {
        Ticket ticket = new Ticket();
        int res = tm.GetCount(trainNo, fromplace, toplace, type);
        return res;
    }
}
