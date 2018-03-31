<%@ Page Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="ListBooksByCategory.aspx.cs" Inherits="Admin_ListBooksByCategory" Title="图书分类管理|第三波+书店" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">   
<script language="javascript">
 function GetAllCheckBox(parentItem)
  {
     var items = document.getElementsByTagName("input");     
     for(i=0; i<items.length;i++)
     {       
       if(parentItem.checked)
       {
         if(items[i].type=="checkbox")
          {
           items[i].checked = true;
          }
       }
       else
       {
          if(items[i].type=="checkbox")
          {
           items[i].checked = false;
          }
       }
     }
  }

</script>
<div style="font-size:small">
    <asp:GridView runat="server" ID="grv_Books" AutoGenerateColumns="False" DataSourceID="objdsBooks" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="98%" OnRowDataBound="grv_Books_RowDataBound" AllowPaging="True">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="chb_Select" />
                </ItemTemplate>
                <EditItemTemplate>
                    &nbsp;
                </EditItemTemplate>
                <HeaderTemplate>
                    &nbsp;<input id="cbAll" type="checkbox" onclick="GetAllCheckBox(this)" />全选
                </HeaderTemplate>
            </asp:TemplateField>
            <asp:TemplateField Visible="False">
                <ItemTemplate>
                    <asp:Label ID="lbl_Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Title" HeaderText="书名" />
            <asp:BoundField DataField="Author" HeaderText="作者" />
            <asp:TemplateField HeaderText="类别">               
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# GetCategary(Eval("Category")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>       
        <FooterStyle BackColor="#CCCC99" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    
     将选中书归入：
    <asp:DropDownList ID="ddl_Catagory" runat="server" DataSourceID="objdsCategories" DataTextField="Name" DataValueField="Id">
    </asp:DropDownList>
    <asp:Button runat="server" ID="btn_Sure" Text="确定" OnClick="btn_Sure_Click"/>
</div>
    <asp:ObjectDataSource ID="objdsBooks" runat="server" SelectMethod="GetAllBooks"
        TypeName="MyBookShop.BLL.BookManager"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="objdsCategories" runat="server" SelectMethod="GetAllCategories"
        TypeName="MyBookShop.BLL.CategoryManager"></asp:ObjectDataSource>
</asp:Content>

