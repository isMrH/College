<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<form runat="server">
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
    AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
    <Fields>
        <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
            SortExpression="NewsId" />
        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
        <asp:ImageField DataImageUrlField="PictureUrl" 
            DataImageUrlFormatString="~/userFiles/{0}" HeaderText="图片">
            <ControlStyle Height="150px" Width="150px" />
        </asp:ImageField>
        <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" 
            SortExpression="PublishDate" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="PublisherName" HeaderText="PublisherName" 
            SortExpression="PublisherName" />
        <asp:BoundField DataField="Clicks" HeaderText="Clicks" 
            SortExpression="Clicks" />
        <asp:BoundField DataField="State" HeaderText="State" 
            SortExpression="State" />
        <asp:BoundField DataField="Contents" HeaderText="Contents" 
            SortExpression="Contents" />
        <asp:BoundField DataField="IsTop" HeaderText="IsTop" 
            SortExpression="IsTop" />
    </Fields>
</asp:DetailsView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="GetNewsByNewsId" TypeName="MySchool.BLL.NewsManager">
    <SelectParameters>
        <asp:QueryStringParameter Name="newsId" QueryStringField="newsid" 
            Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
<br />
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="返回新闻首页" />
</form>
</asp:Content>

