<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true" CodeFile="NewsWeb.aspx.cs" Inherits="NewsWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 101px;
        }
        .style2
        {
            width: 237px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="排序方式："></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">按日期排序</asp:LinkButton>
        <br />
        <asp:DataList ID="dlNews" runat="server" RepeatColumns="1" Width="648px">
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
            <ItemTemplate>
                <table style="width:100%;">
                    <tr>
                        <td rowspan="2" class="style1">
                            <asp:Image ID="Image1" runat="server" 
                                ImageUrl='<%# Eval("PictureUrl","~/userFiles/{0}") %>' Width="90px" Height="90px" />
                        </td>
                        <td class="style2">
                            <a href='show.aspx?newsid=<%# Eval("newsid") %>'><asp:Label ID="Label1" runat="server" Text='<%# Eval("Title") %>'></asp:Label></a>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("PublishDate") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Contents") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>
</asp:Content>

