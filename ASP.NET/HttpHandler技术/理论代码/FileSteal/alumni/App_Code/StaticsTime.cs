using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
/// <summary>
/// StaticsTime 的摘要说明
/// </summary>
public class StaticsTime : IHttpHandler, IRequiresSessionState
{
	     public void ProcessRequest(HttpContext context)
        {
            string rawUrl = context.Request.RawUrl;
            DateTime startTime = DateTime.Now;
         
            string aspxPagePath = rawUrl.Substring(0, rawUrl.IndexOf(".aspx") + 5);
            IHttpHandler handler = PageParser.GetCompiledPageInstance(aspxPagePath, null, context);

            
            handler.ProcessRequest(context);
            TimeSpan duration = DateTime.Now - startTime;
            context.Response.Write(String.Format("页面执行时: {0} ms.", 
                duration.Milliseconds));
        }

        /**//// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get { return true; }
        }

}
