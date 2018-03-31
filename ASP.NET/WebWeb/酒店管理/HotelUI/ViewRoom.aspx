<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="ViewRoom.aspx.cs" Inherits="ViewRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gvRoom" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="RoomID" 
        onpageindexchanging="gvRoom_PageIndexChanging" onrowcommand="gvRoom_RowCommand" 
        onrowdatabound="gvRoom_RowDataBound">
        <Columns>
            <asp:BoundField DataField="number" HeaderText="房间号" />
            <asp:TemplateField HeaderText="房间类型" SortExpression="type">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("type.typename") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="bednumber" HeaderText="床位数" />
            <asp:BoundField DataField="guestnumber" HeaderText="客人数" />
            <asp:TemplateField HeaderText="状态">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" 
                        Text='<%# GetRoomState(Eval("state").ToString()) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="描述">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Cut(Eval("Description")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="roomid" HeaderText="房间ID" />
            <asp:TemplateField HeaderText="编辑">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="编辑" 
                        CommandArgument='<%# Eval("RoomID") %>' CommandName="ed" 
                        ImageUrl="~/images/edit.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除">
                <ItemTemplate>
                    <asp:ImageButton ID="ImgbtnDelete" runat="server" AlternateText="删除" 
                        CommandName="dl" ImageUrl="~/images/delete.gif" 
                        CommandArgument='<%# Eval("roomid") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

