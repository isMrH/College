<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="ViewRoomType.aspx.cs" Inherits="ViewRoomType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gvRoomtype" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" onrowcommand="gvRoomtype_RowCommand" 
        onrowdatabound="gvRoomtype_RowDataBound" AllowPaging="True" 
        DataKeyNames="typeid" onpageindexchanging="gvRoomtype_PageIndexChanging" 
        onrowdeleting="gvRoomtype_RowDeleting" 
        onselectedindexchanged="gvRoomtype_SelectedIndexChanged" Height="333px" 
        Width="726px">
    <Columns>
        <asp:BoundField DataField="typename" HeaderText="类型名称" />
        <asp:BoundField DataField="typeprice" HeaderText="类型价格" 
            DataFormatString="{0:c2}" />
        <asp:BoundField DataField="IsAddBed" HeaderText="是否加床" />
        <asp:BoundField DataField="AddBedPrice" HeaderText="加床价格" 
            DataFormatString="{0:c2}" />
        <asp:TemplateField HeaderText="备注">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Remark") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Cut(Eval("Remark")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="编辑">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="编辑" 
                    CommandArgument='<%# Eval("typeId") %>' ImageUrl="~/images/edit.gif" 
                    CommandName="ed" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="删除">
            <ItemTemplate>
                <asp:ImageButton ID="ImgbtnDelete" runat="server" CommandName="dl" 
                    ImageUrl="~/images/delete.gif" CommandArgument='<%# Eval("typeID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="typeid" HeaderText="类型编号" Visible="False" />
    </Columns>
</asp:GridView>
</asp:Content>

