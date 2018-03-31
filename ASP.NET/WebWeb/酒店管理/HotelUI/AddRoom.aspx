<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="AddRoom.aspx.cs" Inherits="AddRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label1" runat="server" Text="房间号:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumber" runat="server" Visible="False"></asp:TextBox>
                <asp:Label ID="lblNumber" runat="server" Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNumber" Display="Dynamic" ErrorMessage="房间号不能为空！"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                    ControlToValidate="txtNumber" Display="Dynamic" ErrorMessage="房间号必须为数字！" 
                    Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtNumber" Display="Dynamic" ErrorMessage="该房间号已存在!" 
                    onservervalidate="CustomValidator1_ServerValidate" SetFocusOnError="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label2" runat="server" Text="客房类型:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label3" runat="server" Text="客房状态:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlState" runat="server" Width="81px">
                    <asp:ListItem Value="housing">入住</asp:ListItem>
                    <asp:ListItem Value="modify">维修</asp:ListItem>
                    <asp:ListItem Value="arrive">将到</asp:ListItem>
                    <asp:ListItem Value="leave">将离</asp:ListItem>
                    <asp:ListItem Value="empty">空闲</asp:ListItem>
                    <asp:ListItem Value="helponeself">自用</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label4" runat="server" Text="床位数:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBednumber" runat="server" Width="162px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="txtBednumber" Display="Dynamic" 
                    ErrorMessage="CompareValidator" Operator="DataTypeCheck" SetFocusOnError="True" 
                    Type="Integer">床位数必须为数字！</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtBednumber" Display="Dynamic" ErrorMessage="床位数不能为空！" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label5" runat="server" Text="客人数:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGuestnumber" runat="server" Width="162px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToCompare="txtBednumber" ControlToValidate="txtGuestnumber" 
                    ErrorMessage="CompareValidator" Operator="LessThanEqual" SetFocusOnError="True" 
                    Type="Integer">客人数必须为数字并且小于床位数！</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">
                <asp:Label ID="Label6" runat="server" Text="描述:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdes" runat="server" Height="104px" TextMode="MultiLine" 
                    Width="240px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="确定" />
&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

