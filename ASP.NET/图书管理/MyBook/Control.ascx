<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Control.ascx.cs" Inherits="Control" %>
<p>
    ISBN：<asp:TextBox ID="txtsearch" runat="server" Width="239px" 
         BorderColor="#70F24F" BorderWidth="1px" Height="20px"></asp:TextBox>
    <asp:Button ID="btnsearch" runat="server" Text="搜索" Width="64px" Height="22px" 
        onclick="btnsearch_Click" />
</p>
