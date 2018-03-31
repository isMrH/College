<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListOfBooks.aspx.cs" MasterPageFile="~/Admin/admin.master" Inherits="Books_ListOfBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">   

<div style="font-size:small">
    <asp:GridView runat="server" ID="grv_Books" AutoGenerateColumns="False" DataSourceID="objdsBooks" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="98%" OnRowDataBound="grv_Books_RowDataBound" AllowPaging="True">
        <Columns>
            <asp:TemplateField Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lbl_Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Title" HeaderText="书名" />
            <asp:BoundField DataField="Author" HeaderText="作者" />
            <asp:TemplateField HeaderText="类别">               
                <ItemTemplate>
                    <asp:Label ID="lblCategory" runat="server" Text='<%# GetCategary(Eval("Category")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFormatString="BookDetail.aspx?id={0}"
                Text="详细" DataNavigateUrlFields="id" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>       
        <FooterStyle BackColor="#CCCC99" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    &nbsp;&nbsp;&nbsp;
    <asp:ObjectDataSource ID="objdsBooks" runat="server" SelectMethod="GetAllBooks"
        TypeName="MyBookShop.BLL.BookManager" DeleteMethod="DeleteBookById">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>
</div>
</asp:Content>
