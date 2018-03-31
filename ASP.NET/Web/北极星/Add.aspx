<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">    
        .style1
    {
        width: 97%;
        font-size:12px;
        border:1px solid Aqua;
        height: 284px;
    }
    .style2
    {            height: 36px;
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
	    width:460px;
	    margin:10px auto;
        height: 283px;
    }
    .style6
    {
        width: 216px;
        text-align: left;
    }
        .style7
        {
            height: 26px;
        }
        .style8
        {
            width: 139px;
            text-align: right;
            height: 2px;
        }
        .style9
        {
            width: 216px;
            text-align: left;
            height: 2px;
        }
        .style10
        {
            width: 139px;
            text-align: right;
            height: 11px;
        }
        .style11
        {
            width: 216px;
            text-align: left;
            height: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Pan">
<asp:Panel ID="panAdd" runat="server" Height="285px" Width="496px">
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtUname" Display="Dynamic" ErrorMessage="用户名不能为空！">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                昵称：</td>
            <td class="style6">
                <asp:TextBox ID="txtNName" runat="server" Width="189px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtNName" Display="Dynamic" ErrorMessage="昵称不能为空！">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                密码：</td>
            <td class="style6">
                <asp:TextBox ID="txtAPWD" runat="server" Width="189px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtAPWD" Display="Dynamic" ErrorMessage="密码不能为空！">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtRePwd" ControlToValidate="txtAPWD" Display="Dynamic" 
                    ErrorMessage="两次密码不一致！">*</asp:CompareValidator>
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
            <td class="style10">
                Email：</td>
            <td class="style11">
                <asp:TextBox ID="txtEmail" runat="server" Width="189px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email不能为空！">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email格式不正确！" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                QQ：</td>
            <td class="style9">
                <asp:TextBox ID="txtQQ" runat="server" Width="189px" Height="20px"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtQQ" Display="Dynamic" ErrorMessage="请输入正确的QQ号码！" 
                    onservervalidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToValidate="txtQQ" Display="Dynamic" ErrorMessage="请输入正确的QQ号码！" 
                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="center" class="style2" colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="44px" 
                    style="margin-top: 0px" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style7" colspan="2">
                <asp:ImageButton ID="btnAdd0" runat="server" ImageUrl="~/images/333.jpg" 
                    onclick="btnAdd0_Click" />
            </td>
        </tr>
    </table>
</asp:Panel>
</div>
</asp:Content>

