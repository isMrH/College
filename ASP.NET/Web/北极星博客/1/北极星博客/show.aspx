<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="show" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #main
        {
            height: 273px;
            width:450px;
            margin-left:75px;
            margin-top:50px;
            border:1px solid #CECDB7;
            text-align:center;
        }
        #Label5
        {
        	text-align:center;
        }
        #IBtnAchieve
        {
        	text-align:center;
        }
        #m
        {
        	text-align:left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
    <p id="m">
    <asp:Label runat="server" Text="注册新用户" BackColor="#CECDB7" Height="23px" 
            Width="450px"></asp:Label>
    </p>
    <br />
    <asp:Label ID="Label5" runat="server" Text="注册新用户方便又容易" Width="450px"></asp:Label>
        <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="用户名:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server" Width="163px"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="昵称:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" Width="163px"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="密码:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtPwd" runat="server" Width="163px" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="确认密码:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtTruePwd" runat="server" Width="163px" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Email:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" Width="163px"></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="QQ:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtQQ" runat="server" Width="163px" 
        ontextchanged="TextBox6_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblMess" runat="server"></asp:Label>
    <br />
    <p id="IBtnAchieve">
        <asp:ImageButton ID="IBtnAchieve" runat="server" ImageUrl="~/333.jpg" 
            onclick="IBtnAchieve_Click" />
        </p>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

