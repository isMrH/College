<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Selected.aspx.cs" Inherits="Selected" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:GridView ID="gvNewsType" runat="server" AutoGenerateColumns="False" 
        DataSourceID="odsType" Width="290px" AllowPaging="True" 
        DataKeyNames="TypeId" onselectedindexchanged="gvNewsType_SelectedIndexChanged" 
        onselectedindexchanging="gvNewsType_SelectedIndexChanging" PageSize="5">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="TypeId" HeaderText="TypeId" 
                SortExpression="TypeId" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="odsType" runat="server" 
        SelectMethod="GetAllNewsTypes" TypeName="MySchool.BLL.NewsTypeManager">
    </asp:ObjectDataSource>
    <br />
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
            没有符合条件的新闻信息
        </EmptyDataTemplate>
    </asp:GridView>
    </form>
</asp:Content>

