<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #style
        {
        	width:676px;
        	height:495px;
        	margin:0px auto;
        }
        .style1
        {
            width: 58%;
        }
        .style2
        {
            width: 172px;
            height: 41px;
        }
        .style3
        {
            width: 132px;
            height: 93px;
        }
        .style4
        {
            height: 93px;
        }
        .style6
        {
            width: 172px;
            height: 36px;
            text-align:center;
            font-size:large;
        }
        .style7
        {
            width: 132px;
        }
        .style12
        {
            width: 132px;
            height: 52px;
        }
        .style13
        {
            height: 52px;
        }
        .style14
        {
            width: 132px;
            height: 56px;
        }
        .style15
        {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div  id="style" align="center">
    
        <table class="style1">
            <tr>
                <td class="style6" colspan="2" align="center">
                    用户信息</td>
            </tr>
            <tr>
                <td class="style7" align="right">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="156px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" align="right">
                    密码：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" ontextchanged="TextBox2_TextChanged" 
                        TextMode="Password" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" align="right">
                    重复密码：</td>
                <td>
                    <asp:TextBox ID="txtTruepwd" runat="server" TextMode="Password" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" align="right">
                    性别：</td>
                <td align="left">
                    <asp:RadioButtonList ID="rdolistSex" runat="server" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style3" align="right">
                    通讯地址：</td>
                <td class="style4">
                    <asp:TextBox ID="txtAddress" runat="server" Height="77px" TextMode="MultiLine" 
                        Width="226px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" align="right">
                    &nbsp;爱好：</td>
                <td align="left">
                    <asp:CheckBoxList ID="cblLove" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>游泳</asp:ListItem>
                        <asp:ListItem>爬山</asp:ListItem>
                        <asp:ListItem>跑步</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="style12" align="right">
                    所在省份：</td>
                <td class="style13" align="left">
                    <asp:DropDownList ID="ddlProvince" runat="server" 
                        onselectedindexchanged="ddlPrivate_SelectedIndexChanged" Height="30px" 
                        AutoPostBack="True" Width="125px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style14" align="right">
                    所在城市：</td>
                <td align="left" class="style15">
                    <asp:DropDownList ID="ddlCity" runat="server" Height="30px" Width="129px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Label ID="lblmessages" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6" colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="完成" onclick="btnSubmit_Click" 
                        Width="58px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
