<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<form runat="server">
<asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" 
    DataSourceID="odsDefault" DataKeyNames="NewsId" 
    onrowcommand="GridView1_RowCommand" 
    onselectedindexchanged="GridView1_SelectedIndexChanged1">
    <Columns>
        <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
            SortExpression="NewsId" />
        <asp:TemplateField HeaderText="Type" SortExpression="Type">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Type") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Type.title") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:ImageField DataImageUrlField="PictureUrl" 
            DataImageUrlFormatString="~/images/{0}" HeaderText="略缩图">
            <ControlStyle Width="120px" />
        </asp:ImageField>
        <asp:BoundField DataField="Title" HeaderText="新闻标题" SortExpression="Title" />
        <asp:BoundField DataField="PublisherDate" DataFormatString="{0:yyyy-MM-dd}" 
            HeaderText="出版时间" SortExpression="PublisherDate" />
        <asp:TemplateField HeaderText="Contents" SortExpression="Contents">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Contents") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Cut(Eval("Contents")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:HyperLinkField DataNavigateUrlFields="newsid" 
            DataNavigateUrlFormatString="~/show.aspx?newsid={0}" HeaderText="详细信息" 
            Text="查看详情" />
        <asp:TemplateField HeaderText="删除">
            <ItemTemplate>
                <asp:LinkButton ID="btnDel" runat="server">删除</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="odsDefault" runat="server" SelectMethod="GetAllNews" 
    TypeName="MySchool.BLL.NewsManager"></asp:ObjectDataSource>
</form>
</asp:Content>

