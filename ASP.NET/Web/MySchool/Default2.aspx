<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<form runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1" Width="633px">
        <Columns>
            <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
                SortExpression="NewsId" />
            <asp:BoundField DataField="Title" HeaderText="Title" 
                SortExpression="Title" />
            <asp:TemplateField HeaderText="Type" SortExpression="Type">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Type") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Type.title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager"></asp:ObjectDataSource>
        </form>
</asp:Content>

