<%@ Page Title="" Language="C#" MasterPageFile="~/Common.master" AutoEventWireup="true" CodeFile="RepeaterNews.aspx.cs" Inherits="RepeaterNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" Runat="Server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="排序方式："></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"> 按时间排序</asp:LinkButton>
    </p>
    <p>
        &nbsp;<asp:Repeater ID="rptNews" runat="server">
        <HeaderTemplate>
        <dl>
        </HeaderTemplate>
        <ItemTemplate>
           <dt><a href='show.aspx?newsid=<%#Eval("newsid") %>' target="_blank"><%#Eval("Title") %></a> </dt>
           <dd class="newsImage">
               <a href='show.aspx?newsid=<%#Eval("newsid") %>' target="_blank">
                   <asp:Image ID="img" runat="server" ImageUrl='<%#String.Format("~/userFiles/{0}",Eval("PictureUrl")) %>' Height="80px" Width="70px" /></a>

           </dd>
           <dd><%#Eval("PublishDate")%></dd>
           <dd><%#Eval("PublisherName") %></dd>
           <dd><%#Eval("Contents") %></dd>
        </ItemTemplate>
        <FooterTemplate>
        </dl>
        </FooterTemplate>
        </asp:Repeater>
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <asp:Button ID="btnPrev" runat="server" Text="上一页" onclick="btnPrev_Click" />
        <asp:Button ID="btnNext" runat="server" onclick="Button2_Click" Text="下一页" />
    </p>
</asp:Content>

