<%@ Page Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="AddBooksCatagory.aspx.cs" Inherits="Admin_AddBooksCatagory" Title="分类管理|第三波+书店" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">
<div>
    <asp:TextBox runat="server" ID="txt_BookCatagory" Visible="false"></asp:TextBox>
    <asp:Button id="btn_Add" runat="server" Text="增加分类" OnClick="btn_Add_Click"></asp:Button>
</div>
<div style="font-size:small">
    <asp:GridView ID="gvMain" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" DataSourceID="objdsUsers" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" Width="777px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="分类名称" SortExpression="Name" /> 
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:ObjectDataSource ID="objdsUsers" runat="server" SelectMethod="GetAllCategories"
            TypeName="MyBookShop.BLL.CategoryManager">         
        </asp:ObjectDataSource>
</div>

</asp:Content>

