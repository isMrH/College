<%@ WebHandler Language="C#" Class="BookCover" %>
using System;
using System.Web;
using System.Drawing;
using System.IO;
public class BookCover : IHttpHandler
{
    //封面文件夹路径
    private const string COVERSADDR = "~/Images/BookCovers/";
    //数字水印路径
    private const string WATERMARK_URL = "~/Images/watermark.jpg";
    //默认图片的路径
    private string DEFAULTIMAGE_URL = "~/Images/default.jpg";
    public void ProcessRequest(HttpContext context)
    {
        //组合图片的路径
        string path = context.Request.MapPath(COVERSADDR + context.Request.Params["ISBN"].ToString() + ".jpg");
        System.Drawing.Image Cover;

        if (File.Exists(path))
        {
            //加载文件
            Cover = Image.FromFile(path);
            //加载水印图片
            Image watermark = Image.FromFile(context.Request.MapPath(WATERMARK_URL));
            //实例化画布
            Graphics g = Graphics.FromImage(Cover);
            //在image上绘制水印
            g.DrawImage(watermark, new Rectangle(Cover.Width - watermark.Width, Cover.Height - watermark.Height, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel);
            //释放画布
            g.Dispose();
            //释放水印图片
            watermark.Dispose();
        }
        else
        {
            //使用默认的图片
            Cover = Image.FromFile(context.Request.MapPath(DEFAULTIMAGE_URL));
        }
        context.Response.ContentType = "image/jpeg";	//设置输出类型为jpeg图片
        //将修改过后的图片存入输出流
        Cover.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);			//将修改的图片存入输出流
        Cover.Dispose();
        context.Response.End();
    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}
