<%@ Page Title="" Language="C#" MasterPageFile="~/heath.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 57%;
            height: 140px;
        }
        .style2
        {
        }
        .style3
        {
            width: 133px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br /><br />
    <table class="style1" border="1">
        <tr>
            <td class="style3">
                体检项目编号：</td>
            <td>
                <asp:Label ID="ItemListld" runat="server" Text="ItemListld"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                体检项目名称：</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" Width="180px" AutoPostBack="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtname" ErrorMessage="体检项目不能为空！">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                必查项目：</td>
            <td>
                <asp:CheckBox ID="checkis" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                参考值：</td>
            <td>
                <asp:TextBox ID="txtcankao" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                价格：</td>
            <td>
                <asp:TextBox ID="txtprice" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                说明：</td>
            <td>
                <asp:TextBox ID="txtinfo" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:LinkButton ID="btnupd" runat="server" onclick="btnupd_Click">更新</asp:LinkButton>&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnexit" runat="server" onclick="btnexit_Click">取消</asp:LinkButton>
            </td>
        </tr>
        <tr>
            
            <td class="style2" colspan="2">
               <asp:Label ID="lblmessage" runat="server" Text="Label"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="38px" />
            </td>
        </tr>
    </table>
</asp:Content>

