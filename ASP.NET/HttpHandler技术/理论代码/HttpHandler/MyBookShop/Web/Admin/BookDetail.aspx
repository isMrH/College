<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/admin.master" CodeFile="BookDetail.aspx.cs" Inherits="Books_BookDetail" Title="图书详细信息" ValidateRequest="false" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<asp:Content ContentPlaceHolderID=cphAdmin runat=server>

<script language="javascript" type="text/javascript" src="../My97DatePicker/WdatePicker.js" charset="gb2312"></script>
    <asp:DetailsView ID="dvBookList" runat="server" Height="50px" Width="735px" AutoGenerateRows="False" CellPadding="3" DataSourceID="odbBooks" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" OnItemUpdated="dvBookList_ItemUpdated" OnItemUpdating="dvBookList_ItemUpdating" OnItemInserting="dvBookList_ItemInserting" OnItemInserted="dvBookList_ItemInserted" OnDataBound="dvBookList_DataBound">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <Fields>
            <asp:TemplateField HeaderText="标题" SortExpression="Title">
                <EditItemTemplate>
                    <asp:TextBox ID="tbTitle" runat="server" Text='<%# Bind("Title") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="tbTitle"
                        ErrorMessage="标题不可为空"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbTitle" runat="server" Text='<%# Bind("Title") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="tbTitle"
                        ErrorMessage="标题不可为空"></asp:RequiredFieldValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="80px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="封面">
                <EditItemTemplate>
                    <asp:Image ID="imgBook" runat="server" ImageUrl='<%# Eval("ISBN", "~/images/BookCovers/{0}.jpg") %>' />&nbsp;
                    <asp:FileUpload ID="fulBook" runat="server" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    &nbsp;<asp:FileUpload ID="fulBook" runat="server" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="imgBook" runat="server" ImageUrl='<%# Eval("ISBN", "~/images/BookCovers/{0}.jpg") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="定价" SortExpression="UnitPrice">
                <EditItemTemplate>
                    <asp:TextBox ID="tbPrice" runat="server" Text='<%# Bind("UnitPrice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvprice" runat="server" ControlToValidate="tbPrice"
                        ErrorMessage="定价不可为空"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="tbPrice"
                        ErrorMessage="请填写正确的价格" ValidationExpression="^\d*(?:$|\.\d*$)"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    &nbsp;<asp:TextBox ID="tbPrice" runat="server" Text='<%# Bind("UnitPrice") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvprice" runat="server" ControlToValidate="tbPrice"
                        ErrorMessage="定价不可为空"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="tbPrice"
                        ErrorMessage="请填写正确的价格" ValidationExpression="^\d*(?:$|\.\d*$)"></asp:RegularExpressionValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbPrice" runat="server" Text='<%# Bind("UnitPrice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="出版社" SortExpression="Publisher">
                <InsertItemTemplate>
                    <asp:DropDownList ID="ddlPublisher" runat="server" DataSourceID="odsPublisher" DataTextField="Name" DataValueField="Id">
                    </asp:DropDownList>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Publisher" runat="server" Text='<%# Eval("Publisher.Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlPublisher" runat="server" DataSourceID="odsPublisher" DataTextField="Name" DataValueField="Id">
                    </asp:DropDownList>
                    <asp:HiddenField ID="hfPublisherId" runat="server" Value='<%# Eval("Publisher.Id") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="作者" SortExpression="Author">
                <EditItemTemplate>
                    <asp:TextBox ID="tbAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAuthor" runat="server" ControlToValidate="tbAuthor"
                        ErrorMessage="作者名不可为空"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAuthor" runat="server" ControlToValidate="tbAuthor"
                        ErrorMessage="作者名不可为空"></asp:RequiredFieldValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ISBN" SortExpression="ISBN">
                <EditItemTemplate>
                    <asp:Label ID="lbISBN" runat="server" Text='<%# Eval("ISBN") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbISBN" runat="server" Text='<%# Bind("ISBN") %>'></asp:Label>
                </ItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbISBN" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvIsbn" runat="server" ControlToValidate="tbISBN"
                        ErrorMessage="请填写ISBN"></asp:RequiredFieldValidator>
                </InsertItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="出版日期" SortExpression="PublishDate">
                <EditItemTemplate>  
                    <asp:TextBox ID="tbDate" runat="server" Text='<%# Bind("PublishDate") %>' CssClass="Wdate" onFocus="new WdatePicker(this,'%Y-%M-%D',true,'default')" ></asp:TextBox>&nbsp;
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbDate" runat="server" Text='<%# Bind("PublishDate") %>' CssClass="Wdate" onFocus="new WdatePicker(this,'%Y-%M-%D',true,'default')"></asp:TextBox>&nbsp;
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbDate" runat="server" Text='<%# Bind("PublishDate") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="字数" SortExpression="WordsCount">
                <EditItemTemplate>
                    &nbsp;<asp:TextBox ID="tbWordCount" runat="server" Text='<%# Bind("WordsCount") %>'></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revWordsCount" runat="server" ControlToValidate="tbWordCount"
                        ErrorMessage="请输入正确字数" ValidationExpression="^(-?[0-9]*[.]*[0-9]{0,3})$"></asp:RegularExpressionValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbWordCount" runat="server" Text='<%# Bind("WordsCount") %>'></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revWordsCount" runat="server" ControlToValidate="tbWordCount"
                        ErrorMessage="请输入正确字数" ValidationExpression="^(-?[0-9]*[.]*[0-9]{0,3})$"></asp:RegularExpressionValidator>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("WordsCount") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="目录" SortExpression="TOC">
                <EditItemTemplate>
                    <FTB:FreeTextBox ID="ftbToc" runat="server" Text='<%# Bind("TOC") %>' ImageGalleryUrl="../ftb.imagegallery.aspx?rif={0}&cif={0}">
                    </FTB:FreeTextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                    &nbsp;<FTB:FreeTextBox ID="ftbToc" runat="server" Text='<%# Bind("TOC") %>' ImageGalleryUrl="../ftb.imagegallery.aspx?rif={0}&cif={0}">
                    </FTB:FreeTextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbToc" runat="server" Text='<%# Bind("TOC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="内容摘要">
                <EditItemTemplate>
                    <asp:TextBox ID="tbDesc" runat="server" Text='<%# Bind("ContentDescription") %>'></asp:TextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbDesc" runat="server" Text='<%# Bind("ContentDescription") %>'></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbDesc" runat="server" Text='<%# Bind("ContentDescription") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="作者简介" SortExpression="AurhorDescription">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("AurhorDescription") %>'></asp:TextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("AurhorDescription") %>'></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("AurhorDescription") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="编辑推荐">
                <EditItemTemplate>
                    <asp:TextBox ID="tbComment" runat="server" Text='<%# Bind("EditorComment") %>'></asp:TextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="tbComment" runat="server" Text='<%# Bind("EditorComment") %>'></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbComment" runat="server" Text='<%# Bind("EditorComment") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="odbBooks" runat="server" SelectMethod="GetBookById"
        TypeName="MyBookShop.BLL.BookManager" UpdateMethod="ModifyBook" InsertMethod="AddBook">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="author" Type="String" />
            <asp:Parameter Name="TOC" Type="String" ConvertEmptyStringToNull="false" />
            <asp:Parameter Name="PublishDate" Type="DateTime" />            
            <asp:Parameter Name="ContentDescription" Type="String" ConvertEmptyStringToNull="false" />
            <asp:Parameter Name="editorComment" Type="String" ConvertEmptyStringToNull="false" />
            <asp:Parameter Name="AurhorDescription" Type="String" ConvertEmptyStringToNull="false" />
            <asp:QueryStringParameter DefaultValue="0" Name="id" QueryStringField="id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="author" Type="String" />
            <asp:Parameter Name="TOC" Type="String" ConvertEmptyStringToNull="false" />
            <asp:Parameter Name="PublishDate" Type="DateTime" />    
            <asp:Parameter Name="AurhorDescription" Type="String" ConvertEmptyStringToNull="false" />        
            <asp:Parameter Name="ContentDescription" Type="String" ConvertEmptyStringToNull="false" />
            <asp:Parameter Name="editorComment" Type="String" ConvertEmptyStringToNull="false" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsPublisher" runat="server" SelectMethod="GetAllPublishers"
        TypeName="MyBookShop.BLL.PublisherManager"></asp:ObjectDataSource>
</asp:Content>
