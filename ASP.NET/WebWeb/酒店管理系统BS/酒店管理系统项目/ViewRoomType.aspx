<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="ViewRoomType.aspx.cs" Inherits="ViewRoomType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gvRoomType" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" Height="246px" 
        onpageindexchanging="gvRoomType_PageIndexChanging" 
        onrowcommand="gvRoomType_RowCommand" onrowdatabound="gvRoomType_RowDataBound" 
        onselectedindexchanged="gvRoomType_SelectedIndexChanged" Width="723px">
        <Columns>
            <asp:BoundField DataField="TypeName" HeaderText="类型名称" />
            <asp:BoundField DataField="TypePrice" HeaderText="类型价格" />
            <asp:BoundField DataField="AddBedPrice" HeaderText="是否加床" />
            <asp:BoundField DataField="IsAddBed" HeaderText="加床价格" />
            <asp:BoundField DataField="Remark" HeaderText="备注" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEdit" runat="server" 
                        CommandArgument='<%# Eval("TypeID") %>' CommandName="cmdEdit" 
                        ImageUrl="~/images/edit.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnDelete" runat="server" 
                        CommandArgument='<%# Eval("TypeID") %>' CommandName="cmdDelete" 
                        ImageUrl="~/images/delete.gif" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

