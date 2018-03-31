<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="CodeNewsList.aspx.cs" Inherits="AdminNews_CodeNewsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <p>
        <asp:GridView ID="gvNews" runat="server" 
            AutoGenerateColumns="False" 
            PageSize="5" Width="738px" DataKeyNames="NewsId">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="标题" />
                <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
                    HeaderText="出版时间">
                <HeaderStyle Width="100px" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Contents" HeaderText="新闻内容" HtmlEncode="False" />
            </Columns>
        </asp:GridView>
        <br />
    </p>
    </form>
</asp:Content>

