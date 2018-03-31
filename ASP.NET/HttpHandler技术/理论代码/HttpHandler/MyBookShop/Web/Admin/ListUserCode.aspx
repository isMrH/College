<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/admin.master" CodeFile="ListUserCode.aspx.cs" Inherits="Admin_ListUserCode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">

    <div style="font-size:small">       
        <asp:GridView ID="gvMain" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" Width="777px" DataKeyNames="Id" AllowPaging="True" PageSize="7" OnRowDataBound="gvMain_RowDataBound" OnRowCommand="gvMain_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="False"/>
                <asp:BoundField DataField="Address" HeaderText="地址" SortExpression="Address" />
                <asp:BoundField DataField="LoginId" HeaderText="用户名" SortExpression="LoginId" />
                <asp:BoundField DataField="Phone" HeaderText="电话" SortExpression="Phone" />
                <asp:BoundField DataField="Name" HeaderText="姓名" SortExpression="Name" />
                <asp:BoundField DataField="Mail" HeaderText="Email" SortExpression="Mail" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="linb_Delete" runat="server" CausesValidation="False" CommandName="Delete"
                            Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linb_View" runat="server" CommandName="View" Text="详细" CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
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
        &nbsp;
    </div>

</asp:Content>