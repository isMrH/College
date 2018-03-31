<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        #form1
        {
            height: 222px;
            width: 670px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" PageSize="5">
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
                <ControlStyle Width="50px" />
            </asp:TemplateField>
            <asp:BoundField DataField="Title" HeaderText="标题" SortExpression="Title" />
            <asp:ImageField DataImageUrlField="PictureUrl" 
                DataImageUrlFormatString="~/img/{0}" HeaderText="缩略图">
                <ControlStyle Width="120px" />
            </asp:ImageField>
            <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
                HeaderText="出版日期" SortExpression="PublishDate" />
            <asp:TemplateField HeaderText="内容" SortExpression="Contents">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Contents") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Cut(Eval("Contents")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="newsid" 
                DataNavigateUrlFormatString="~/show.aspx?newsid={0}" HeaderText="详细信息" 
                Text="查看详情">
            <ControlStyle Width="100px" />
            </asp:HyperLinkField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager">
    </asp:ObjectDataSource>
    </form>
</asp:Content>

