<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="AddRoomType.aspx.cs" Inherits="AddRoomType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:100%;margin:0px;padding:0px; height: 308px;">
    <table style="width: 383px; height: 301px; border-style: solid; border-width: 1px;margin:auto">
        <tr>
            <td align="right" style="width: 207px">
                类型名称：</td>
            <td style="width: 237px">
                <asp:TextBox ID="txtTypeName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 207px">
                类型价格：</td>
            <td style="width: 237px">
                <asp:TextBox ID="txtTypePrice" runat="server" 
                    ontextchanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 207px; height: 29px">
                是否加床：</td>
            <td style="height: 29px; width: 237px;">
                <asp:RadioButtonList ID="rdoAddBed" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>是</asp:ListItem>
                    <asp:ListItem>否</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 207px">
                加床价格：</td>
            <td style="width: 237px">
                <asp:TextBox ID="txtAddTypePrice" runat="server" 
                    ontextchanged="TextBox4_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 207px; height: 131px">
                备注：</td>
            <td style="height: 131px; width: 237px;">
                <asp:TextBox ID="txtRemark" runat="server" Height="104px" style="margin-top: 0px" 
                    TextMode="MultiLine" Width="279px" ontextchanged="txtRemark_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="确认" Width="147px" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>

