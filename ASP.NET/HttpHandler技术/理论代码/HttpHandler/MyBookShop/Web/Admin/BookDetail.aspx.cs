using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Books_BookDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["id"] == null)
        {
            this.dvBookList.DefaultMode = DetailsViewMode.Insert;
        }
    }

    protected void dvBookList_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        FileUpload fulBook = this.dvBookList.FindControl("fulBook") as FileUpload;
        Image imgBook = this.dvBookList.FindControl("imgBook") as Image;
        string FileName = fulBook.FileName;
        if (FileName.Trim().Length != 0)
        {
            string strpath =Server.MapPath(imgBook.ImageUrl);
            fulBook.PostedFile.SaveAs(strpath);//把图片保存在此路径中
        }
       
    }

    protected void dvBookList_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        DropDownList ddlPublisher = this.dvBookList.FindControl("ddlPublisher") as DropDownList;
        this.odbBooks.UpdateParameters.Add("PublisherId",ddlPublisher.SelectedValue);
    }
    protected void dvBookList_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        DropDownList ddlPublisher = this.dvBookList.FindControl("ddlPublisher") as DropDownList;
        TextBox tbIsbn = this.dvBookList.FindControl("tbISBN") as TextBox;
        this.odbBooks.InsertParameters.Add("PublisherId", ddlPublisher.SelectedValue);
        this.odbBooks.InsertParameters.Add("Isbn", tbIsbn.Text.Trim());
        FileUpload fulBook = this.dvBookList.FindControl("fulBook") as FileUpload;
        string FileName = fulBook.FileName;
        if (FileName.Trim().Trim().Length != 0)
        {
            string strpath = Server.MapPath("~/images/BookCovers/" + tbIsbn.Text.Trim() + ".jpg");
            fulBook.PostedFile.SaveAs(strpath);//把图片保存在此路径中
        }
    }
    protected void dvBookList_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        //添加新书后重定向到图书列表页
        Response.Redirect("ListOfBooks.aspx");
    }

    protected void dvBookList_DataBound(object sender, EventArgs e)
    {
        if (dvBookList.CurrentMode == DetailsViewMode.Edit)
        {
            DropDownList ddlPublisher = this.dvBookList.FindControl("ddlPublisher") as DropDownList;
            HiddenField lblPublisher = this.dvBookList.FindControl("hfPublisherId") as HiddenField;
            ddlPublisher.SelectedValue = lblPublisher.Value.Trim();
        }
    }
}
