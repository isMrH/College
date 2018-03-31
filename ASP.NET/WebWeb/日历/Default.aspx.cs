using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        string message;
        if (fulFile.HasFile)
        {
            try
            {
                string strPath = Server.MapPath("~/images/");
                fulFile.PostedFile.SaveAs(strPath + fulFile.FileName);
                message = "上传成功<br/>上传的文件名为：" + fulFile.FileName + "<br>" + "文件大小:" + fulFile.PostedFile.ContentLength + "b<br>" + "文件类型：" + fulFile.PostedFile.ContentType;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }
        else
        {
            message = "您没有选择任何文件！";
            
        }
        lblMes.Text = message;
    }
}
