using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBook.Model;
using MyBookService.DAL;
using MyBookManager.BLL;

public partial class bookshow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            //根据isbn查询信息，从BookList页转过来
            if (Request.QueryString["isbn"] != null) 
            {
                string isbn = Request.QueryString["isbn"].ToString();
                //调用方法
                DisplayBook(isbn);
            }
            //根据id查询信息，从BookDataList页转过来
            if (Request.QueryString["id"] != null)
            {
                int id =Convert.ToInt32(Request.QueryString["id"]);
                DisplayBookByid(id);
            }
        
        }
    }
    //自定义根据isbn查询信息的方法
    public void DisplayBook(string isbn)
    {

        Book book = BookManager.Getbookisbn(isbn);
        //调用方法
        info(book);
        
    }
    //自定义根据id查询信息的方法
    public void DisplayBookByid(int id)
    {

       
        Book book = BookManager.GetbookisByid(id);
        //调用方法
        info(book);
    }
    //返回列表页
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookList.aspx");
    }
    //自定义填充方法
    public void info(Book book)
    {
        lbltitle.Text = book.Title;
        lblauthor.Text = book.Author;
        lblname.Text = book.Title;
        lblpusher.Text = book.Publisher.name;
        lblISBN.Text = book.ISBN;
        lblpusherdata.Text = book.PublishDate.ToString();
        lblcount.Text = book.WordsCount.ToString();
        lblmoney.Text = book.UnitPrice.ToString();
        lblcontent.Text = book.ContentDescription;
        imgpicture.ImageUrl = "Images/BookCovers/" + (book.ISBN) + ".jpg";
    }
    CartsManager cm = new CartsManager();
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["us"] != null)
        {
            Users us = Session["us"] as Users;
            int count = cm.SelectCount(lbltitle.Text,us.username);
            count++;
            int has = cm.IsHasInfo(lbltitle.Text, us.username);
            if (has > 0)
            {
                cm.UpdateCount(count, us.username, lbltitle.Text);
            }
            else
            {
                Carts ct = new Carts();
                ct.BookName = lbltitle.Text;
                ct.BookImage = lblISBN.Text;
                ct.BookCount = 1;
                ct.BookPrice = Convert.ToDouble(lblmoney.Text);
                ct.UserId = us.username;
                cm.AddInfo(ct);
            }
            Response.Redirect("Cart.aspx");
        }
        else 
        {
            Response.Redirect("Login.aspx");
        }
    }
}
