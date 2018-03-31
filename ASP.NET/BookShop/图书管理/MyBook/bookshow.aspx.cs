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
    BookManager bm = new BookManager();
    CartManager cm = new CartManager();
    User user= new User();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            //根据isbn查询信息，从BookList页转过来
            if (Request.QueryString["isbn"] != null) 
            {
                string isbn = Request.QueryString["isbn"].ToString();
                //查询是否有该信息
                int res = bm.IsHasInfo(isbn);
                if (res > 0)
                {
                    //调用方法
                    DisplayBook(isbn);
                }
                else
                {
                    
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('没有该ISBN号的图书信息！！')</script>");
                    //Response.Redirect("booklist.aspx");
                }
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

        Book book = bm.Getbookisbn(isbn);
        //调用方法
        info(book);
        
    }
    //自定义根据id查询信息的方法
    public void DisplayBookByid(int id)
    {


        Book book = bm.GetbookisByid(id);
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
    //购买按钮事件
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //判断是否登录
        if (Session["LoginUser"] != null)
        {
            //将登录信息存到session中
            user = Session["LoginUser"] as User;
            //取得要购买的书名
            string BookName = lbltitle.Text.Trim();
            //数量
            int count = cm.SelectCount(BookName, user.LoginId);
            //给数量赋值
            count = count + 1;
            //查询购物车中是否有该书名
            int res = cm.IsHasInfo(BookName, user.LoginId);
            if (res > 0)
            {
                //如果有该书，就更改它的数量
                int result = cm.UpdateCount(count, user.LoginId,lbltitle.Text);
            }
            else
            {
                //如果没有，就将该书信息存到表中
                //实例化购物车类，将选择的信息存入到购物车类
                Carts cs = new Carts();
                cs.UserId = user.LoginId;
                cs.BookImage = lblISBN.Text;
                cs.BookName = lbltitle.Text;
                cs.BookCount = 1;
                cs.BookPrice =Convert.ToDouble(( lblmoney.Text));
                //将信息加入购物车表
                int res1 = cm.AddInfo(cs);
            }
            //跳到购物车页
            Response.Redirect("Cart.aspx");
        }
        else
        {
            //跳到登陆页
            Response.Redirect("Login.aspx");
        }
    }
}
