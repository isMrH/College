<%@ Page Title="" Language="C#" MasterPageFile="~/heath.master" AutoEventWireup="true" CodeFile="healthList.aspx.cs" Inherits="healthList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <br /> <br /> <br /> <br />
    <asp:GridView ID="gvlist" runat="server" Width="587px" 
        AutoGenerateColumns="False" DataKeyNames="ItemListld" AllowPaging="True" 
        CellPadding="4" ForeColor="#333333" GridLines="None" Height="165px" 
        onpageindexchanging="gvlist_PageIndexChanging" 
        onselectedindexchanged="gvlist_SelectedIndexChanged" PageSize="5" 
        onrowcommand="gvlist_RowCommand">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:TemplateField HeaderText="所属类别">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Heath.ItemTypeName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="体检项目名称" DataField="ItemListName" />
            <asp:TemplateField HeaderText="必查项">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("IsGood") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("IsGood") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="参考值" DataField="Standard" />
            <asp:BoundField HeaderText="价格" DataField="Price" />
            <asp:BoundField HeaderText="说明" DataField="Info" />
            <asp:TemplateField HeaderText="修改">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="btnupd" runat="server" 
                        CommandArgument='<%# Eval("ItemListld") %>' CommandName="upd">修改</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
</asp:GridView>
   
</asp:Content>

