<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.master" AutoEventWireup="true" CodeFile="AddRoomType.aspx.cs" Inherits="AddRoomType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 67px">
                <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="类型名称:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="190px" Visible="False"></asp:TextBox>
                <asp:Label ID="lblName" runat="server" Font-Size="Small" Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="类型名称不能为空!" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" 
                    ErrorMessage="该类型已存在!" onservervalidate="CustomValidator1_ServerValidate" 
                    SetFocusOnError="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 67px">
                <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="类型价格:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server" Width="190px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPrice" ErrorMessage="类型价格不能为空！" Display="Dynamic" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="txtPrice" ErrorMessage="价格只能为数字！" Operator="DataTypeCheck" 
                    Type="Integer" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 67px">
                <asp:Label ID="Label4" runat="server" Font-Size="Small" Text="是否加床:"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rdoIsadd" runat="server" 
                    RepeatDirection="Horizontal" 
                    onselectedindexchanged="rdoIsadd_SelectedIndexChanged">
                    <asp:ListItem>是         </asp:ListItem>
                    <asp:ListItem>否        </asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 67px">
                <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="加床价格:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAddPrice" runat="server" Width="190px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ErrorMessage="加床价格必须为数字！" Operator="DataTypeCheck" Type="Integer" 
                    ControlToValidate="txtAddPrice"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 67px">
                <asp:Label ID="Label5" runat="server" Font-Size="Small" Text="备注:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRemark" runat="server" Height="100px" TextMode="MultiLine" 
                    Width="315px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSubmit" runat="server" Text="确定" onclick="btnSubmit_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

