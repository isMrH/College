<%@ Page Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true"  CodeFile="ListAllUsers.aspx.cs" Inherits="_ListAllUsers" Title="用户管理|第三波+书店" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">

    <div style="font-size:small">       
        <asp:GridView ID="gvMain" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical"
         DataSourceID="objdsUsers" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" Width="777px" DataKeyNames="Id" AllowPaging="True" PageSize="7" OnRowDataBound="gvMain_RowDataBound" OnRowCommand="gvMain_RowCommand">
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
        <asp:ObjectDataSource ID="objdsUsers" runat="server" SelectMethod="GetAllNormalUsers"
            TypeName="MyBookShop.BLL.UserManager" DeleteMethod="DeleteUserById" UpdateMethod="ModifyBasicInfo" OldValuesParameterFormatString="{0}">           
        </asp:ObjectDataSource>       
    </div>

</asp:Content>

