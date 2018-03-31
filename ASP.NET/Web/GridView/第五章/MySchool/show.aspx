<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="show" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<form runat="server" style="height: 362px">
<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
    DataSourceID="odsShow" Height="118px" Width="399px">
    <Fields>
        <asp:BoundField DataField="Title" HeaderText="标题" SortExpression="Title" />
        <asp:TemplateField HeaderText="类型" SortExpression="Type">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Type") %>'></asp:TextBox>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Type") %>'></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Type.title") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:ImageField DataImageUrlField="PictureUrl" 
            DataImageUrlFormatString="~/images/{0}" HeaderText="新闻图片">
            <ControlStyle Height="120px" Width="120px" />
            <FooterStyle Width="120px" />
            <HeaderStyle Height="120px" Width="120px" />
            <ItemStyle Width="120px" />
        </asp:ImageField>
        <asp:BoundField DataField="PublisherDate" HeaderText="出版时间" 
            SortExpression="PublisherDate" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="PublisherName" HeaderText="出版社" 
            SortExpression="PublisherName" />
        <asp:BoundField DataField="Clicks" HeaderText="点击量" SortExpression="Clicks" />
        <asp:BoundField DataField="State" HeaderText="状态" 
            SortExpression="State" />
        <asp:BoundField DataField="Contents" HeaderText="内容" 
            SortExpression="Contents" />
        <asp:BoundField DataField="IsTop" HeaderText="是否置顶" SortExpression="IsTop" />
    </Fields>
</asp:DetailsView>
<asp:ObjectDataSource ID="odsShow" runat="server" SelectMethod="GetNewByNewsId" 
    TypeName="MySchool.BLL.NewsManager">
    <SelectParameters>
        <asp:QueryStringParameter Name="newsId" QueryStringField="newsid" 
            Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
</form>
</asp:Content>

