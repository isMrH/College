<%@ WebHandler Language="C#" Class="BookCover"  %>
 
using System;
using System.Web;
using System.Drawing;
using System.IO;

public class BookCover : IHttpHandler {
    private string COVERSADDR = "~/Images/BookCovers/";
    private string WATERMARKADDR = "~/Images/watermark.jpg";
    private string DEFAULTIMAGE = "~/Images/default.jpg";
    public void ProcessRequest (HttpContext context) {        
        
        string path = context.Request.MapPath(COVERSADDR + context.Request.Params["ISBN"].ToString()+".jpg");
        System.Drawing.Image image;
        if (File.Exists(path))
        {
            image = Image.FromFile(path);
            Image watermark = Image.FromFile(context.Request.MapPath(WATERMARKADDR));
            Graphics g = Graphics.FromImage(image);
            g.DrawImage(watermark, new Rectangle(image.Width - watermark.Width, image.Height - watermark.Height, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel);
            g.Dispose();
        }
        else
        {
            image = Image.FromFile(context.Request.MapPath(DEFAULTIMAGE));
        }
        context.Response.ContentType = "image/jpeg";
        image.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
    }

    
    public bool IsReusable {
        get {
            return false;
        }
    }
}