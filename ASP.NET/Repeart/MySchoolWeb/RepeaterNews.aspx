<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true" CodeFile="RepeaterNews.aspx.cs" Inherits="RepeaterNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:Repeater ID="repNews" runat="server">
    <HeaderTemplate>
        <dl>
    </HeaderTemplate>
    
    <ItemTemplate>    
        <dt><%# Eval("Title") %></dt>      
        <dd class="newsImage">
            <asp:Image ID="Image1" runat="server" Height="90px" width="80" ImageUrl='<%# Eval("PictureUrl","~/userFiles/{0}") %>' />                   
        </dd>
        <dd>
            <%# Eval("PublisherName")%>
        </dd>
        <dd>
            <%# Eval("Contents") %>
        </dd>
        
    </ItemTemplate>
    
    <FooterTemplate>
        </dl>
    </FooterTemplate>
    </asp:Repeater>
    </asp:Content>

