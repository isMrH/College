<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
  
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="lblUser" runat="server" Text="账号"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="密码"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="登陆" onclick="btnLogin_Click" />
                <asp:Button ID="btnExit"
                    runat="server" Text="返回" /></td>

        </tr>
    </table>
  
</asp:Content>

