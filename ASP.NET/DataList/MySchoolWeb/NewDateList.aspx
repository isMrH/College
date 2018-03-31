<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true" CodeFile="NewDateList.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:Button ID="btnSort" runat="server" Text="ÅÅÐò" onclick="btnSort_Click" />
    <asp:DataList ID="dlNews" runat="server" Width="457px" Height="487px">
        <SeparatorTemplate>
        <hr />
        </SeparatorTemplate>
        <ItemTemplate>
            <table style="width:82%;">
                <tr>
                    <td rowspan="2">
                        <asp:Image ID="Image1" runat="server" Height="90px" width="80"
                            ImageUrl='<%# Eval("PictureUrl","~/userFiles/{0}") %>' />
                    </td>
                    <td>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblData" runat="server" Text='<%# Eval("PublishDate") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblContents" runat="server" Text='<%# Eval("Contents") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

