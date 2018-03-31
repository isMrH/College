<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataSourceID="ObjectDataSource1" Height="50px" Width="259px">
        <Fields>
            <asp:BoundField DataField="Title" HeaderText="标题" SortExpression="Title">
            <ControlStyle Width="150px" />
            <FooterStyle Width="150px" />
            <HeaderStyle Width="150px" />
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:ImageField DataImageUrlField="PictureUrl" 
                DataImageUrlFormatString="~/img/{0}" HeaderText="缩略图">
                <ControlStyle Width="120px" />
            </asp:ImageField>
            <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
                HeaderText="发布日期" SortExpression="PublishDate" />
            <asp:BoundField DataField="PublisherName" HeaderText="发布者" 
                SortExpression="PublisherName" />
            <asp:BoundField DataField="Clicks" HeaderText="点击量" SortExpression="Clicks" />
            <asp:BoundField DataField="State" HeaderText="状态" SortExpression="State" />
            <asp:BoundField DataField="Contents" HeaderText="内容" 
                SortExpression="Contents" />
            <asp:BoundField DataField="IsTop" HeaderText="是否置顶" SortExpression="IsTop" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetNewsByNewsId" TypeName="MySchool.BLL.NewsManager">
        <SelectParameters>
            <asp:QueryStringParameter Name="newsid" QueryStringField="newsid" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </form>
</asp:Content>

