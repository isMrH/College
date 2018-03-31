<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="任务1——分页排序.aspx.cs" Inherits="任务1__分页排序" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAllNews" SortParameterName="sortExpression" 
        TypeName="MySchool.BLL.NewsManager">
        <SelectParameters>
            <asp:Parameter Name="sortExpression" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" PageSize="5" 
        AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
                SortExpression="NewsId" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="PictureUrl" HeaderText="PictureUrl" 
                SortExpression="PictureUrl" />
            <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" 
                SortExpression="PublishDate" />
            <asp:BoundField DataField="PublisherName" HeaderText="PublisherName" 
                SortExpression="PublisherName" />
            <asp:BoundField DataField="Clicks" HeaderText="Clicks" 
                SortExpression="Clicks" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="Contents" HeaderText="Contents" 
                SortExpression="Contents" />
            <asp:BoundField DataField="IsTop" HeaderText="IsTop" SortExpression="IsTop" />
        </Columns>
    </asp:GridView>
    </form>
</asp:Content>

