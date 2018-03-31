<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Selected.aspx.cs" Inherits="Selected" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:GridView ID="gvNewsType" runat="server" AutoGenerateColumns="False" 
        DataSourceID="odsNewsType" Width="290px" AllowPaging="True" 
        DataKeyNames="TypeId" onselectedindexchanged="gvNewsType_SelectedIndexChanged" 
        PageSize="5">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Title" HeaderText="类型" 
                SortExpression="Title" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="odsNewsType" runat="server" 
        SelectMethod="GetAllNewsTypes" TypeName="MySchool.BLL.NewsTypeManager">
    </asp:ObjectDataSource>
    <br />
    <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
                SortExpression="NewsId" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:ImageField DataImageUrlField="PictureUrl" 
                DataImageUrlFormatString="~/userFiles/{0}" HeaderText="缩略图">
                <ControlStyle Width="150px" />
            </asp:ImageField>
            <asp:BoundField DataField="Clicks" HeaderText="Clicks" 
                SortExpression="Clicks" />
        </Columns>
        <EmptyDataTemplate>
            没有符合条件的新闻
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
    </form>
</asp:Content>

