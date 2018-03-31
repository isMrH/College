<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">    
        .style1
    {
        width: 91%;
        font-size:12px;
        border:1px solid Aqua;
        height: 241px;
    }
    .style2
    {
    }
    .style3
    {
            width: 139px;
            text-align: right;
        }
    .style4
    {
        text-align: left;
        height: 31px;
        background-color:Aqua;
    }
    .style5
    {
	    text-align:center;
        height: 22px;
    }
    .Pan
    {
	    width:440px;
	    margin:30px auto;
        height: 253px;
    }
    .style6
    {
        width: 266px;
        text-align:left;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Pan">
<asp:Panel ID="panAdd" runat="server" Height="250px" Width="493px">
    <table class="style1" align="center">
        <tr>
            <td align="center" colspan="2" class="style4">
                &nbsp;&nbsp; 注册新用户</td>
        </tr>
        <tr>
            <td align="center" class="style5" colspan="2">
                注册新用户方便又容易</td>
        </tr>
        <tr>
            <td class="style3">
                用户名：</td>
            <td class="style6">
                <asp:TextBox ID="txtUname" runat="server" Width="189px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                昵称：</td>
            <td class="style6">
                <asp:TextBox ID="txtNName" runat="server" Width="189px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                密码：</td>
            <td class="style6">
                <asp:TextBox ID="txtAPWD" runat="server" Width="189px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                确认密码：</td>
            <td class="style6">
                <asp:TextBox ID="txtRePwd" runat="server" Width="189px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Email：</td>
            <td class="style6">
                <asp:TextBox ID="txtEmail" runat="server" Width="189px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ErrorMessage="Email格式不正确"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                QQ：</td>
            <td class="style6">
                <asp:TextBox ID="txtQQ" runat="server" Width="189px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style2" colspan="2">
                <asp:Label ID="lblErr" runat="server" ForeColor="#CC0000" Height="20px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style2" colspan="2">
                <asp:ImageButton ID="btnAdd0" runat="server" ImageUrl="~/images/333.jpg" 
                    onclick="btnAdd0_Click" />
            </td>
        </tr>
    </table>
</asp:Panel>
</div>
</asp:Content>

