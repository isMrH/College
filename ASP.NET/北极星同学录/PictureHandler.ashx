<%@ WebHandler Language="C#" Class="PictureHandler" %>

using System;
using System.Web;
using System.Drawing;
using System.IO;
public class PictureHandler : IHttpHandler {

   //所用图片路径
    private string COVERPICTURE = "~/";
    //水印图片路径
    private string WATERMARKADDR = "~/photo/watermark.jpg";
    //默认图片路径
    private string DEFAULTIMAGE = "~/Image/noperson.jpg";
    public void ProcessRequest(HttpContext context)
    {
        //组合图片路径
        string path = context.Request.MapPath(COVERPICTURE + context.Request.Params["pictureName"].ToString());
        System.Drawing.Image image;
        //判断请求的物理路径中是否存在文件
        if (File.Exists(path))
        {
            //加载文件
            image = Image.FromFile(path);
            //加载水印图片
            Image watermark = Image.FromFile(context.Request.MapPath(WATERMARKADDR));
            //实例化画布
            Graphics g = Graphics.FromImage(image);
            //绘制
            g.DrawImage(watermark, new Rectangle(image.Width - watermark.Width, image.Height - watermark.Height, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel);
            //释放画布
            g.Dispose();
        }
        else
        {
            //加载默认图片
            image = Image.FromFile(context.Request.MapPath(DEFAULTIMAGE));
        }
        //设置输出格式
        context.Response.ContentType = "image/jpeg";
        
        image.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
    }


    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}