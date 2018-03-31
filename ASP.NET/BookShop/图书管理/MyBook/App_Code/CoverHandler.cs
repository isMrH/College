using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

/// <summary>
/// handler 的摘要说明,生成新图片的方式
/// </summary>
public class CoverHandler : IHttpHandler
{
    private string COVERSADDR = "~/Images/BookCovers/";             //封面路径
    private string WATERMARKADDR = "~/Images/watermark.jpg";        //水印图片
    private string DEFAULTIMAGE = "~/Images/default.jpg";           //默认图片
    public CoverHandler()
    {

    }
    public void ProcessRequest(HttpContext context)
    {
        //获取路径+ISBN的字符串
        string path = context.Request.MapPath(COVERSADDR + context.Request.Params["ISBN"].ToString());
        //判断新图片是否存在
        if (!File.Exists(path + "_new.jpg"))
        {
            MakeNewImage(path, context.Request.MapPath(WATERMARKADDR), context.Request.MapPath(DEFAULTIMAGE));
        }
        context.Response.ContentType = "image/jpeg";
        context.Response.WriteFile(path + "_new.jpg");
    }
    /// <summary>
    /// 根据封面原图、水印图、默认图，生成图片
    /// </summary>
    /// <param name="road"></param>
    /// <param name="watermarkroad"></param>
    /// <param name="defaultimage"></param>
    public void MakeNewImage(string road, string watermarkroad, string defaultimage)
    {
        System.Drawing.Image image;
        //判断原图是否存在
        if (!File.Exists(road + ".jpg"))
        {
            //加载默认图片
            image = System.Drawing.Image.FromFile(defaultimage);

        }
        else
        {
            //加载原图
            image = System.Drawing.Image.FromFile(road + ".jpg");
            System.Drawing.Image watermark = System.Drawing.Image.FromFile(watermarkroad);
            Graphics g = Graphics.FromImage(image);
            //绘制数字水印
            g.DrawImage(watermark, new Rectangle(image.Width - watermark.Width, image.Height - watermark.Height, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel);
            g.Dispose();
            watermark.Dispose();
        }
        
        string newPath = road + "_new.jpg";
        image.Save(newPath);
        image.Dispose();
    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}
