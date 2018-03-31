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
        <asp:Label ID="Label4" runat="server" Text="����ʽ��"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">����������</asp:LinkButton>
        <br />
        <asp:DataList ID="dlNews" runat="server" RepeatColumns="1" Width="648px">
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
            <ItemTemplate>
                <table style="width:100%;">
                    <tr>
                        <td rowspan="2" class="style1">
                            <a href='show.aspx?newsid=<%#Eval("NewsId") %>'><asp:Image ID="Image1" runat="server" 
                                ImageUrl='<%# Eval("PictureUrl","~/userFiles/{0}") %>' Width="90px" Height="90px" /></a>
                        </td>
                        <td class="style2">
                            <a href='show.aspx?newsid=<%#Eval("NewsId") %>'><asp:Label ID="Label1" runat="server" Text='<%# Eval("Title") %>'></asp:Label></a>
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
        <asp:Label ID="lblMesage" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnPrev"
            runat="server" Text="��һҳ" onclick="btnPrev_Click" />
        <asp:Button ID="btnNext" runat="server" Text="��һҳ" onclick="btnNext_Click" />
    </p>
</asp:Content>

